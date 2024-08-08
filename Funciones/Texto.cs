using System;
using System.Threading;
using Personajes;

namespace Texto
{
    public static class Texto
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
▒░▒   ░   ▒   ▒▒ ░░ ░▒  ░ ░    ░      ▒   ▒▒ ░  ░▒ ░ ▒░ ░ ▒  ▒   ░ ▒ ▒░ ░ ░▒  ░ ░   ░ ░▒  ░ ░ ▒ ░░ ░░   ░ ▒░     ░   ░ ░ ░ ▒  ░  ░ ▒ ▒░   ░▒ ░ ▒░ ▒ ░  ▒   ▒▒ ░
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

        public static void MostrarMensajeDerrota()
        {
            string rendirse = $@"
            ╔════════════════════════════════════════════════════════════════╗
            ║                                                                ║
            ║                       Mensaje del Teniente Aldo Raine          ║
            ║                                                                ║
            ╠════════════════════════════════════════════════════════════════╣
            ║ “¡Maldita sea! Nos has deshonrado a todos. Aquí no hay lugar   ║
            ║  para los débiles ni para los cobardes. Esperaba más de ti,    ║
            ║  pero parece que me equivoqué. Recuérdalo bien: rendirse no    ║
            ║  es una opción. Si quieres ser uno de los Bastardos, levántate,║
            ║  límpiate la sangre y vuelve a pelear. ¡No aceptamos perdedores║
            ║  en nuestras filas!”                                           ║
            ║                                                                ║
            ║                       - Teniente Aldo Raine                    ║
            ╚════════════════════════════════════════════════════════════════╝
";
            Escribir(1, rendirse);
        }

