using Dab_aflevering_2.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;


namespace Dab_aflevering_2.DBContext
{
    public class DabDBContext : DbContext
    { 
        public DabDBContext(DbContextOptions<DabDBContext> options)
            : base(options)
        { }
        public DbSet<StudentEntity> Students { get; set; }
        public DbSet<TeacherEntity> Teachers { get; set; }
        public DbSet<CourseEntity> Courses { get; set; }
        public DbSet<ExerciseEntity> Exercises { get; set; }
        public DbSet<AssignmentEntity> Assignments { get; set; }
        public DbSet<AssignmentStudentEntity> AssignmentStudents { get; set; }
        public DbSet<StudentCourseEntity> StudentsCourses { get; set; }
    }
}
