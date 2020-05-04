using System;
using System.Runtime;


namespace Math_Practica
{
    class Math
    {
        static void Main(string[] args)
        {
            //La raíz cuadrada de un número
           double n1 = 81;         
           double sqrt1 = 0;                 //sqrt. usa double en su parametros
            sqrt1 = System.Math.Sqrt(n1);
            System.Console.WriteLine(sqrt1);

            //Un número elevado a la 4ta potencia
            double n2 = 2;          //pow. usa double en sus parametros
            double pow1 = System.Math.Pow(n2, 4);
            System.Console.WriteLine(pow1);

            //Obtener el signo de un número
            int n3 = 6;
            decimal signo = System.Math.Sign(n3);

            System.Console.WriteLine(getSign(signo));

         static String getSign(decimal signo){
            if (signo == 0)
                return "cero";
            else if (signo < 0)
                return "signo negativo ( - )";
            else
                return "signo positivo ( + )";
        }


            //A partir de dos números, determinar qué número es más grande
            int n4 = 10;
            int n5 = 20;
            int mayor = System.Math.Max(n4, n5);
            System.Console.WriteLine($"Numero mayor: {mayor}");

            //A partir de dos números, determinar qué número es más grande sin importar el signo 
            //(ej. -5 es mayor que 4 en este punto)
            double n6 = 10;
            double n7 = -20;
            double digito6 = System.Math.Abs(n6);
            double digito7 = System.Math.Abs(n7);
            double mayorDigito = System.Math.Max(n6, n7);
             System.Console.WriteLine($"Digito mayor: {mayorDigito}");

            //Quitar los decimales de un número
            double n8 = 9.11;
            double n8Entero = System.Math.Truncate(n8);
            System.Console.WriteLine($"numero entero : {n8Entero}");

            //Redondear el siguiente número: 8.55
            double n9 = 8.55;
            double n9Rounded = System.Math.Round(n9);
            System.Console.WriteLine($"Numero redondeado de 8.55 : {n9Rounded}");


           
           







        }
    }
}
