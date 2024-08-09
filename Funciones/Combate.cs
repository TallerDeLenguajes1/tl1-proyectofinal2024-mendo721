using System;
using System.Collections.Generic;
using Jugador;
using Enemigo;
using FabricaDePersonajes;
using System.Threading;
using Historial;
using PersonajesJson;
using Personajes;

namespace Combate
{
    public class Combate
    {
        public static void IniciarCombate(Jugador.Jugador jugador, List<Personaje> personajes)
        {
            string archivoGanadores = "Historial/ganadores.json";
            string archivoPersonajes = "Personajes/personajes.json";

            if (personajes.Count < 1)
            {
                Console.WriteLine("\nNo hay suficientes personajes para empezar un combate");
                return;
            }

            Random random = new Random();

            while (personajes.Count >= 1)
            {
                int indice = random.Next(personajes.Count);
                Personaje enemigo = personajes[indice];
                
                Console.WriteLine("-----------------------------------------------------------------------------");
                Console.WriteLine($"\nCombate entre {jugador.Nombre} y {enemigo.Nombre}");

                Personaje ganador = EjecutarCombate(jugador, enemigo);
                Console.WriteLine("-----------------------------------------------------------------------------");

                personajes.Remove(jugador == ganador ? enemigo : jugador);

                if (ganador != jugador)
                {
                    Console.WriteLine($"\n---El jugador {jugador.Nombre} ha sido derrotado. Fin del juego.---");
                    Thread.Sleep(1000);
                    return;
                }
                else
                {
                    jugador.MejorarEstadisticas();
                }
                Console.Clear();
                PersonajesJson.PersonajesJson.GuardarPersonajes(personajes, archivoPersonajes);
            }

            Texto.Texto.Ganaste();
            Historial.Ganador.GuardarGanador(jugador, archivoGanadores);
        }

        private static Personaje EjecutarCombate(Personaje jugador, Personaje enemigo)
        {
            bool combateEnCurso = true;
            int ganador = 0;

            while (combateEnCurso)
            {
                jugador.MostrarInformacion();
                enemigo.MostrarInformacion();
                Console.WriteLine($"\nTurno de {jugador.Nombre}");
                
                int defender = 0;
                int rendirse = 0;
                
                Console.WriteLine("1- Atacar");
                Console.WriteLine("2- Defender");
                Console.WriteLine("3- Rendirse");
                int accion;
                do
                {
                    Console.WriteLine("\nAccion: ");
                    int.TryParse(Console.ReadLine(), out accion);
                    if (accion < 1 || accion > 3)
                    {
                        Console.WriteLine("Opcion no valida");
                    }
                } while (accion < 1 || accion > 3);
                
                Thread.Sleep(1000);
                Console.Clear();
                switch (accion)
                {
                    case 1:
                    enemigo.Salud -= CalcularDanio(jugador, enemigo,defender);
                    Console.WriteLine($"{jugador.Nombre} ataca a {enemigo.Nombre}");
                    break;
                    case 2:
                    defender = 10;
                    Console.WriteLine($"{jugador.Nombre} se defiende al ataque de {enemigo.Nombre}");
                    break;
                    case 3:
                    rendirse = 1;
                    break;
                }
                
                if (rendirse == 1)
                {
                    combateEnCurso = false;
                    ganador = 2;
                    Texto.Texto.MostrarMensajeDerrota();
                    continue;
                }
                if (enemigo.Salud <= 0)
                {
                    combateEnCurso = false;
                    ganador = 1;
                    Thread.Sleep(5000);
                    Console.Clear();
                    Console.WriteLine($"{enemigo.Nombre} ha sido derrotado.");
                    continue;
                }
                Console.WriteLine($"\nTurno de {enemigo.Nombre}");
                jugador.Salud -= CalcularDanio(enemigo, jugador,defender);
                Console.WriteLine($"{enemigo.Nombre} ataca a {jugador.Nombre}");

                if (jugador.Salud <= 0)
                {
                    combateEnCurso = false;
                    ganador = 2;
                    Thread.Sleep(5000);
                    Console.Clear();
                    Console.WriteLine($"{jugador.Nombre} ha sido derrotado.");
                    Texto.Texto.Perdiste();
                    continue;
                }
            }

            return ganador == 1 ? jugador : enemigo;
        }

        private static int CalcularDanio(Personaje atacante, Personaje defensor, int defender)
        {
            int ataque = atacante.Destreza * atacante.Fuerza * atacante.Nivel;
            int defensa = defensor.Armadura+defender * defensor.Velocidad;
            Random random = new Random();
            int efectividad = random.Next(1, 101); // Cambiado a 101 para incluir 100 en el rango

            int danio = ((ataque * efectividad) - defensa) / 500;
            int danioFinal = Math.Max(danio * 2, 10); // Asegurarse de que el daño no sea menor que 10

            return danioFinal;
        }        
    }
}