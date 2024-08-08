using System;
using System.Collections.Generic;
using System.IO;
using Personajes;

namespace Jugador
{
    public class Jugador : Personaje
    {
        public Jugador(string tipo, string nombre, string apodo, DateTime fechaDeNacimiento, int edad, int velocidad, int destreza, int fuerza, int nivel, int armadura)
            : base(tipo, nombre, apodo, fechaDeNacimiento, edad, velocidad, destreza, fuerza, nivel, armadura)
        {
        }
        public void MejorarEstadisticas()
        {
            Console.WriteLine("Ganaste la pelea! Tienes un punto de mejora. Elige que caracteristica quiere mejorar:");
            Salud = 100;
            int puntosRestantes = 1;
            while (puntosRestantes > 0)
            {
                Console.WriteLine($"Puntos restantes: {puntosRestantes}");
                Console.WriteLine("1. Velocidad");
                Console.WriteLine("2. Destreza");
                Console.WriteLine("3. Fuerza");
                Console.WriteLine("4. Nivel");
                Console.WriteLine("5. Armadura");
                Console.WriteLine("Eleccion: ");

                if (int.TryParse(Console.ReadLine(), out int eleccion) && eleccion >= 1 && eleccion <= 5)
                {
                    switch (eleccion)
                    {
                        case 1:
                            Velocidad++;
                            break;
                        case 2:
                            Destreza++;
                            break;
                        case 3:
                            Fuerza++;
                            break;
                        case 4:
                            Nivel++;
                            break;
                        case 5:
                            Armadura++;
                            break;
                    }
                    puntosRestantes--;
                }
                else
                {
                    Console.WriteLine("Elección no valida. Intenta de nuevo.");
                }
            }
            Console.WriteLine("¡Estadisticas mejoradas!");
        }
    }
}
