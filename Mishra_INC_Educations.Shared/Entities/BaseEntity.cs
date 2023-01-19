using System;
using System.Collections.Generic;
using System.Text;

namespace Mishra_INC_Educations.Shared.Entities
{
    public class BaseEntity
    {
        public bool IsActive { get; set; }
        public int CreatedBy { get; set; }
        public int ModifiedBy { get; set; }
        public long CreatedDate { get; set; }
        public long ModifiedDate { get; set; }
    }
}
