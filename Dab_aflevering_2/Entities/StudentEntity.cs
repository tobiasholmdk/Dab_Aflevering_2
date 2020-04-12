using System.Collections.Generic;

namespace Dab_aflevering_2.Entities
{
    public class StudentEntity
    {
        public int Id { get; set; }
        public int AuId { get; set; }
        public string Name { get; set; }

        //Nav props:
        public ICollection<CourseEntity> Courses { get; set; }
        public ICollection<ExerciseEntity> Exercises { get; set; }
        public ICollection<AssignmentStudentEntity> Assignments { get; set; }

    }
}