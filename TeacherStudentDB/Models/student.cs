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

        
        public string firstName { get; set; }


        public string lastName { get; set; }


        public int age { get; set; }


        public string gender { get; set; }


        public int year { get; set; }


        public string teacherId { get; set; }

        public ICollection<classroom> classroom { get; set; }
    }
}
