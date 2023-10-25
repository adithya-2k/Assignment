using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Assignment6b
    {
        static void Main(string[] args)

        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Assignment.Assignment6a.CalculateConcession(age, name);
            Console.ReadLine();

        }
    }
}
