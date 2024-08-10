using System;
using System.Collections.Generic;
using Personajes;
using Jugador;
using Enemigo;
using FabricaDePersonajes;
using PersonajesJson;
using Historial;
using Combate;
using Texto;
using System.Threading.Tasks;
using Api;

namespace JuegoRPG
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Texto.Texto.Presentacion();
            Texto.Texto.Menu();
            await Api();
            string ClimasDisponibles = "Funciones/climas.json";
            List<InformacionClimatica> climasCargados;
            climasCargados = ServicioClima.LeerClima(ClimasDisponibles);
            InformacionClimatica clima = climasCargados[climasCargados.Count-1];
            
            int opcion;
            do
            {
                Console.WriteLine("\nOpcion: ");
                int.TryParse(Console.ReadLine(), out opcion);
                if (opcion < 1 || opcion > 4)
                {
                    Console.WriteLine("Opcion no valida");
                }
            } while (opcion < 1 || opcion > 4);

            switch (opcion)
            {

                case 1:
                    Texto.Texto.Mision();
                    Console.WriteLine($"\nPreparate soldado la zona esta fuertemente vigilada y la temperatura ronda los {clima.Temperatura}");
                    string archivoPersonajes = "Personajes/personajes.json";

                    List<Personaje> personajes;
                    Jugador.Jugador jugador = FabricaDePersonajes.FabricaDePersonajes.SeleccionarPersonaje();
                    personajes = new List<Personaje>();
                    if (clima.Temperatura>20.0)
                    {
                        Console.WriteLine("Soldado lamentablemente las temperaturas son muy altas (pierdes un puntos de velocidad)");
                        jugador.Velocidad--;
                    }
                    if (clima.Temperatura<5.0)
                    {
                        Console.WriteLine("Soldado lamentablemente las temperaturas son muy bajas (pierdes un puntos de armadura)");
                        jugador.Armadura--;
                    }


                    for (int i = 0; i < 10; i++)
                    {
                        personajes.Add(FabricaDePersonajes.FabricaDePersonajes.CrearEnemigoAleatorio());
                    }

                    PersonajesJson.PersonajesJson.GuardarPersonajes(personajes, archivoPersonajes);

                    Console.WriteLine("-----------------------------------------------------------------------------");
                    Console.WriteLine("Personajes disponibles:");
                    foreach (var personaje in personajes)
                    {
                        Console.WriteLine($"{personaje.Nombre} ({personaje.Tipo}) - {personaje.Apodo}");
                    }
                    Console.WriteLine("-----------------------------------------------------------------------------");
                    Combate.Combate.IniciarCombate(jugador, personajes);

                    break;

                case 2:
                    string archivoPersonajesCargados = "Personajes/personajes.json";
                    List<Personaje> personajesCargados;
                    Jugador.Jugador jugador1 = FabricaDePersonajes.FabricaDePersonajes.SeleccionarPersonaje();
                    if (clima.Temperatura>20.0)
                    {
                        Console.WriteLine("Soldado lamentablemente las temperaturas son muy altas (pierdes un puntos de velocidad)");
                        jugador1.Velocidad--;
                    }
                    if (clima.Temperatura<5.0)
                    {
                        Console.WriteLine("Soldado lamentablemente las temperaturas son muy bajas (pierdes un puntos de armadura)");
                        jugador1.Armadura--;
                    }

                    if (PersonajesJson.PersonajesJson.Existe(archivoPersonajesCargados))
                    {
                        personajesCargados = PersonajesJson.PersonajesJson.LeerPersonajes(archivoPersonajesCargados);
                        if (personajesCargados.Count >= 1)
                        {
                            Console.WriteLine("\nPartida cargada");
                        }
                        else
                        {
                            Console.WriteLine("\nNo Existe partida cargada");

                            personajesCargados = new List<Personaje>();



                            for (int i = 0; i < 10; i++)
                            {
                                personajesCargados.Add(FabricaDePersonajes.FabricaDePersonajes.CrearEnemigoAleatorio());
                            }

                            PersonajesJson.PersonajesJson.GuardarPersonajes(personajesCargados, archivoPersonajesCargados);
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nNo Existe partida cargada");

                        personajesCargados = new List<Personaje>();



                        for (int i = 0; i < 10; i++)
                        {
                            personajesCargados.Add(FabricaDePersonajes.FabricaDePersonajes.CrearEnemigoAleatorio());
                        }

                        PersonajesJson.PersonajesJson.GuardarPersonajes(personajesCargados, archivoPersonajesCargados);
                    }
                    Console.WriteLine("-----------------------------------------------------------------------------");
                    Console.WriteLine("Personajes disponibles:");
                    foreach (var personaje in personajesCargados)
                    {
                        Console.WriteLine($"{personaje.Nombre} ({personaje.Tipo}) - {personaje.Apodo}");
                    }
                    Console.WriteLine("-----------------------------------------------------------------------------");



                    Combate.Combate.IniciarCombate(jugador1, personajesCargados);
                    break;

                case 3:
                    string historial = "Historial/ganadores.json";
                    List<Jugador.Jugador> Ganadores;
                    if (Historial.Ganador.Existe(historial))
                    {
                        Ganadores = Historial.Ganador.LeerGanadores(historial);
                        Console.WriteLine("-----------------------------------------------------------------------------");
                        Console.WriteLine("Lista de Ganadores:");
                        foreach (var ganadores in Ganadores)
                        {
                            Console.WriteLine($"{ganadores.Nombre} ({ganadores.Tipo}) - {ganadores.Apodo}");
                        }
                        Console.WriteLine("-----------------------------------------------------------------------------");
                    }


                break;
            }
        }

        public static async Task Api()
        {
            string claveApi = "7793c47c845c2d65bf19a1094283eef4";

            ServicioClima servicioClima = new ServicioClima(claveApi);
            string ClimasDisponibles = "Funciones/climas.json";

            try
            {
                InformacionClimatica clima = await servicioClima.ObtenerClimaAsync("Paris", "FR");
                ServicioClima.GuardarClima(clima, ClimasDisponibles);
                Console.WriteLine($"Ciudad: {clima.Ciudad}");
                Console.WriteLine($"Temperatura: {clima.Temperatura}°C");
                Console.WriteLine($"Descripción: {clima.Descripcion}");
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}