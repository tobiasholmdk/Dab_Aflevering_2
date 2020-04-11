namespace Dab_aflevering_2.Entities
{
    public class AssignmentEntity
    {
        public int Id { get; set; }
        
        // Nav props
        public int StudentId { get; set; }
        public StudentEntity student { get; set; }
        
        public int exerciseId {get; set;}
        public ExerciseEntity exercise { get; set; }
    }
}