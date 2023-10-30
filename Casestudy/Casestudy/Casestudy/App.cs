using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casestudy
{
    public class App
    {
        static void Main(string[] args)
        {
            App.Scenario1();
            App.Scenario2();
            Console.Read();

        }

        public static void Scenario1()
        {
            Student stu1 = new Student(1, "Adithya", DateTime.Parse("2000-08-20"));
            Student stu2 = new Student(2, "Siva", DateTime.Parse("1999-04-24"));

            Info.Display(stu1);
            Info.Display(stu2);
        }

        public static void Scenario2()
        {
            Student[] stuarray = new Student[2];

            stuarray[0] = new Student(3, "Elakiya", new DateTime(1995, 11, 25));
            stuarray[1] = new Student(4, "Shoba", new DateTime(1990, 12, 21));

            foreach (Student student in stuarray)
            {
                Info.Display(student);
            }
        }
    }
}
