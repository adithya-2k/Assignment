﻿using System;
namespace exercises
{
    class test2
    {
      
        public static void Main()
        {
            int value1;
            int total;

            Console.WriteLine("Enter a number:");
            value1 = Convert.ToInt32(Console.ReadLine());

            total = value1 * 1;
            Console.WriteLine("{0} x {1} = {2}", value1, 1, total);
            total = value1 * 2;
            Console.WriteLine("{0} x {1} = {2}", value1, 2, total);
            total = value1 * 3;
            Console.WriteLine("{0} x {1} = {2}", value1, 3, total);
            total = value1 * 4;
            Console.WriteLine("{0} x {1} = {2}", value1, 4, total);
            total = value1 * 5;
            Console.WriteLine("{0} x {1} = {2}", value1, 5, total);
            total = value1 * 6;
            Console.WriteLine("{0} x {1} = {2}", value1, 6, total);
            total = value1 * 7;
            Console.WriteLine("{0} x {1} = {2}", value1, 7, total);
            total = value1 * 8;
            Console.WriteLine("{0} x {1} = {2}", value1, 8, total);
            total = value1 * 9;
            Console.WriteLine("{0} x {1} = {2}", value1, 9, total);
            total = value1 * 10;
            Console.WriteLine("{0} x {1} = {2}", value1, 10, total);
            Console.Read();
        }
    }


}