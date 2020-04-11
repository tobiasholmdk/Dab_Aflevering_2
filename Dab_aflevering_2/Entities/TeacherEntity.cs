using Dab_aflevering_2.Contracts;

namespace Dab_aflevering_2.Entities
{
    public class TeacherEntity
    {
        public int AuId { get; set; }
        public string Name { get; set; }
       
        // Nav props
        public int ExerciseId { get; set; }
        public ExerciseEntity Exercise { get; set; }
        
        public int AssigmentId { get; set; }
        public AssignmentEntity Assigment { get; set; }
    }
}