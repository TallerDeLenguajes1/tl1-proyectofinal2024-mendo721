using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Personajes;


namespace Historial
{
    public class Ganador
    {
        public Personaje PersonajeGanador { get; set; }
        public DateTime Fecha { get; set; }
        public string InformacionRelevante { get; set; }
        
        

        public Ganador(Personaje personajeGanador, DateTime fecha, string informacionRelevante)
        {
            PersonajeGanador = personajeGanador;
            Fecha = fecha;
            InformacionRelevante = informacionRelevante;
        }
    }

    public static class HistorialJson
    {
        public static void GuardarGanador(Ganador ganador, string nombreArchivo)
        {
            List<Ganador> ganadores;
            if (File.Exists(nombreArchivo))
            {
                ganadores = LeerGanadores(nombreArchivo);
            }
            else
            {
                ganadores = new List<Ganador>();
            }

            ganadores.Add(ganador);

            var opcionesJson = new JsonSerializerOptions { WriteIndented = true };
            string jsonString = JsonSerializer.Serialize(ganadores, opcionesJson);
            File.WriteAllText(nombreArchivo, jsonString);
        }

        public static List<Ganador> LeerGanadores(string nombreArchivo)
        {
            if (!File.Exists(nombreArchivo))
            {
                Console.WriteLine("\nEl archivo no existe");
                return new List<Ganador>();
            }

            string json = File.ReadAllText(nombreArchivo);
            return JsonSerializer.Deserialize<List<Ganador>>(json);
        }

        public static bool Existe(string nombreArchivo)
        {
            return File.Exists(nombreArchivo) && new FileInfo(nombreArchivo).Length > 0;
        }
    }
}