﻿using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer between 5and 20: ");

            int input = int.Parse(Console.ReadLine());

            if ( input >=5 && input <= 20)
            {
                int[] even = new int[input];
                int[] odd = new int[input];
                int[] fibonacci = new int[input];

                // initialize fibonacci series
                fibonacci[0] = 0;
                fibonacci[1] = 1;

                for (int i = 0; i < input; i++)
                {
                    even[i] = 2*i;
                    odd[i] = 2*i+1;

                    if (i >= 2)
                       fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
                }

                Console.WriteLine("");
                Console.WriteLine("Even");
                foreach (int number in even)
                {
                    Console.WriteLine(number);
                }

                Console.WriteLine("");
                Console.WriteLine("Odd");
                foreach (int number in odd)
                {
                    Console.WriteLine(number);
                }
                for (int i = 0; i < input; i++)
                {
                    Console.WriteLine("Fibonacci(" + i + ") = " + fibonacci[i]);                }
            }
        }
    }
}
