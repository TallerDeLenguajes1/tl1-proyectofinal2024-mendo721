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
        public int Salud { get; set; };

    }
}