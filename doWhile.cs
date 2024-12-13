using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioFinal
{
    internal class doWhile
    {


        public static void SubMenuDoWhile()
        {


            bool stop = true;


            while (stop == true)
            {
                try
                {
                    Console.WriteLine(@"
                   
                                               DO WHILE
                        __________________________________________________________
      
                   INGRESE EL NUMERO DE EJERCICIOS DE DO WHILE QUE DESEA UTILIZAR
    .--------------------------------------------------------------------------------------------.
    | 1 | - IMPRIMIR SOLO MULTIPLOS DE 5 PERO    | / | 4 | - CONTADOR DE VOCALES                 |
    |   | NO DE 10 (0 al 100)                    | / |   |                                       |
    ---------------------------------------------------------------------------------------------|
    | 2 | - SUMAR NUMEROS PARES HASTA INTRODUCIR | / | 5 | - ACUMULADOR DE SOLO NUMEROS MULTIPLOS|
    |   |                                        | / |   |   DE 4 O 6                            |
    -------------------------------------------------------------------------------------------- |   
    | 3 | - INGRESAR PALABRAS E IMPRIMIR SOLO    | / | 6 | - SUMAR LOS NUM. IMPARES Y DIVIDE X 2 |
    |   | LA PRIMERA                             | / |   |   SUMAR LOS NUM. PARES Y DIVIDE X 3   |                             
    '---------------------------------------------------------------------------------------------
    |                                                | x | - VOLVER A MENU PRINCIPAL             |   
    '____________________________________________________________________________________________' 
");

                    string respuesta = Console.ReadLine();

                    switch (respuesta)
                    {


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
                }
                catch (Exception ex)
                {
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
                      - SUMA DE SOLO NUMEROS MULTIPLOS DE 5 PERO NO DE 10 -
               
                                    
                                            
                                        | presione x para volver | ");

                
                do{

                    Console.WriteLine(@"por favor ingrese un numero
                                                   o 
                                             's' para finalizar");
                    int numero;
                    int suma = 0;
                    string input = Console.ReadLine();
               

                    if (input.ToLower() == "x") stop = false;

                    if (int.TryParse(input, out numero))
                    {
                        if (numero % 5 == 0 && numero % 10 != 0) suma += numero;
                        else if (numero >= 80 && numero <= 90) Console.WriteLine($"La conversion de es {numero} -> B");
                      
                    }
                    else
                    {
                        Console.WriteLine("dato no válido");
                    }


                }while(proceso)
       } }
            private static void Ejercicio2()
            {
                bool stop = true;

                while (stop == true) {

                    int numero;
                    string inputNumero;
                    int suma = 0;
                    bool estado = true;
                    do
                    {




                        Console.WriteLine(@"
                      - SUMAR NUMEROS PARES HASTA INTRODUCIR UN IMPAR -
               
                        Por favor ingrese un numero
                                        
                                        | presione x para volver |             
"
                        );

                        inputNumero = Console.ReadLine();

                        if (inputNumero.ToLower() == "x") stop = false;

                        if (int.TryParse(inputNumero, out numero))
                        {
                            if (numero % 2 != 0)
                            {
                                estado = false;
                                Console.WriteLine($"suma total {suma} ");
                                Thread.Sleep(700);
                                Console.Clear();
                                Console.Write("saliendo");
                                Thread.Sleep(500);
                                Console.Write(".");
                                Thread.Sleep(500);
                                Console.Write(".");
                                Thread.Sleep(500);
                                Console.Write(".");
                                Console.Clear();
                                Console.Write("saliendo");
                                Thread.Sleep(500);
                                Console.Write(".");
                                Thread.Sleep(500);
                                Console.Write(".");
                                Thread.Sleep(500);
                                Console.Write(".");
                                Console.Clear();
                            }
                            else {
                                suma += numero;
                                Console.WriteLine($"suma actual {suma}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("valor no válido");
                        }

                    } while (estado);
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
                                    }
                                    else
                                    { Console.WriteLine($"{input} es positivo e impar"); }
                                }
                                else
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
                        }
                        else
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



                    if (nota.ToLower() == "x") stop = false;
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
                    bool estado = false;




                    if (respuesta.ToLower() == "x") stop = false;
                    {
                        if (respuesta.ToLower() == "on" || respuesta.ToLower() == "off")
                        {


                            if (respuesta.ToLower() == "on")
                            {

                                estado = true;
                            }
                            else
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
    } };
    

