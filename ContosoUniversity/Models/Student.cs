using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Student
    {
        public int ID { get; set; }
        //MinimumLength can be used in place of Required
        [StringLength(50, MinimumLength =1)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [StringLength(50, ErrorMessage ="First name cannot be longer than 50 characters.")]
        //Requires the first character to be upper case and the remaining characters to be alphabetical:   
        [DisplayName("First Name")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$", ErrorMessage ="Invalid Character")]
        //Changes Database column name to "FirstName"
        [Column("FirstName")]
        public string FirstMidName { get; set; }
        //The DataType attribute is used to specify a data type that is more specific than the database intrinsic type. 
        //In this case we only want to keep track of the date, not the date and time. 
        [DataType(DataType.Date)]
        //The ApplyFormatInEditMode setting specifies that the specified formatting should also be applied when the value is displayed in a text box for editing
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage ="Please Enter A Valid Date *This is a custom Error Message")]
        [Display(Name = "Enrollment Date")]
        public DateTime EnrollmentDate { get; set; }

        [Display(Name = "Full Name")]
        public string FullName
        {
            get
            {
                return LastName + " , " + FirstMidName;
            }
        }

        //This will hold all the Enrollements of a created instance of this Student class
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}