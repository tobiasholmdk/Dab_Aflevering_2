using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dab_aflevering_2.Entities
{
    public class StudentCourseEntity
    {
        public StudentEntity Students { get; set; }
        public int StudentAuId { get; set; }
        public CourseEntity Courses { get; set; }
        public int CourseId { get; set; }
        public int Semester { get; set; }
    }
}
