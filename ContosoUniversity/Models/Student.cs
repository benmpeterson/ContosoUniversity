using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ContosoUniversity.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        [Required(ErrorMessage ="Please Enter A Valid Date *This is a custom Error Message")]
        public DateTime EnrollmentDate { get; set; }

        //This will hold all the Enrollements of a created instance of this Student class
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}