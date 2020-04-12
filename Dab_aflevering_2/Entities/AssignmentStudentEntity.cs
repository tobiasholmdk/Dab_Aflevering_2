using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dab_aflevering_2.Entities
{
    public class AssignmentStudentEntity
    {
        public AssignmentEntity Assignments { get; set; }
        public int AssignmentId { get; set; }
        public StudentEntity Students { get; set; }
        public int StudentAuId { get; set; }
    }
}
