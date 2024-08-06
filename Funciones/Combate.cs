using System;
using System.Collections.Generic;
using Jugador;
using Enemigo;
using FabricaDePersonajes;
using Personajes;

namespace Combate
{
    public class Combate
    {
        public static void IniciarCombate(Jugador.Jugador jugador, List<Personaje> personajes)
        {
            if (personajes.Count < 2)
            {
                Console.WriteLine("\nNo hay suficientes personajes para empezar un combate");
                return;
            }

            Random random = new Random();

            while (personajes.Count > 1)
            {
                int indice = random.Next(personajes.Count);
                Personaje enemigo = personajes[indice];

                Console.WriteLine($"\n---Salud de Jugador: {jugador.Salud}---");
                Console.WriteLine("-----------------------------------------------------------------------------");
                Console.WriteLine($"\nCombate entre {jugador.Nombre} y {enemigo.Nombre}");

                Personaje ganador = EjecutarCombate(jugador, enemigo);
                Console.WriteLine("-----------------------------------------------------------------------------");

                personajes.Remove(jugador == ganador ? enemigo : jugador);

                if (ganador != jugador)
                {
                    Console.WriteLine($"\n---El jugador {jugador.Nombre} ha sido derrotado. Fin del juego.---");
                    return;
                }
                else
                {
                    jugador.MejorarEstadisticas();
                }
            }

            Console.WriteLine($"El ganador final es: {jugador.Nombre}");
        }

        private static Personaje EjecutarCombate(Personaje jugador, Personaje enemigo)
        {
            bool combateEnCurso = true;
            int ganador = 0;

            while (combateEnCurso)
            {
                Console.WriteLine($"\nTurno de {jugador.Nombre}");
                enemigo.Salud -= CalcularDanio(jugador, enemigo);
                Console.WriteLine($"\n{jugador.Nombre} ataca a {enemigo.Nombre}, salud de {enemigo.Nombre}: {enemigo.Salud}");

                if (enemigo.Salud <= 0)
                {
                    combateEnCurso = false;
                    ganador = 1;
                    Console.WriteLine($"{enemigo.Nombre} ha sido derrotado.");
                    continue;
                }

                Console.WriteLine($"\nTurno de {enemigo.Nombre}");
                jugador.Salud -= CalcularDanio(enemigo, jugador);
                Console.WriteLine($"\n{enemigo.Nombre} ataca a {jugador.Nombre}, salud de {jugador.Nombre}: {jugador.Salud}");

                if (jugador.Salud <= 0)
                {
                    combateEnCurso = false;
                    ganador = 2;
                    Console.WriteLine($"{jugador.Nombre} ha sido derrotado.");
                }
            }

            return ganador == 1 ? jugador : enemigo;
        }

        private static int CalcularDanio(Personaje atacante, Personaje defensor)
        {
            int ataque = atacante.Destreza * atacante.Fuerza * atacante.Nivel;
            int defensa = defensor.Armadura * defensor.Velocidad;
            Random random = new Random();
            int efectividad = random.Next(1, 101); // Cambiado a 101 para incluir 100 en el rango

            int danio = ((ataque * efectividad) - defensa) / 500;
            int danioFinal = Math.Max(danio * 2, 10); // Asegurarse de que el daño no sea menor que 10

            return danioFinal;
        }        
    }
}