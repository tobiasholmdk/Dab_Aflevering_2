namespace Dab_aflevering_2.Entities
{
    public class AssignmentEntity
    {
        public int Id { get; set; }
        
        // Nav props
        public int StudentId { get; set; }
        public StudentEntity Student { get; set; }
        
        public int ExerciseId {get; set;}
        public ExerciseEntity Exercise { get; set; }
    }
}