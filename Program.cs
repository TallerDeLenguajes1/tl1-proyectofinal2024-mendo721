using System;
using System.Collections.Generic;
using Personajes;
using PersonajesJson;
using Historial;
using Combate;
using Texto;

namespace JuegoRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Texto.Texto.Presentacion();
            string archivoPersonajes = "personajes.json";

            List<Personaje> personajes;
            Jugador jugador = FabricaDePersonajes.SeleccionarPersonaje();

            if (PersonajesJson.PersonajesJson.Existe(archivoPersonajes))
            {
                personajes = PersonajesJson.PersonajesJson.LeerPersonajes(archivoPersonajes);
            }
            else
            {
                personajes = new List<Personaje>();
                
                

                for (int i = 0; i < 10; i++)
                {
                    personajes.Add(FabricaDePersonajes.CrearEnemigoAleatorio());
                }

                PersonajesJson.PersonajesJson.GuardarPersonajes(personajes, archivoPersonajes);
            }
            personajes.Add(jugador);
            Console.WriteLine("Personajes disponibles:");
            foreach (var personaje in personajes)
            {
                Console.WriteLine($"{personaje.Nombre} ({personaje.Tipo}) - {personaje.Apodo} - Edad: {personaje.Edad} años");
            }

            

            Combate.Combate.IniciarCombate(jugador, personajes);
        }
    }
}