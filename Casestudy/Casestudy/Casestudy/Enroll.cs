using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casestudy
{
    class Enroll
    {
        private Student student;
        private Course course;
        private LocalDate enrollmentDate;

        public Enroll(Student student, Course course, LocalDate enrollmentDate)
        {
            this.student = student;
            this.course = course;
            this.enrollmentDate = enrollmentDate;
        }
    }
}
