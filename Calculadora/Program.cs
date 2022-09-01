using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {

            menu();

        }



        public static void menu()
        {

            int opcion;
            int cantidad;
            double resultado;


            try
            {
                    do
                    {
                        Console.WriteLine("***APP CALCULADORA***");
                        Console.WriteLine();
                        Console.WriteLine("-- MENÚ --");
                        Console.WriteLine("1- SUMAR");
                        Console.WriteLine("2- RESTAR");
                        Console.WriteLine("3- MULTIPLICAR");
                        Console.WriteLine("4- DIVIDIR");
                        Console.WriteLine("0- SALIR");
                        Console.Write("Seleccione una operación: ");

                        opcion = Int32.Parse(Console.ReadLine());

                        switch (opcion)
                        {

                            case 1:
                                Console.WriteLine("INDIQUE CUÁNTOS NÚMEROS VA A SUMAR");
                                cantidad = Int32.Parse(Console.ReadLine());

                                int[] matrizSuma = new int[cantidad];

                                Console.WriteLine("INDIQUE LOS NÚMEROS QUE QUIERE SUMAR");
                                for (int i = 0; i < matrizSuma.Length; i++)
                                    matrizSuma[i] = Int32.Parse(Console.ReadLine());

                                Console.WriteLine("EL RESULTADO DE LA SUMA ES: " + sumar(matrizSuma));


                                break;

                            case 2:
                                Console.WriteLine("INDIQUE CUÁNTOS NÚMEROS VA A RESTAR");
                                cantidad = Int32.Parse(Console.ReadLine());

                                int[] matrizResta = new int[cantidad];

                                Console.WriteLine("INDIQUE LOS NÚMEROS QUE QUIERE RESTAR");
                                for (int i = 0; i < matrizResta.Length; i++)
                                    matrizResta[i] = Int32.Parse(Console.ReadLine());

                                Console.WriteLine("EL RESULTADO DE LA RESTA ES: " + restar(matrizResta));

                                break;

                            case 3:
                                Console.WriteLine("INDIQUE CUÁNTOS NÚMEROS VA A MULTIPLICAR");
                                cantidad = Int32.Parse(Console.ReadLine());
                            
                                double[] matrizMult = new double[cantidad];

                                Console.WriteLine("INDIQUE LOS NÚMEROS QUE QUIERE MULTIPLICAR");
                                for (int i = 0; i < matrizMult.Length; i++)
                                    matrizMult[i] = Double.Parse(Console.ReadLine());


                                Console.WriteLine("EL RESULTADO DE LA MULTIPLICACIÓN ES: " + multiplicar(matrizMult));

                                break;

                            case 4:
                                Console.WriteLine("INDIQUE EL DIVIDENDO");
                                double dividendo = Double.Parse(Console.ReadLine());

                                Console.WriteLine("INDIQUE EL DIVISOR");
                                double divisor = Double.Parse(Console.ReadLine());

                                resultado = dividir(dividendo, divisor);

                                Console.WriteLine("EL RESULTADO DE LA SUMA ES: " + resultado);

                                break;

                            default:
                                if (opcion != 0)
                                    Console.WriteLine("ERROR ### OPCIÓN INCORRECTA ###");
                                break;

                        }


                    } while (opcion != 0) ;

                    Console.WriteLine("******Fin de ejecución*******");

            }
            catch(FormatException e)
            {
                    Console.WriteLine("******HA INTRODUCIDO DATOS NO VÁLIDOS******");
                    Console.WriteLine("MENSAJE DE ERROR---> " + e.Message);
                    Console.WriteLine("******Fin de ejecución*******");

            }

               
        }


        public static int sumar(int[] matriz)
        {
            int res = 0;

            for(int i = 0; i<matriz.Length; i++)
            {
                res = res + matriz[i];
            }
            return res;
        }

        public static int restar(int[] matriz)
        {
            int res = matriz[0];

            for (int i = 1; i < matriz.Length; i++)
            {
                res = res - matriz[i];
            }
            return res;
        } 

        public static double multiplicar(double[] matriz)
        {
            double res = matriz[0];

            for (int i = 1; i < matriz.Length; i++)
            {
                res = res * matriz[i];
            }
            return res;
        }

        public static double dividir(double dividendo, double divisor)
        {
            double res = dividendo / divisor;

            return res;
        }

      

    }
}
