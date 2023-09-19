using System;

namespace dotnet
{
    class Properties
    {
        static void Main()
        {

            person obj1 = new person();
            Console.WriteLine($"Initial fav sub {obj1.Favsub} \n ");
            obj1.Favsub = "science";
            Console.WriteLine($"my fav sub is changed to: {obj1.Favsub}");
            Console.Read();
        }
    }
    class person
    {
        private string favsub="english";

        public string Favsub
        {
            get
            {
                return favsub ;
            }
            set
            {
                favsub = value;
            }
        }

    }
}
