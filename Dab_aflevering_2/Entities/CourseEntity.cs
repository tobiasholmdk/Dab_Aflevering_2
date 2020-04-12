using System.Collections.Generic;

namespace Dab_aflevering_2.Entities
{
    public class CourseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        // Nav Props
        
        public ICollection<StudentEntity> Students { get; set; }
        public ICollection<TeacherEntity> Teachers { get; set; }
        public ICollection<AssignmentEntity> Assignment { get; set; }
    }
}