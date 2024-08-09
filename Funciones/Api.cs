using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;

namespace Api
{
    public class InformacionClimatica
    {
        public string? Descripcion { get; set; }
        public double Temperatura { get; set; }
        public string? Ciudad { get; set; }
    }

    public class ServicioClima
    {
        private readonly string _claveApi;
        private readonly HttpClient _clienteHttp;

        public ServicioClima(string claveApi)
        {
            _claveApi = claveApi;
            _clienteHttp = new HttpClient();
        }

        public async Task<InformacionClimatica> ObtenerClimaAsync(string ciudad, string codigoPais)
        {
            string url = $"https://api.openweathermap.org/data/2.5/weather?q={ciudad},{codigoPais}&appid={_claveApi}&units=metric";

            HttpResponseMessage respuesta = await _clienteHttp.GetAsync(url);

            if (respuesta.IsSuccessStatusCode)
            {
                string datos = await respuesta.Content.ReadAsStringAsync();

                // Parsear la respuesta JSON
                using (JsonDocument doc = JsonDocument.Parse(datos))
                {
                    JsonElement raiz = doc.RootElement;

                    string? descripcion = raiz.GetProperty("weather")[0].GetProperty("description").GetString();
                    double temperatura = raiz.GetProperty("main").GetProperty("temp").GetDouble();
                    string? nombreCiudad = raiz.GetProperty("name").GetString();

                    return new InformacionClimatica
                    {
                        Descripcion = descripcion,
                        Temperatura = temperatura,
                        Ciudad = nombreCiudad
                    };
                }
            }
            else
            {
                throw new Exception($"Error al obtener el clima: {respuesta.StatusCode}");
            }
        }
        public static void GuardarClima(InformacionClimatica clima, string nombreArchivo)
        {
            List<InformacionClimatica> climas;
            if (File.Exists(nombreArchivo))
            {
                climas = LeerClima(nombreArchivo);
            }
            else
            {
                climas = new List<InformacionClimatica>();
            }

            climas.Add(clima);

            var opcionesJson = new JsonSerializerOptions { WriteIndented = true };
            string jsonString = JsonSerializer.Serialize(climas, opcionesJson);
            File.WriteAllText(nombreArchivo, jsonString);
        }

        public static List<InformacionClimatica> LeerClima(string nombreArchivo)
        {
            if (!File.Exists(nombreArchivo))// preguntar si json tiene algo
            {
                Console.WriteLine("\nEl archivo no existe");
                return new List<InformacionClimatica>();
            }
            string? json = File.ReadAllText(nombreArchivo);
            return JsonSerializer.Deserialize<List<InformacionClimatica>>(json);
        }
    }
}