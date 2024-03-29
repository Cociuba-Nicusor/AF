﻿using System;

namespace _7RotateImage
{
    class Program
    {
        public static void Rotate(int[,] m)
        {
            int n = m.GetLength(0);
            for (int i = 0; i < n / 2; i++)
            {
                for (int j = 0; j < n / 2; j++)
                {
                    int aux = m[i, j];
                    m[i, j] = m[n - j - 1, i];
                    m[n - j - 1, i] = m[n - i - 1, n - j - 1];
                    m[n - i - 1, n - j - 1] = m[j, n - i - 1];
                    m[j, n - i - 1] = aux;

                    /*    { 1,2,3,4 },
                          { 5,6,7,8 },
                          { 9,10,11,12 },
                          { 13,14,15,16 } */
                }
            }
            View(m);
        }
        public static void View(int[,] m)
        {
            int n = m.GetLength(0);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(m[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int[,] m = new int[,]
            {
                {1,2,3,4 },
                {5,6,7,8 },
                {9,10,11,12 },
                {13,14,15,16 }
            };
            Rotate(m);
        }
    }
}
