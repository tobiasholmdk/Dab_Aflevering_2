using System;
using System.Linq;
using System.Threading.Tasks;
using Dab_aflevering_2.Entities;
using Microsoft.EntityFrameworkCore;


namespace Dab_aflevering_2.DBContext
{
    public class DbContext 
    {
        public DbSet<StudentEntity> Students { get; set; }
        public DbSet<TeacherEntity> Teachers { get; set; }
        public DbSet<CourseEntity> Courses { get; set; }
        public DbSet<ExerciseEntity> Exercises { get; set; }
        public DbSet<AssignmentEntity> Assignments { get; set; }
    }
}
