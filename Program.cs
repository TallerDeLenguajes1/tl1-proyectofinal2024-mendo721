﻿using System;
using System.Collections.Generic;
using Personajes;
using Jugador;
using Enemigo;
using FabricaDePersonajes;
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
            //Texto.Texto.Presentacion();
            //Texto.Texto.Menu();
            Console.WriteLine("\nOpcion: ");
            int opcion;
            do
            {
                Console.WriteLine("\nOpcion: ");
                int.TryParse(Console.ReadLine(), out opcion);
                if (opcion < 1 && opcion > 3)
                {
                    Console.WriteLine("Opcion no valida");
                }
            } while (opcion < 1 || opcion > 3);

            switch (opcion)
            {
                
                case 1: 
                

                break;
            }
            string archivoPersonajes = "Personajes/personajes.json";

            List<Personaje> personajes;
            Jugador.Jugador jugador = FabricaDePersonajes.FabricaDePersonajes.SeleccionarPersonaje();

            if (PersonajesJson.PersonajesJson.Existe(archivoPersonajes))
            {
                personajes = PersonajesJson.PersonajesJson.LeerPersonajes(archivoPersonajes);
            }
            else
            {
                personajes = new List<Personaje>();
                
                

                for (int i = 0; i < 10; i++)
                {
                    personajes.Add(FabricaDePersonajes.FabricaDePersonajes.CrearEnemigoAleatorio());
                }

                PersonajesJson.PersonajesJson.GuardarPersonajes(personajes, archivoPersonajes);
            }
            
            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine("Personajes disponibles:");
            foreach (var personaje in personajes)
            {
                Console.WriteLine($"{personaje.Nombre} ({personaje.Tipo}) - {personaje.Apodo} - Edad: {personaje.Edad} años");
            }
            Console.WriteLine("-----------------------------------------------------------------------------");

            

            Combate.Combate.IniciarCombate(jugador, personajes);
        }
    }
}