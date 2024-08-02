using System;
using System.Collections.Generic;
using System.IO;

namespace Personajes
{
    public class Personaje
    {
        //DATOS
        public string Tipo { get; set; }
        public string Nombre { get; set; }
        public string Apodo { get; set; }
        public DateTime FechaDeNacimiento { get; set; }
        public int Edad { get; set; }

        //CARACTERISTICAS
        public int Velocidad { get; set; }
        public int Destreza { get; set; }
        public int Fuerza { get; set; }
        public int Nivel { get; set; }
        public int Armadura { get; set; }
        public int Salud { get; set; } = 100;

        public Personaje(string tipo, string nombre, string apodo, DateTime fechaDeNacimiento, int edad, int velocidad, int destreza, int fuerza, int nivel, int armadura)
        {
            Tipo = tipo;
            Nombre = nombre;
            Apodo = apodo;
            FechaDeNacimiento = fechaDeNacimiento;
            Edad = edad;
            Velocidad = velocidad;
            Destreza = destreza;
            Fuerza = fuerza;
            Nivel = nivel;
            Armadura = armadura;
        }
    }

    public class Jugador : Personaje
    {
        public Jugador(string tipo, string nombre, string apodo, DateTime fechaDeNacimiento, int edad, int velocidad, int destreza, int fuerza, int nivel, int armadura)
            : base(tipo, nombre, apodo, fechaDeNacimiento, edad, velocidad, destreza, fuerza, nivel, armadura)
        {
        }
    }

    public class Enemigo : Personaje
    {
        public Enemigo(string tipo, string nombre, string apodo, DateTime fechaDeNacimiento, int edad, int velocidad, int destreza, int fuerza, int nivel, int armadura)
            : base(tipo, nombre, apodo, fechaDeNacimiento, edad, velocidad, destreza, fuerza, nivel, armadura)
        {
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

    public class FabricaDePersonajes
    {
        private static Random random = new Random();
        private static List<Personaje> personajesPredefinidos = new List<Personaje>
        {
            new Jugador("Guerrero", "Arthur", "El Bravo", new DateTime(2000, 1, 1), 24, 7, 4, 9, 5, 8),
            new Jugador("Mago", "Merlin", "El Astuto", new DateTime(1950, 5, 10), 74, 5, 5, 3, 7, 6),
            new Jugador("Arquero", "Legolas", "El Preciso", new DateTime(1985, 11, 20), 38, 9, 3, 7, 4, 7)
        };

        public static List<Personaje> ObtenerPersonajes()
        {
            return personajesPredefinidos;
        }

        private static List<EnemigoPredefinido> enemigosPredefinidos = new List<EnemigoPredefinido>
        {
            new EnemigoPredefinido("Granadero", "Ramon", "El Malo"),
            new EnemigoPredefinido("Artillero", "Julio", "El Rudo"),
            new EnemigoPredefinido("Comandante", "Carlos", "El Debil"),
            new EnemigoPredefinido("Razo", "Miguel", "El Debil"),
            new EnemigoPredefinido("Razo", "David", "El Debil"),
            new EnemigoPredefinido("Razo", "Angel", "El Debil"),
            new EnemigoPredefinido("Razo", "Ramiro", "El Debil"),
            new EnemigoPredefinido("Razo", "Tobias", "El Debil"),
            new EnemigoPredefinido("Razo", "Antonio", "El Debil"),
            new EnemigoPredefinido("Razo", "Michael", "El Debil"),
            new EnemigoPredefinido("Razo", "arito", "El Debil"),
            new EnemigoPredefinido("Razo", "Lauty", "El Debil"),
        };

        //Se utiliza para no repetir los nombres de los personajes HashSet se utiliza para que no se repita elementos en la lista
        private static HashSet<string> nombresUtilizados = new HashSet<string>();

        public static Enemigo CrearEnemigoAleatorio()
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

            Enemigo enemigo = new Enemigo(enemigoPredefinido.Tipo, enemigoPredefinido.Nombre, enemigoPredefinido.Apodo, fechaDeNacimiento, edad, velocidad, destreza, fuerza, nivel, armadura);

            // Registrar el nombre como utilizado para que no se repita
            nombresUtilizados.Add(enemigoPredefinido.Nombre);

            return enemigo;
        }

        private static EnemigoPredefinido SeleccionarEnemigoPredefinido()
        {
            List<EnemigoPredefinido> enemigosDisponibles = enemigosPredefinidos.FindAll(enemigo => !nombresUtilizados.Contains(enemigo.Nombre));
            if (enemigosDisponibles.Count == 0)
            {
                throw new InvalidOperationException("No hay más enemigos disponibles.");
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

        public static Jugador SeleccionarPersonaje()
        {
            Console.WriteLine("Selecciona tu personaje:");
            for (int i = 0; i < personajesPredefinidos.Count; i++)
            {
                var personaje = personajesPredefinidos[i];
                Console.WriteLine($"{i + 1}. {personaje.Nombre} ({personaje.Tipo}) - {personaje.Apodo}");
            }

            int seleccion;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out seleccion) && seleccion >= 1 && seleccion <= personajesPredefinidos.Count)
                {
                    break;
                }
                Console.WriteLine("Seleccion no válida, intenta de nuevo.");
            }

            Personaje seleccionado = personajesPredefinidos[seleccion - 1];
            personajesPredefinidos.Remove(seleccionado);

            return new Jugador(seleccionado.Tipo, seleccionado.Nombre, seleccionado.Apodo, seleccionado.FechaDeNacimiento,seleccionado.Edad, seleccionado.Velocidad, seleccionado.Destreza, seleccionado.Fuerza, seleccionado.Nivel, seleccionado.Armadura);
        }
    }
}
