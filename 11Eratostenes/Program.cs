﻿using System;

namespace _11Eratostenes
{
    class Program
    {
        public static int n { get; set; }
        public static int[] array { get; set; }
        static void PrintPrimeNumbers()
        {
            Console.Write($"The prime numbers up until {n} are: ");

            for (int i = 2; i < array.Length; i++)
            {
                if (array[i] == 0)
                {
                    Console.Write(i + " ");
                }
            }
        }

        static void ComputePrimeNumbers()
        {
            array[0] = 1;
            array[1] = 1;

            for (int i = 2; i * i <= n; i++)
            {
                if (array[i] == 0)
                {
                    for (int j = 2; j <= n / i; j++)
                    {
                        array[i * j] = 1;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("**Sieve of Eratosthenes** ");
            Console.WriteLine();
            Console.Write("Enter a value for n: ");
            n = Int32.Parse(Console.ReadLine());
            array = new int[n + 1]; // In C# elementele unui array automat sunt initializate cu 0

            ComputePrimeNumbers();
            PrintPrimeNumbers();

            Console.ReadKey();

        }
    }
}