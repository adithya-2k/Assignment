using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet
{
    class Day_9
    {
        static void Main()
        {
            Passanger pg = new Passanger();
            try
            {
                pg.Ticketbooking();
            }
            catch (Exception Exp)
            {
                Console.WriteLine("Enter only Number Please");
                Console.Read();
            }
        }
        public class Passanger
        {
            string Name;
            int Age;
            public void Ticketbooking()
            {
                Console.Write("How man ticket you want to book: ");
                int no_of_tickets = Convert.ToInt32(Console.ReadLine());

                if (no_of_tickets > 2)
                {
                    Console.WriteLine("cannot book more than 2 tickets");
                    Console.Read();
                }
                else
                {
                    Console.Write("Enter your name: ");
                    string value1 = Console.ReadLine();
                    Console.Write("Enter your Age: ");
                    int value2 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter your name: ");
                    string value3 = Console.ReadLine();
                    Console.Write("Enter your Age: ");
                    int value4 = Convert.ToInt32(Console.ReadLine());


                    Console.WriteLine($"Passanger 1 name: {value1} and Age: {value2}");
                    Console.WriteLine($"Passanger 2 name: {value3} and Age: {value4}");
                    Console.WriteLine("Ticket Booked Successfully");
                    Console.Read();
                }
            }

        }

        public class check
        {
            public void check1()
            {

            }
        }
    }
}
