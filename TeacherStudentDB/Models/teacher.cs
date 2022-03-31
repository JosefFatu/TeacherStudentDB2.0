using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeacherStudentDB.Models
{
    public class teacher
    {
        public int teacherId { get; set; }

        public string firstName { get; set; }

        public string lastName { get; set; }

        public string gender { get; set; }

        public int age { get; set; }

        public ICollection<classroom> classroom { get; set; }
    }
}
