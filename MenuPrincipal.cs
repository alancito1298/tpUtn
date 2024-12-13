using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioFinal
{
    internal class MenuPrincipal
    {
        public static void menuPrincipal()
        {
            bool stop = true;


            while (stop == true)
            {
                try
                {
                    Console.WriteLine(@"
           
            
             Ejercicios de la diplomatura
               
             ##    ##   ######   ###   ##
             ##    ##     ##     ## #  ##
             ##    ##     ##     ##  # ##
             ##    ##     ##     ##   ###
             ##    ##     ##     ##    ##
             ##    ##     ##     ##    ##
              #####       ##     ##    ##
__________________________________________________________
      
    INGRESE EL NUMERO DEL EJERCICIOS QUE DESEA UTILIZAR
    .---------------------------------------------.
    | 1 | - Condicionales  | / | 4 | - Bucles For |
    -----------------------------------------------
    | 2 | - Bucle While    | / | 5 | - Strings    |
    -----------------------------------------------   
    | 3 | - Bucle do While | / | 6 | - Arrays     |
    '---------------------------------------------'
                               | x | - salir      |    
    _______________________________________________
");

                    string respuesta = Console.ReadLine();

                    switch (respuesta)
                    {


                        case "1":
                            Console.WriteLine("respuesta 1");
                            Thread.Sleep(500);
                            Console.Clear();
                            Condicionales.SubMenuCondicionales();
                          
                            break;

                        case "2":
                            Console.Clear();
                            Console.WriteLine("respuesta2");
                            Thread.Sleep(500);
                            doWhile.SubMenuDoWhile();   
                            break;

                        case "3":
                            Console.Clear();
                            doWhile.SubMenuDoWhile();
                            Console.WriteLine("respuest3");
                            break;

                        case "4":
                            Console.Clear();
                            Console.WriteLine("respuesta4");
                            break;


                        case "5":
                            Console.Clear();
                            Console.WriteLine("respuesta-5");
                            break;

                        case "6":
                            Console.Clear();
                            Console.WriteLine("respuesta-6");
                            break;

                        case "x":

                            Console.WriteLine("saliendo...");
                            Thread.Sleep(6000);
                            Console.Clear();
                            break;

                        default:
                            Console.WriteLine("ingrese un numero válidos");
                            break;

                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }




        }
    }
}
