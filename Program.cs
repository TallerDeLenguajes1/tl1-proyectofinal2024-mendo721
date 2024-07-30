using System;
using System.Collections.Generic;
using Personajes;
using PersonajesJson;
using Historial;

namespace JuegoRPG
{
    class Program
    {
        static void Main()
        {
            string archivoPersonajes = "personajes.json";
            List<Personaje> personajes;

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

            Console.WriteLine("Personajes cargados:");
            foreach (var personaje in personajes)
            {
                Console.WriteLine($"Tipo: {personaje.Tipo}, Nombre: {personaje.Nombre}, Apodo: {personaje.Apodo}, Fecha de Nacimiento: {personaje.FechaDeNacimiento.ToShortDateString()}, Edad: {personaje.Edad}, Velocidad: {personaje.Velocidad}, Destreza: {personaje.Destreza}, Fuerza: {personaje.Fuerza}, Nivel: {personaje.Nivel}, Armadura: {personaje.Armadura}, Salud: {personaje.Salud}");
            }
        }
    }
}