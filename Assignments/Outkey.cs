﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int add = 0;
            int prod = 0;
            int dif = 0;
            int div = 0;
            Program.Calculate_Method(10, 15, out add, out prod, out dif, out div);
            Console.WriteLine($"sum: {add}, prod: {prod}, dif: {dif}, div: {div}");

            Console.Read();



        }
        public static void Calculate_Method(int a, int b, out int sum, out int product, out int difference, out int divide)
        {
            sum = a + b;
            product = a * b;
            difference = a - b;
            divide = a / b;
        }

        public int check_params (params int[] arr){
            int check1 = 0;
            return check1;
            }

    }
}
