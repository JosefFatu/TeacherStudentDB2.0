using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeacherStudentDB.Models
{
    public class student
    {
        public int studentId { get; set; }
        [Display(Name = "AC Number"), Required, MaxLength(50)]
        
        public string firstName { get; set; }
        [Display(Name = "First Name"), Required, MaxLength(50)]

        public string lastName { get; set; }
        [Display(Name = " Last Name"), Required, MaxLength(50)]

        public int age { get; set; }
        [Display(Name = "Age"),Required, MaxLength (3)]

        public string gender { get; set; }
        [Display(Name ="Gender"),Required,MaxLength(50)]

        public int year { get; set; }
        [Display(Name ="Year Level"),Required, MaxLength(50)]

        public string teacherId { get; set; }

        public ICollection<classroom> classroom { get; set; }
    }
}
