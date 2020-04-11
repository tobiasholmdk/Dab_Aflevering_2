namespace Dab_aflevering_2.Entities
{
    public class ExerciseEntity
    {
        public string Id { get; set; }
        public string Number { get; set; }
        public string Lecture { get; set; }
        public string Help_where { get; set; }
        
        // Nav props
        public int assigmentId { get; set; }
        public AssignmentEntity assigment { get; set; }
    }
}