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

        public Personaje(string tipo, string nombre, string apodo, DateTime fechaDeNacimiento, int velocidad, int destreza, int fuerza, int nivel, int armadura)
        {
            Tipo = tipo;
            Nombre = nombre;
            Apodo = apodo;
            FechaDeNacimiento = fechaDeNacimiento;
            Velocidad = velocidad;
            Destreza = destreza;
            Fuerza = fuerza;
            Nivel = nivel;
            Armadura = armadura;
        }
    }

    public class Jugador : Personaje
    {
        public Jugador(string tipo, string nombre, string apodo, DateTime fechaDeNacimiento, int velocidad, int destreza, int fuerza, int nivel, int armadura)
            : base(tipo, nombre, apodo, fechaDeNacimiento, velocidad, destreza, fuerza, nivel, armadura)
        {
        }
    }

    public class Enemigo : Personaje
    {
        public Enemigo(string tipo, string nombre, string apodo, DateTime fechaDeNacimiento, int velocidad, int destreza, int fuerza, int nivel, int armadura)
            : base(tipo, nombre, apodo, fechaDeNacimiento, velocidad, destreza, fuerza, nivel, armadura)
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
            new Jugador("Guerrero", "Arthur", "El Bravo", new DateTime(2000, 1, 1), 7, 4, 9, 5, 8),
            new Jugador("Mago", "Merlin", "El Astuto", new DateTime(1950, 5, 10), 5, 5, 3, 7, 6),
            new Jugador("Arquero", "Legolas", "El Preciso", new DateTime(1985, 11, 20), 9, 3, 7, 4, 7)
        };

        public static List<Personaje> ObtenerPersonajes()
        {
            return personajesPredefinidos;
        }

        private static List<EnemigoPredefinido> enemigosPredefinidos = new List<EnemigoPredefinido>
        {
            new EnemigoPredefinido("Granadero", "Ramon", "El Malo"),
            new EnemigoPredefinido("Artillero", "Julio", "El Rudo"),
            new EnemigoPredefinido("Comandante", "Carlos", "El Debil")
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

            Enemigo enemigo = new Enemigo(enemigoPredefinido.Tipo, enemigoPredefinido.Nombre, enemigoPredefinido.Apodo, fechaDeNacimiento, velocidad, destreza, fuerza, nivel, armadura);

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
    }
}
