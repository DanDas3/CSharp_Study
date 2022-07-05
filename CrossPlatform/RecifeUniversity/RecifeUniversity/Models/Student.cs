using System;
using System.Collections.Generic;

namespace RecifeUniversity.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        public string FirstMidName { get; set; }
        public string LastName { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; }

    }
}
