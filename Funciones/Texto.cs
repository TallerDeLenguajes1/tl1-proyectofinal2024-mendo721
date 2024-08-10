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
            Console.WriteLine($@"
            ╔════════════════════════════════════════════════════════════════╗
            ║                                                                ║
            ║                      Bastardos Sin Gloria                      ║
            ║                                                                ║
            ╠════════════════════════════════════════════════════════════════╣
            ║                      1. Nueva partida                          ║
            ║                      2. Cargar partida                         ║
            ║                      3. Historial de ganadores                 ║
            ║                      4. Salir                                  ║
            ╚════════════════════════════════════════════════════════════════╝");
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
        public static void Mision(){
            Console.WriteLine(@"
            ╔══════════════════════════════════════════════════════════════════════════╗
            ║                                                                          ║
            ║                       Misión Final: Operación Cinéma Infernal            ║
            ║                                                                          ║
            ╠══════════════════════════════════════════════════════════════════════════╣
            ║ Tus órdenes son claras. Serán dejados a 10 kilómetros a las afueras de   ║
            ║ París. El objetivo es simple, pero mortal. Su misión es infiltrarse en   ║
            ║ un cine del corazón de París, donde los altos mandos del Tercer Reich    ║
            ║ estarán reunidos para una función especial. Este será su único y mejor   ║
            ║ chance para eliminar a la cúpula nazi de una vez por todas.              ║
            ║                                                                          ║
            ║ El camino no será fácil. El área está fuertemente vigilada, y cualquier  ║
            ║ movimiento en falso podría significar el fracaso de la misión. Deben     ║
            ║ ser silenciosos, precisos y letales. Infiltrarse en el cine, mezclarte   ║
            ║ entre la multitud sin ser detectado, y cuando llegue el momento,         ║
            ║ desatar el infierno.                                                     ║
            ║                                                                          ║
            ║ Recuerden, este es un golpe quirúrgico; su éxito podría cambiar el curso ║
            ║ de la guerra. Buena suerte, Bastardos. El destino de miles descansa en   ║
            ║ sus manos.                                                               ║
            ║                                                                          ║
            ║ Nota: La información sobre el clima se les informará a la brevedad.      ║
            ╠══════════════════════════════════════════════════════════════════════════╣
            ║                        Presiona Enter para continuar...                  ║
            ╚══════════════════════════════════════════════════════════════════════════╝
            ");
            Thread.Sleep(6000);
            Console.ReadKey();
            Console.Clear();
        }

    }
}