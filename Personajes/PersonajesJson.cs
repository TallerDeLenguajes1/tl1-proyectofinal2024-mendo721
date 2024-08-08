using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Personajes;

namespace PersonajesJson
{
    public class PersonajesJson
    {
        //Metodo para guardar los personajes en formato Json
        public static void GuardarPersonajes(List<Personaje> personajes, string NombreArchivo)
        {
            //agrego la opcion para generar un formato Json mas legible
            var OpcionesJson = new JsonSerializerOptions {WriteIndented = true};
            //serializo y guardo con las configuraciones del formato opcionesJson
            string Json =  JsonSerializer.Serialize(personajes, OpcionesJson);
            //Se guarda en el archivo el Json
            File.WriteAllText(NombreArchivo, Json);
        }

        //Metodo para leer los personajes en Json en el archivo
        public static List<Personaje> LeerPersonajes(string NombreArchivo)
        {
            if (!File.Exists(NombreArchivo)) // preguntar si json tiene algo
            {
                Console.WriteLine("\nEl archivo no existe");
                return new List<Personaje>();
            }
            string Json = File.ReadAllText(NombreArchivo);
            return JsonSerializer.Deserialize<List<Personaje>>(Json);
        }

        public static bool Existe(string NombreArchivo)
        {
            if (File.Exists(NombreArchivo)) // preguntar si json tiene algo
            {
                string Json = File.ReadAllText(NombreArchivo);
                return !string.IsNullOrEmpty(Json); //devuelve falso en caso que el parametro sea un string nulo
            }
            return false;
        }
    }
}