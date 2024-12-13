
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace ejercicioFinal
{
    internal class Condicionales
    {
        public static void SubMenuCondicionales() {
            
            
            bool stop = true;


            while (stop == true) {
                try
                {
                    Console.WriteLine(@"
                   
                    CONDICIONALES ANIDADOS
    __________________________________________________________
      
    INGRESE EL NUMERO DE EJERCICIOS DE CONDICIONES QUE DESEA UTILIZAR
    .------------------------------------------------------------------------------.
    | 1 | - CONVERSOR DE CALIFICACION  | / | 4 | - ¿ PUEDE DONAR SANGRE ?          |
    -------------------------------------------------------------------------------
    | 2 | - DETECTOR DE MOMENTO DEL DÍA| / | 5 | - COMPROBAR SI ESTA APROBADO      |
    -------------------------------------------------------------------------------   
    | 3 | - IDENTIFICADOR DE NUMERO    | / | 6 | - SWITCH DE LUZ                   |
    '------------------------------------------------------------------------------
    |                                      | x | - VOLVER A MENU PRINCIPAL         |   
    '______________________________________________________________________________' 
");

                    string respuesta = Console.ReadLine();

                    switch (respuesta) {


                        case "1":
                            Console.Clear();
                            Console.WriteLine("respuesta1");
                            Thread.Sleep(2000);
                            Ejercicio1();
                            break;

                        case "2":
                            Console.WriteLine("respuesta 2");
                            Thread.Sleep(500);
                            Console.Clear();
                            Ejercicio2();
                            break;

                        case "3":
                            Console.Clear();
                            Console.WriteLine("respuesta 3");
                            Thread.Sleep(500);
                            Console.Clear();
                            Ejercicio3();
                            break;

                        case "4":
                            Console.Clear();
                            Console.WriteLine("respuesta 4");
                            Thread.Sleep(500);
                            Console.Clear();
                            Ejercicio4();
                            break;


                        case "5":
                            Console.Clear();
                            Console.WriteLine("respuesta 5");
                            Thread.Sleep(500);
                            Console.Clear();
                            Ejercicio5();
                            break;

                        case "6":
                            Console.Clear();
                            Console.WriteLine("respuesta 6");
                            Ejercicio6();
                            break;

                        case "x":

                            Console.WriteLine("saliendo...");
                            Thread.Sleep(1000);
                            Console.Clear();
                            MenuPrincipal.menuPrincipal();
                            break;

                        default:
                            Console.WriteLine("ingrese un numero válido");
                            break;

                    }
                } catch (Exception ex) {
                    Console.WriteLine(ex.Message);
                }
            }





        }
        private static void Ejercicio1()
        {
            bool stop = true;

            while (stop == true)
            {


                Console.WriteLine(@"
                      - DECTECTOR DE MOMENTO DEL DÍA -
               
             Por favor ingrese una calificación (del 0 al 100)
                                        
                                        | presione x para volver |             
"
                );
                int numero;
                string calificacion = Console.ReadLine();

                if (calificacion.ToLower() == "x") stop = false;

                if (int.TryParse(calificacion, out numero))
                {
                    if (numero >= 90 && numero < 100) Console.WriteLine($"La conversion de es {numero} -> A");
                    else if (numero >= 80 && numero <= 90) Console.WriteLine($"La conversion de es {numero} -> B");
                    else if (numero >= 70 && numero <= 80) Console.WriteLine($"La conversion de es {numero} -> C");
                    else if (numero >= 60 && numero <= 70) Console.WriteLine($"La conversion de es {numero} -> D");
                    else if (numero <= 60) Console.WriteLine($"La conversion de es {numero} -> F");
                    else Console.WriteLine("calificacíon fuera de rango!");
                }
                else
                {
                    Console.WriteLine("dato no válido");
                }


            }
        }
        private static void Ejercicio2()
        {
            bool stop = true;

            while (stop == true)
            {


                Console.WriteLine(@"
                      - CONVERSOR DE CALIFICACIóNES -
               
                        Por favor ingrese la hora
                                        
                                        | presione x para volver |             
"
                );
                int dato;
                string hora = Console.ReadLine();

                if (hora.ToLower() == "x") stop = false;

                if (int.TryParse(hora, out dato))
                {
                    if (dato >= 6 && dato <= 11) Console.WriteLine($"son las {hora} de la mañana!");
                    else if (dato >= 12 && dato <= 17) Console.WriteLine($"son las {hora} de la tarde!");
                    else if (dato >= 18 && dato <= 23) Console.WriteLine($"son las {hora} de la noche!");
                    else if (dato >= 0 && dato <= 5) Console.WriteLine($"son las {hora} de la noche!");
                    else Console.WriteLine("dato fuera de rango!");
                }
                else
                {
                    Console.WriteLine("dato no válido");
                }


            }
        }
        private static void Ejercicio3()
        {
            bool stop = true;

            while (stop == true)
            {


                Console.WriteLine(@"
                      - VALIDACION DE NUMEROS -
               
                        Por favor ingrese un número
                                        
                                        | presione x para volver |             
"
                );
                int input;
                string numero = Console.ReadLine();

                if (numero.ToLower() == "x") stop = false;
                {

                    if (int.TryParse(numero, out input))
                    {
                        if (input != 0)
                        {
                            if (input > 0)
                            {
                                if (input % 2 == 0)
                                {
                                    Console.WriteLine($"{input} es positivo y par");
                                } else
                                { Console.WriteLine($"{input} es positivo e impar"); }
                            } else
                            {
                                if (input % 2 == 0)
                                {
                                    Console.WriteLine($"{input} es negativo y par");
                                }
                                else
                                { Console.WriteLine($"{input} es negativo e impar"); }
                            }
                        }

                        else { Console.WriteLine("el numero es 0"); }
                    } else
                    {
                        Console.WriteLine("dato no válido");
                    }


                }
            }

        }
        private static void Ejercicio4()
        {
            bool stop = true;

            while (stop == true)
            {


                Console.WriteLine(@"
                               - ¿ PUEDO DONAR SANGRE? -
               
                               Por favor ingrese su edad                                        
                                      
                                | presione x para volver |             
"
                );
                string edad = Console.ReadLine();

                Console.WriteLine(@"
                           
               
                               Por favor ingrese su peso                                       
                                      
                                      
"
               );

                string peso = Console.ReadLine();
               
                int inputPeso;
                int inputEdad;


                if (peso.ToLower() == "x" || edad.ToLower() == "x") stop = false;
                {
                    if (int.TryParse(edad, out inputEdad))
                       {

                        if (int.TryParse(peso, out inputPeso))
                        {
                            if (inputPeso > 1 && inputPeso < 130)
                            {
                                if (inputEdad >= 18 && inputPeso > 50) Console.WriteLine("Puede realizar la donacion");
                                else if (inputEdad < 18) Console.WriteLine("Usted es menor de edad, no puede realizar la donacion");
                                else if (inputPeso < 50) Console.WriteLine("su peso es bajo, no puede realizar la donacion");
                                else Console.WriteLine("Usted es menor de edad y su peso es bajo");
                            }
                            else Console.WriteLine("edad fuera de rango");

                        }
                        else { Console.WriteLine("edad no válida"); }

                    }
                    else { Console.WriteLine("peso no válido"); }

                   


                    }
                }
            }
        private static void Ejercicio5()
        {
            bool stop = true;

            while (stop == true)
            {


                Console.WriteLine(@"
                               - Validacion de Calificacion -
               
                              Por favor ingrese la nota a validar                                      
                                      
                                | presione x para volver |             
"
                );
              
                string nota = Console.ReadLine();

                int inputNota;
           


                if (nota.ToLower() == "x" ) stop = false;
                {
                    if (int.TryParse(nota, out inputNota))
                    {

                       
                            if (inputNota >= 0 && inputNota <= 10)
                            {
                                if (inputNota >= 6 && inputNota >= 10) Console.WriteLine("Aprobado!!!");
                                else Console.WriteLine("Desparobado :c");
                                
                            }
                           

                        }
                        else { Console.WriteLine("nota no válida"); }

                    




                }
            }
        }
        private static void Ejercicio6()
        {
            bool stop = true;

            while (stop == true)
            {


                Console.WriteLine(@"
                                       - luz -
               
                              Por favor ingrese -> on <- para prender                                      
                                                -> off <- para apagar
                               
                                    | presione x para volver |     

"
                );
            
                string respuesta = Console.ReadLine();
                bool estado=false;
          



                if (respuesta.ToLower() == "x") stop = false;
                {
                    if (respuesta.ToLower() == "on" || respuesta.ToLower() == "off")
                    {


                     if(respuesta.ToLower() == "on")
                        {
                                
                            estado = true;
                        } else
                        {
                            estado = false;
                        }


                    }
                    else { Console.WriteLine("comando no válido... \n la luz permanecera apagada"); }

                    if (estado) Console.WriteLine("luz encendida");
                    else Console.WriteLine("luz apagada");
                






                }
            }
        }

    }
        

    };

