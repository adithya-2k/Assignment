using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace exercises
{
    class test1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value:");
            string value2 = Console.ReadLine();
            int value1 = Convert.ToInt32(Console.ReadLine());
            int value4 = Convert.ToInt32(Console.ReadLine());
            string value3 = value2.Remove(value1,value4);
            Console.WriteLine(value3);
            Console.Read();
        }
    }
}