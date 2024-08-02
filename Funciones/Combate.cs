using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Historial;
using Personajes;

namespace Combate
{
    public class Combate
    {
        public static void Combatir(Jugador jugador, List<Personaje> personajes){
            if (personajes.Count < 1)
            {
                Console.WriteLine("\nNo hay suficientes personajes para empezar un combate");
                return;
            }

            Random random = new Random();

            while (personajes.Count > 1)
            {
                int indice = random.Next(personajes.Count);
                Personaje enemigo = personajes[indice];

                Console.WriteLine($"\nCombate entre {jugador.Nombre} y {enemigo.Nombre}");

                Personaje ganador = EjecutarCombate(jugador, enemigo);

                personajes.Remove(jugador == ganador ? enemigo : jugador);

                if (ganador != jugador)
                {
                    Console.WriteLine($"El jugador {jugador.Nombre} ha sido derrotado. Fin del juego.");
                    return;
                }
            }

            Console.WriteLine($"El ganador final es: {jugador.Nombre}");

        }

        private static Personaje EjecutarCombate(Personaje jugador, Personaje enemigo){
            bool combat = true;
            int ganador = 0;
            //Desarrollo de combate
            while (combat)
            {
                Console.WriteLine($"\nTurno del Jugador{jugador.Nombre}");
                enemigo.Salud -= CalcularDanio(jugador, enemigo);
                if (enemigo.Salud <= 0)
                {
                    combat = false;
                    ganador = 1;
                }

                Console.WriteLine($"\nTurno del Jugador{enemigo.Nombre}");
                jugador.Salud -= CalcularDanio(enemigo, jugador);
                if (jugador.Salud <= 0)
                {
                    combat = false;
                    ganador = 2;
                }

            }

            if (ganador == 1)
            {
                return jugador;
            }
            if (ganador == 2)
            {
                return enemigo;
            }
            //por defecto;
            return jugador;
        }
        private static int CalcularDanio(Personaje atacante, Personaje defiende){
            //Calculo las estadisticas de combate de los peleadores
            int ataque = atacante.Destreza * atacante.Fuerza * atacante.Nivel;
            int defensa = defiende.Armadura * defiende.Velocidad;
            Random random = new Random();
            int efectividad = random.Next(1, 100);
            //Calculo de danio
            int danio = ((ataque * efectividad) - defensa) / 500;
            int danioFinal = danio*2;
            // Asegurarse de que el daño no sea menor que 10
            return danioFinal;

        }
    }
}