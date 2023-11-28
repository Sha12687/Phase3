using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AddMarkApiMVC.Models
{
    public class Subject
    {
        [Key]
        public int SubjectId { get; set; }

        [Required(ErrorMessage = "StudentId is required")]
        public int StudentId { get; set; }

        [Required(ErrorMessage = "Subject Name is required")]
        public string SubjectName { get; set; }

        [Required(ErrorMessage = "Subject Total Mark is required")]
        public int TotalMark { get; set; }

        [Required(ErrorMessage = "Marks Obtained is required")]
        public int MarkObtained { get; set; }

        // Navigation property
        [ForeignKey("StudentId")]
        public Student Student { get; set; }
    }
}