namespace Dab_aflevering_2.Entities
{
    public class AssignmentEntity
    {
        public int Id { get; set; }
        
        // Nav props
        
        public TeacherEntity Teacher { get; set; }
        public CourseEntity Course { get; set; }
        public ICollection<StudentEntity> Students { get; set; }
        //public ICollection<ExerciseEntity> Exercises { get; set; }
    }
}