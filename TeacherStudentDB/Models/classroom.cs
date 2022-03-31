using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeacherStudentDB.Models
{
    public class classroom
    {
        public int classroomId { get; set; }
        [Display(Name = "Classroom"), Required, MaxLength(50)]

        public int block { get; set; }
        [Display(Name ="Block"), Required, MaxLength(50)]

        public int level { get; set; }
        [Display(Name ="Level"),Required, MaxLength(50)]

        public string className { get; set; }
        [Display(Name ="Class"), Required, MaxLength(50)]

        public student student { get; set; }

        public teacher teacher { get; set; }
    }
}
