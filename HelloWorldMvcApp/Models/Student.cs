using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorldMvcApp.Models
{
    public enum Gender
    {
        Male,
        Female
    }

    public class Student
    {
        public int StudentID { get; set; }

        [Required]
        [Display(Name = "Name")]
        public string StudentName { get; set; }

        [Display(Name = "Gender")]
        public Gender StudentGender { get; set; }

        [Display(Name = "Enrolled")]
        public Enrolled StudentEnrolled { get; set; }

        [Range(5,50)]
        [Display(Name = "Age")]
        public int StudentAge { get; set; }

        [Display(Name = "Address")]
        public string StudentAddress { get; set; }

        public Grade StudentGradeLevel { get; set; }

        [Display(Name = "Pass")]
        public bool MyBooleanValue { get; set; } = true;

    }

    public enum Enrolled 
    {
        Yes,
        NO
    }

    public enum Grade
    {
        Freshman,
        Sophmore,
        Junior,
        Senior
    }
}
