using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Personajes;
using Jugador;


namespace Historial
{
    public class Ganador
    {

        public static void GuardarGanador(Jugador.Jugador ganador, string nombreArchivo)
        {
            List<Jugador.Jugador> jugadores;
            if (File.Exists(nombreArchivo))
            {
                jugadores = LeerGanadores(nombreArchivo);
            }
            else
            {
                jugadores = new List<Jugador.Jugador>();
            }

            jugadores.Add(ganador);

            var opcionesJson = new JsonSerializerOptions { WriteIndented = true };
            string jsonString = JsonSerializer.Serialize(jugadores, opcionesJson);
            File.WriteAllText(nombreArchivo, jsonString);
        }

        public static List<Jugador.Jugador> LeerGanadores(string nombreArchivo)
        {
            if (!File.Exists(nombreArchivo))// preguntar si json tiene algo
            {
                Console.WriteLine("\nEl archivo no existe");
                return new List<Jugador.Jugador>();
            }
            string? json = File.ReadAllText(nombreArchivo);
            return JsonSerializer.Deserialize<List<Jugador.Jugador>>(json);
        }

        public static bool Existe(string nombreArchivo) // preguntar si json tiene algo
        {
            return File.Exists(nombreArchivo) && new FileInfo(nombreArchivo).Length > 0;
        }
    }
}