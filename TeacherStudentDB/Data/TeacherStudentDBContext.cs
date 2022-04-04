using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TeacherStudentDB.Models;

    public class TeacherStudentDBContext : DbContext
    {
        public TeacherStudentDBContext (DbContextOptions<TeacherStudentDBContext> options)
            : base(options)
        {
        }

        public DbSet<TeacherStudentDB.Models.student> student { get; set; }

        public DbSet<TeacherStudentDB.Models.teacher> teacher { get; set; }

        public DbSet<TeacherStudentDB.Models.classroom> classroom { get; set; }

        public DbSet<TeacherStudentDB.Models.courses> courses { get; set; }
    }
