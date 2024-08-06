using System;
using System.Threading;

namespace Texto
{
    public class Texto
    {
        public static void Escribir(int vel, string texto)
        {
            for (int i = 0; i < texto.Length; i++)
            {
                Console.Write(texto[i]);
                Thread.Sleep(vel);
            }
        }

        public static void Presentacion()
        {
            Console.WriteLine(@"
 ▄▄▄▄    ▄▄▄        ██████ ▄▄▄█████▓ ▄▄▄       ██▀███  ▓█████▄  ▒█████    ██████      ██████  ██▓ ███▄    █      ▄████  ██▓     ▒█████   ██▀███   ██▓ ▄▄▄      
▓█████▄ ▒████▄    ▒██    ▒ ▓  ██▒ ▓▒▒████▄    ▓██ ▒ ██▒▒██▀ ██▌▒██▒  ██▒▒██    ▒    ▒██    ▒ ▓██▒ ██ ▀█   █     ██▒ ▀█▒▓██▒    ▒██▒  ██▒▓██ ▒ ██▒▓██▒▒████▄    
▒██▒ ▄██▒██  ▀█▄  ░ ▓██▄   ▒ ▓██░ ▒░▒██  ▀█▄  ▓██ ░▄█ ▒░██   █▌▒██░  ██▒░ ▓██▄      ░ ▓██▄   ▒██▒▓██  ▀█ ██▒   ▒██░▄▄▄░▒██░    ▒██░  ██▒▓██ ░▄█ ▒▒██▒▒██  ▀█▄  
▒██░█▀  ░██▄▄▄▄██   ▒   ██▒░ ▓██▓ ░ ░██▄▄▄▄██ ▒██▀▀█▄  ░▓█▄   ▌▒██   ██░  ▒   ██▒     ▒   ██▒░██░▓██▒  ▐▌██▒   ░▓█  ██▓▒██░    ▒██   ██░▒██▀▀█▄  ░██░░██▄▄▄▄██ 
░▓█  ▀█▓ ▓█   ▓██▒▒██████▒▒  ▒██▒ ░  ▓█   ▓██▒░██▓ ▒██▒░▒████▓ ░ ████▓▒░▒██████▒▒   ▒██████▒▒░██░▒██░   ▓██░   ░▒▓███▀▒░██████▒░ ████▓▒░░██▓ ▒██▒░██░ ▓█   ▓██▒
░▒▓███▀▒ ▒▒   ▓▒█░▒ ▒▓▒ ▒ ░  ▒ ░░    ▒▒   ▓▒█░░ ▒▓ ░▒▓░ ▒▒▓  ▒ ░ ▒░▒░▒░ ▒ ▒▓▒ ▒ ░   ▒ ▒▓▒ ▒ ░░▓  ░ ▒░   ▒ ▒     ░▒   ▒ ░ ▒░▓  ░░ ▒░▒░▒░ ░ ▒▓ ░▒▓░░▓   ▒▒   ▓▒█░
▒░▒   ░   ▒  
 ▒▒ ░░ ░▒  ░ ░    ░      ▒   ▒▒ ░  ░▒ ░ ▒░ ░ ▒  ▒   ░ ▒ ▒░ ░ ░▒  ░ ░   ░ ░▒  ░ ░ ▒ ░░ ░░   ░ ▒░     ░   ░ ░ ░ ▒  ░  ░ ▒ ▒░   ░▒ ░ ▒░ ▒ ░  ▒   ▒▒ ░
 ░    ░   ░   ▒   ░  ░  ░    ░        ░   ▒     ░░   ░  ░ ░  ░ ░ ░ ░ ▒  ░  ░  ░     ░  ░  ░   ▒ ░   ░   ░ ░    ░ ░   ░   ░ ░   ░ ░ ░ ▒    ░░   ░  ▒ ░  ░   ▒   
 ░            ░  ░      ░                 ░  ░   ░        ░        ░ ░        ░           ░   ░           ░          ░     ░  ░    ░ ░     ░      ░        ░  ░
      ░                                                 ░                                                                                                      
");
            Thread.Sleep(1000);
            string presentacion = @"
            ╔════════════════════════════════════════════════════════════════╗
            ║                                                                ║
            ║              ¡Bienvenido a Bastardos Sin Gloria:               ║
            ║                     La Misión Final!                           ║
            ║                                                                ║
            ╠════════════════════════════════════════════════════════════════╣
            ║ En medio de la Segunda Guerra Mundial, un grupo de soldados    ║
            ║ aliados, conocidos como los Bastardos, lucha contra las        ║
            ║ fuerzas del Tercer Reich. Liderados por el valiente Teniente   ║
            ║ Aldo Raine, tu misión es infiltrarte en territorio enemigo,    ║
            ║ sembrar el caos y eliminar a los altos mandos nazis.           ║
            ║                                                                ║
            ║ Selecciona tu personaje entre los icónicos miembros de         ║
            ║ los Bastardos, cada uno con habilidades únicas, para realizar  ║
            ║ esta última misión.                                            ║
            ║                                                                ║
            ║ ¿Estás listo para convertirte en un verdadero Bastardo y       ║
            ║ cambiar el curso de la guerra?                                 ║
            ║                                                                ║
            ╠════════════════════════════════════════════════════════════════╣
            ║                Presiona enter para continuar...                ║
            ╚════════════════════════════════════════════════════════════════╝";
            Escribir(1, presentacion);
            Console.ReadKey();
            Console.Clear();
        }

        public static void Menu()
        {
            Console.Clear();
            string menu = @"
            ╔════════════════════════════════════════════════════════════════╗
            ║                                                                ║
            ║                      Bastardos Sin Gloria                      ║
            ║                                                                ║
            ╠════════════════════════════════════════════════════════════════╣
            ║                      1. Jugar                                  ║
            ║                      2. Historial de ganadores                 ║
            ║                      3. Salir                                  ║
            ╚════════════════════════════════════════════════════════════════╝";
            Escribir(1, menu);
        }
    }
}