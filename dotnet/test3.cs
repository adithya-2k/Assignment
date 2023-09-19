using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Create an Abstract class Student with Name, StudentId, Grade as members and 
//    also an abstract method Boolean Ispassed(grade)
//    which takes grade as an input and checks whether student passed the course or not.  

 

//Create 2 Sub classes Undergraduate and Graduate that 
//    inherits all members of the student and overrides Ispassed(grade) method


//For the UnderGrad class, if the grade is above 70.0, then 
//    isPassed returns true, otherwise it returns false.
//    For the Grad class, if the grade is above 80.0, then
//    isPassed returns true, otherwise returns false.


//Test the above by creating appropriate objects



namespace dotnet
{
    class test3
    {
        public void Main()
        {
            Undergraduate ung = new Undergraduate();
            
            Console.WriteLine($"Undergraduate: {ung.Ispassed(60)}");

            Graduate grad = new Graduate();
            Console.WriteLine($"graduate: {grad.Ispassed(60)}");
            Console.Read();
        }

        abstract class Student
        {
            public string name;
            public int studentid;
            public string grade;

            public abstract Boolean Ispassed(decimal grade);
        }

        class Undergraduate : Student
        {
            public override Boolean Ispassed(decimal grade)
            {
                if (grade > 70)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }

        class Graduate : Student
        {
            public override Boolean Ispassed(decimal grade)
            {
                if (grade > 80)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }
    }
}
