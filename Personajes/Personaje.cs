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

         public void MostrarInformacion()
        {
            string estadisticas = $@"
            ╔════════════════════════════════════════════════════════════════╗
            ║                                                                ║
            ║                      Estadísticas del Personaje                ║
            ║                                                                ║
            ╠════════════════════════════════════════════════════════════════╣
            ║ Nombre     : {Nombre,-50}║
            ║ Apodo      : {Apodo,-50}║
            ║ Salud      : {Salud,-50}║
            ║ Destreza   : {Destreza,-50}║
            ║ Fuerza     : {Fuerza,-50}║
            ║ Nivel      : {Nivel,-50}║
            ║ Armadura   : {Armadura,-50}║
            ║ Velocidad  : {Velocidad,-50}║
            ╚════════════════════════════════════════════════════════════════╝
            ";
            Console.WriteLine(estadisticas);
        }
    }
}
