namespace Dab_aflevering_2.Entities
{
    public class ExerciseEntity
    {
        public string Id { get; set; }
        public string Number { get; set; }
        public string Lecture { get; set; }
        public string HelpWhere { get; set; }
        
        // Nav props
        public int AssigmentId { get; set; }
        public AssignmentEntity Assigment { get; set; }
    }
}