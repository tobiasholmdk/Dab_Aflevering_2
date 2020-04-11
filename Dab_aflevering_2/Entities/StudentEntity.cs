namespace Dab_aflevering_2.Entities
{
    public class StudentEntity
    {
        public int AuId { get; set; }
        public string Name { get; set; }
        
        //Nav props:
        public int CourseId { get; set; }
        public CourseEntity Course { get; set; }

        public int ExerciseId { get; set; }
        public ExerciseEntity Exercise { get; set; }
        
        public int Assignmentid { get; set; }
        public AssignmentEntity Assignment { get; set; }
    }
}