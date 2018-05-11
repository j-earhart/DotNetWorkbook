using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorldMvcApp.Models
{
    public class Grades

    {
        public int StudentID { get; set; }

        [Required]
        [Display(Name = "Student Name")]
        public string StudentName { get; set; }

        [Required]
        [Display(Name = "Teacher Name")]
        public string TeacherName { get; set; }

        [Display(Name = "Subject")]
        public Subject SubjectName { get; set; }

        [Display(Name = "Assignment")]
        public string StudentAssignment { get; set; }

        [Display(Name = "Teacher Notes")]
        [MaxLength(100,ErrorMessage = "Stop Complaining!")]
        public string TeacherNotes { get; set; }

    }


    public enum Subject
    {
        Math,
        English,
        History,
        Art
    }
}
