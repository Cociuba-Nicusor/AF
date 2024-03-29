﻿using System;

namespace _13BinarySearch
{
    class Program
    {
        private static int BinarySearch(int[] v, int key)
        {
            int left, right, mid;
            left = 0; right = v.Length - 1;
            while (left <= right)
            {
                mid = left + (right - left) / 2;
                if (key < v[mid])
                {
                    right = mid - 1;
                }
                else if (key > v[mid])
                {
                    left = mid + 1;
                }
                else
                    return mid;
            }
            return -1;
        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 4, 5, 6, 6, 7, 8,9 };
            Console.WriteLine(BinarySearch(arr, 4));
        }
    }
}
