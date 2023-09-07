using System;

namespace day_1
{
    class posorneg
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Data:");
            int value1 = Convert.ToInt32(Console.ReadLine());

            if (value1 >= 0)
                Console.WriteLine($"{value1} is positive");
            else
                Console.WriteLine($"{value1} is negative");

            Console.Read();

        }
    }
}
       