using System;
using System.Collections.Generic;
using System.IO;
using Personajes;

namespace Enemigo
{
    public class Enemigo : Personaje
    {
        public Enemigo(string tipo, string nombre, string apodo, DateTime fechaDeNacimiento, int edad, int velocidad, int destreza, int fuerza, int nivel, int armadura)
            : base(tipo, nombre, apodo, fechaDeNacimiento, edad, velocidad, destreza, fuerza, nivel, armadura)
        {
        }
    }
    
}