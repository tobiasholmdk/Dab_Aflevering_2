namespace Dab_aflevering_2.Entities
{
    public class CourseEntity
    {
        public int CourseId { get; set; }
        public string Name { get; set; }
        
        // Nav Props
        public int StudentId { get; set; }
        public StudentEntity Student { get; set; }
        
        public int TeacherId { get; set; }
        public TeacherEntity Teacher { get; set; }
        
        public int AssigmentId{get; set;}
        public AssignmentEntity Assigment { get; set; }
    }
}