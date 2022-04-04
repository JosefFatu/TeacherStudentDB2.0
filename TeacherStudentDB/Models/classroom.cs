using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeacherStudentDB.Models
{
    public class classroom
    {
        public int classroomId { get; set; }


        public int block { get; set; }


        public int level { get; set; }


        public string className { get; set; }


        public student student { get; set; }

        public teacher teacher { get; set; }
    }
}
