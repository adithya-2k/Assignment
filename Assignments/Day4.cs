using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_4
{
    class Day4
    {
        static void Main(string [] arg)
        {
            Day4.Userarray();
        }

        public static void Userarray()
        {
            int[] answer = new int[2];
            Console.WriteLine("Please enter a value:");
            for (int i = 0; i < answer.Length; i++)
            { 
                answer[i] = Convert.ToInt32(Console.ReadLine());
                }
            
            for (int j = 0; j < answer.Length; j++)
            {
                Console.Write($"{answer[j]}" + " " );
            }
            Console.Read();
        }

    }
}
