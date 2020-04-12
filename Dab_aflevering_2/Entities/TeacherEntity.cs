using Dab_aflevering_2.Contracts;

namespace Dab_aflevering_2.Entities
{
    public class TeacherEntity
    {
        public int AuId { get; set; }
        public string Name { get; set; }

        // Nav props
        public ICollection<ExerciseEntity> Exercises { get; set; }
        public ICollection<AssignmentEntity> Assignments { get; set; }
        public CourseEntity Course { get; set; }
    }
}