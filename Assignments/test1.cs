using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet
{
    class test1
    {
        static void Main(string[] args)
        {

            Program.findandremove();
        }
        public static void findandremove()

        {
            Console.WriteLine("Enter the string");
            string value = Console.ReadLine();
            int data = Convert.ToInt32(Console.ReadLine());

            foreach (var check in value)
            {
                int indx = value.IndexOf(check);
                if (data == indx)
                {
                }
                else
                {
                    Console.Write(check);
                }
            }
            Console.Read();
        }


    }
}
