using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Assignment4b
    {
        static void Main(string[] args)
        {
            Student stu = new Student(123,"adithya K","A",4,"CSE");
            Console.WriteLine("Student Rollno: " + stu.rollno + "\nStudent Name: " + stu.name + "\nStudent Class: " + stu.Class + "\nStudent Semester: " + stu.branch);
            int[] marks = { 35, 55, 67, 99, 98 };
            stu.Displayresult(marks);
            stu.DisplayData(marks);
            Console.Read();

        }
    }

    class Student
    {
        public int rollno;
        public string name;
        public string Class;
        public int semester;
        public string branch;
        public int[] marks = new int[5];

        public Student(int rollno, string name, string Class, int semester, string branch)
        {
            this.rollno = rollno;
            this.name = name;
            this.Class = Class;
            this.semester = semester;
            this.branch = branch;

        }

        public void Displayresult(int[] marks)
        {
            int sum = 0;
            double ave = 0;
            string check = "";
            for (int i =0; i< marks.Length; i++)
            {
                sum = sum + marks[i];
            }
            ave = sum / 5;

            for (int i = 0; i < marks.Length; i++)
            {
                if (marks[i] < 35)
                {
                    check="Failed";
                }
                
            }

            if (ave < 50 && check != "Failed")
            {
                Console.WriteLine("\nYour are Failed");

            }
            else if (ave > 50 && check != "Failed")
            {
                Console.WriteLine("\nYou are Passed");

            }
            else
            {
                Console.WriteLine("\nYou are Failed");

            }


        }

        public void DisplayData(int[] marks)
        {
            Console.WriteLine("\nYour Marks are:");
            for (int i = 0; i < marks.Length; i++)
            {
                Console.WriteLine(marks[i]);
            }
        }
    }
}
