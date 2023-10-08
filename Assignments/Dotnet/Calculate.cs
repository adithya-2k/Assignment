using System;


namespace day_1
{
    class Calculate
    {
        public static void Main(string[] arg)
        {
            Console.WriteLine("Enter the first input value:");
            int value1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second input value:");
            int value2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please choose: \n\n 1 for addition \n\n 2 for subtraction \n\n 3 for multiplication \n\n 4 for division");
            int value3 = Convert.ToInt32(Console.ReadLine());

            switch (value3)
            {
                case 1:
                    int data = value1 + value2;
                    Console.WriteLine(data);
                    break;
                case 2:
                    int data2 = value1 - value2;
                    Console.WriteLine(data2);
                    break;
                case 3:
                    int data3 = value1 * value2;
                    Console.WriteLine(data3);
                    break;
                case 4:
                    int data4 = value1 / value2;
                    Console.WriteLine(data4);
                    break;
                default:
                    Console.WriteLine("invalid");
                    break;

            }
            Console.Read();
                }
    }
}
