using System.Collections.Generic;

namespace Dab_aflevering_2.Entities
{
    public class AssignmentEntity
    {
        public int Id { get; set; }
        
        // Nav props
        
        public TeacherEntity Teacher { get; set; }
        public CourseEntity Course { get; set; }
        public ICollection<AssignmentStudentEntity> Students { get; set; }
    }
}