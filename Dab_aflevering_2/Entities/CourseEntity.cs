namespace Dab_aflevering_2.Entities
{
    public class CourseEntity
    {
        public int CourseId { get; set; }
        public string Name { get; set; }

        // Nav Props
        public ICollection<StudentEntity> Students { get; set; }
        public ICollection<AssignmentEntity> Assignments { get; set; }
        public ICollection<TeacherEntity> Teachers { get; set; }
    }
}