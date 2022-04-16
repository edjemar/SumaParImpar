using System;

namespace SumaParImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, par = 0, impar = 0, sumapar = 0, sumaimpar = 0;
            Console.WriteLine("Indique número analizar: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write("{0}|", i);
                    sumapar += i;
                    par++;
                }
            }
            Console.Write("\n\n");
            Console.WriteLine("la suma de los numeros pares es: " + sumapar);
            Console.WriteLine("el total de los numeros pares es " + par);
            Console.Write("\n\n");
            Console.WriteLine("numeros impares");
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write("{0}|", i);
                    sumaimpar += i;
                    impar++;
                }
            }
            Console.Write("\n\n");
            Console.WriteLine("la suma de los numeros impares es: " + sumaimpar);
            Console.WriteLine("el total de los numeros impares es " + impar);
            Console.ReadKey();
        }
    }
}
