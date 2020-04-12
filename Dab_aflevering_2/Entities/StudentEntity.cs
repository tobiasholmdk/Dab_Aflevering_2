namespace Dab_aflevering_2.Entities
{
    public class StudentEntity
    {
        [Key]
        public int AuId { get; set; }
        public string Name { get; set; }

        //Nav props:
        public ICollection<CourseEntity> Courses { get; set; }
        public ICollection<ExerciseEntity> Exercises { get; set; }
        public ICollection<AssignmentEntity> Assignments { get; set; }

    }
}