        public static void Ganaste(){
            Console.WriteLine(@"
  ▄████  ▄▄▄       ███▄    █  ▄▄▄        ██████ ▄▄▄█████▓▓█████         
 ██▒ ▀█▒▒████▄     ██ ▀█   █ ▒████▄    ▒██    ▒ ▓  ██▒ ▓▒▓█   ▀         
▒██░▄▄▄░▒██  ▀█▄  ▓██  ▀█ ██▒▒██  ▀█▄  ░ ▓██▄   ▒ ▓██░ ▒░▒███           
░▓█  ██▓░██▄▄▄▄██ ▓██▒  ▐▌██▒░██▄▄▄▄██   ▒   ██▒░ ▓██▓ ░ ▒▓█  ▄         
░▒▓███▀▒ ▓█   ▓██▒▒██░   ▓██░ ▓█   ▓██▒▒██████▒▒  ▒██▒ ░ ░▒████▒        
 ░▒   ▒  ▒▒   ▓▒█░░ ▒░   ▒ ▒  ▒▒   ▓▒█░▒ ▒▓▒ ▒ ░  ▒ ░░   ░░ ▒░ ░        
  ░   ░   ▒   ▒▒ ░░ ░░   ░ ▒░  ▒   ▒▒ ░░ ░▒  ░ ░    ░     ░ ░  ░        
░ ░   ░   ░   ▒      ░   ░ ░   ░   ▒   ░  ░  ░    ░         ░           
      ░       ░  ░         ░       ░  ░      ░              ░  ░        
                                                                        
 ▄▄▄▄    ▄▄▄        ██████ ▄▄▄█████▓ ▄▄▄       ██▀███  ▓█████▄  ▒█████  
▓█████▄ ▒████▄    ▒██    ▒ ▓  ██▒ ▓▒▒████▄    ▓██ ▒ ██▒▒██▀ ██▌▒██▒  ██▒
▒██▒ ▄██▒██  ▀█▄  ░ ▓██▄   ▒ ▓██░ ▒░▒██  ▀█▄  ▓██ ░▄█ ▒░██   █▌▒██░  ██▒
▒██░█▀  ░██▄▄▄▄██   ▒   ██▒░ ▓██▓ ░ ░██▄▄▄▄██ ▒██▀▀█▄  ░▓█▄   ▌▒██   ██░
░▓█  ▀█▓ ▓█   ▓██▒▒██████▒▒  ▒██▒ ░  ▓█   ▓██▒░██▓ ▒██▒░▒████▓ ░ ████▓▒░
░▒▓███▀▒ ▒▒   ▓▒█░▒ ▒▓▒ ▒ ░  ▒ ░░    ▒▒   ▓▒█░░ ▒▓ ░▒▓░ ▒▒▓  ▒ ░ ▒░▒░▒░ 
▒░▒   ░   ▒   ▒▒ ░░ ░▒  ░ ░    ░      ▒   ▒▒ ░  ░▒ ░ ▒░ ░ ▒  ▒   ░ ▒ ▒░ 
 ░    ░   ░   ▒   ░  ░  ░    ░        ░   ▒     ░░   ░  ░ ░  ░ ░ ░ ░ ▒  
 ░            ░  ░      ░                 ░  ░   ░        ░        ░ ░  
      ░                                                 ░               
");
            Thread.Sleep(6000);
        }
        public static void Perdiste(){
            Console.WriteLine(@"
 ██▓███  ▓█████  ██▀███  ▓█████▄  ██▓  ██████ ▄▄▄█████▓▓█████           
▓██░  ██▒▓█   ▀ ▓██ ▒ ██▒▒██▀ ██▌▓██▒▒██    ▒ ▓  ██▒ ▓▒▓█   ▀           
▓██░ ██▓▒▒███   ▓██ ░▄█ ▒░██   █▌▒██▒░ ▓██▄   ▒ ▓██░ ▒░▒███             
▒██▄█▓▒ ▒▒▓█  ▄ ▒██▀▀█▄  ░▓█▄   ▌░██░  ▒   ██▒░ ▓██▓ ░ ▒▓█  ▄           
▒██▒ ░  ░░▒████▒░██▓ ▒██▒░▒████▓ ░██░▒██████▒▒  ▒██▒ ░ ░▒████▒          
▒▓▒░ ░  ░░░ ▒░ ░░ ▒▓ ░▒▓░ ▒▒▓  ▒ ░▓  ▒ ▒▓▒ ▒ ░  ▒ ░░   ░░ ▒░ ░          
░▒ ░      ░ ░  ░  ░▒ ░ ▒░ ░ ▒  ▒  ▒ ░░ ░▒  ░ ░    ░     ░ ░  ░          
░░          ░     ░░   ░  ░ ░  ░  ▒ ░░  ░  ░    ░         ░             
            ░  ░   ░        ░     ░        ░              ░  ░          
                          ░                                             
 ▄▄▄▄    ▄▄▄        ██████ ▄▄▄█████▓ ▄▄▄       ██▀███  ▓█████▄  ▒█████  
▓█████▄ ▒████▄    ▒██    ▒ ▓  ██▒ ▓▒▒████▄    ▓██ ▒ ██▒▒██▀ ██▌▒██▒  ██▒
▒██▒ ▄██▒██  ▀█▄  ░ ▓██▄   ▒ ▓██░ ▒░▒██  ▀█▄  ▓██ ░▄█ ▒░██   █▌▒██░  ██▒
▒██░█▀  ░██▄▄▄▄██   ▒   ██▒░ ▓██▓ ░ ░██▄▄▄▄██ ▒██▀▀█▄  ░▓█▄   ▌▒██   ██░
░▓█  ▀█▓ ▓█   ▓██▒▒██████▒▒  ▒██▒ ░  ▓█   ▓██▒░██▓ ▒██▒░▒████▓ ░ ████▓▒░
░▒▓███▀▒ ▒▒   ▓▒█░▒ ▒▓▒ ▒ ░  ▒ ░░    ▒▒   ▓▒█░░ ▒▓ ░▒▓░ ▒▒▓  ▒ ░ ▒░▒░▒░ 
▒░▒   ░   ▒   ▒▒ ░░ ░▒  ░ ░    ░      ▒   ▒▒ ░  ░▒ ░ ▒░ ░ ▒  ▒   ░ ▒ ▒░ 
 ░    ░   ░   ▒   ░  ░  ░    ░        ░   ▒     ░░   ░  ░ ░  ░ ░ ░ ░ ▒  
 ░            ░  ░      ░                 ░  ░   ░        ░        ░ ░  
      ░                                                 ░               
");
            Thread.Sleep(6000);
        }

    }
}