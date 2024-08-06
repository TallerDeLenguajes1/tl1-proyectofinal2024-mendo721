using System;
using System.Collections.Generic;
using System.IO;
using Jugador;
using Enemigo;
using Personajes;

namespace FabricaDePersonajes
{
    public class FabricaDePersonajes
    {
        private static Random random = new Random();
        private static List<Personaje> personajesPredefinidos = new List<Personaje>
        {
            new Jugador.Jugador("Teniente", "Aldo Raine", "El Apache", new DateTime(2000, 1, 1), 24, 7, 4, 9, 5, 8),
            new Jugador.Jugador("Sargento ", "Donnie Donowitz", "Oso Judío", new DateTime(1950, 5, 10), 74, 5, 5, 3, 7, 6),
            new Jugador.Jugador("Sargento", "Hugo Stiglitz", "El Psicopata", new DateTime(1985, 11, 20), 38, 9, 3, 7, 4, 7)
        };

        public static List<Personaje> ObtenerPersonajes()
        {
            return personajesPredefinidos;
        }

        private static List<EnemigoPredefinido> enemigosPredefinidos = new List<EnemigoPredefinido>
        {
            new EnemigoPredefinido("Coronel", "Hans Landa", "El Cazajudíos"),
            new EnemigoPredefinido("Cabo", "Fredrick Zoller", "El Héroe de la Nación"),
            new EnemigoPredefinido("Ministro", "Joseph Goebbels", "El Enano Venenoso"),
            new EnemigoPredefinido("Mayor", "Dieter Hellstrom", "La Bestia"),
            new EnemigoPredefinido("Führer", "Adolf Hitler", "El Líder"),
            new EnemigoPredefinido("Cabo ", "Hans Müller", "El Rápido"),
            new EnemigoPredefinido("Cabo", "Karl Schmidt", "El Silencioso"),
            new EnemigoPredefinido("Cabo", "Otto Bauer", "El Intrépido"),
            new EnemigoPredefinido("Cabo", "Wilhelm Richter", "El Guardián"),
            new EnemigoPredefinido("Cabo", "Ernst Weber", "El Implacable"),
        };

        //Se utiliza para no repetir los nombres de los personajes HashSet se utiliza para que no se repita elementos en la lista
        private static HashSet<string> nombresUtilizados = new HashSet<string>();

        public static Enemigo.Enemigo CrearEnemigoAleatorio()
        {
            EnemigoPredefinido enemigoPredefinido = SeleccionarEnemigoPredefinido();

            // Le adjudico atributos aleatorios a los enemigos
            DateTime fechaDeNacimiento = GenerarFechaDeNacimientoAleatoria();
            int velocidad = random.Next(1, 11);
            int destreza = random.Next(1, 6);
            int fuerza = random.Next(1, 11);
            int nivel = random.Next(1, 11);
            int armadura = random.Next(1, 11);
            int edad = CalcularEdad(fechaDeNacimiento);

            Enemigo.Enemigo enemigo = new Enemigo.Enemigo(enemigoPredefinido.Tipo, enemigoPredefinido.Nombre, enemigoPredefinido.Apodo, fechaDeNacimiento, edad, velocidad, destreza, fuerza, nivel, armadura);

            // Registrar el nombre como utilizado para que no se repita
            nombresUtilizados.Add(enemigoPredefinido.Nombre);

            return enemigo;
        }

        private static EnemigoPredefinido SeleccionarEnemigoPredefinido()
        {
            List<EnemigoPredefinido> enemigosDisponibles = enemigosPredefinidos.FindAll(enemigo => !nombresUtilizados.Contains(enemigo.Nombre));
            if (enemigosDisponibles.Count == 0)
            {
                throw new InvalidOperationException("No hay mas enemigos disponibles.");
            }
            return enemigosDisponibles[random.Next(enemigosDisponibles.Count)];
        }

        private static DateTime GenerarFechaDeNacimientoAleatoria()
        {
            int year = random.Next(DateTime.Now.Year - 300, DateTime.Now.Year - 1);
            int month = random.Next(1, 13);
            int day = random.Next(1, DateTime.DaysInMonth(year, month) + 1);
            return new DateTime(year, month, day);
        }

        private static int CalcularEdad(DateTime fechaDeNacimiento)
        {
            var hoy = DateTime.Today;
            int edad = hoy.Year - fechaDeNacimiento.Year;
            if (fechaDeNacimiento.Date > hoy.AddYears(-edad)) edad--;
            return edad;
        }

        public static Jugador.Jugador SeleccionarPersonaje()
        {
            Console.WriteLine("\nSelecciona tu personaje:");
            for (int i = 0; i < personajesPredefinidos.Count; i++)
            {
                var personaje = personajesPredefinidos[i];
                Console.WriteLine($"{i + 1}. {personaje.Nombre} ({personaje.Tipo}) - {personaje.Apodo}");
            }
            Console.WriteLine("\nEleccion:");
            int seleccion;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out seleccion) && seleccion >= 1 && seleccion <= personajesPredefinidos.Count)
                {
                    break;
                }
                Console.WriteLine("Eleccion no valida, intenta de nuevo.");
            }

            Personaje seleccionado = personajesPredefinidos[seleccion - 1];
            personajesPredefinidos.Remove(seleccionado);

            return new Jugador.Jugador(seleccionado.Tipo, seleccionado.Nombre, seleccionado.Apodo, seleccionado.FechaDeNacimiento,seleccionado.Edad, seleccionado.Velocidad, seleccionado.Destreza, seleccionado.Fuerza, seleccionado.Nivel, seleccionado.Armadura);
        }
    }
    // Clase para definir enemigos predefinidos
    public class EnemigoPredefinido
    {
        public string Tipo { get; set; }
        public string Nombre { get; set; }
        public string Apodo { get; set; }

        public EnemigoPredefinido(string tipo, string nombre, string apodo)
        {
            Tipo = tipo;
            Nombre = nombre;
            Apodo = apodo;
        }
    }
}