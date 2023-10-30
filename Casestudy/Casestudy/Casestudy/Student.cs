using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casestudy
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Dob { get; set; }

        public Student(int id, string name, DateTime date_of_birth)
        {
            Id = id;
            Name = name;
            Dob = date_of_birth;
        }
    }


    public class Info
    {

        public static void Display(Student student)
        {
            Console.WriteLine($"Student ID : {student.Id} Student name : {student.Name} Student date of birth : {student.Dob}");

        }


        //public static void DisplayTwo(Course course)
        //{
        //Console.WriteLine($"Course ID : {course.course_id} Course Name : {course.course_name}");
        //}

    }
}



