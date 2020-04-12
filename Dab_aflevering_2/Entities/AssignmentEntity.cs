using System.Collections.Generic;

namespace Dab_aflevering_2.Entities
{
    public class AssignmentEntity
    {
        public int Id { get; set; }
        
        // Nav props
        /*public int StudentId { get; set; }
        public StudentEntity Student { get; set; }*/
        
        public ICollection<StudentEntity> Students { get; set; }
        public ICollection<ExerciseEntity> Exercises { get; set; }
    }
}