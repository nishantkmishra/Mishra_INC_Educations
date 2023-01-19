using Mishra_INC_Educations.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mishra_INC_Educations.Shared.Entities.Students
{
    public class Student : BaseEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string GuardianName { get; set; }
        public ClassStandred ClassStandred { get; set; }
        public ClassSections ClassSections { get; set; }
        public string Address { get; set; }
        public int PinCode { get; set; }
        public int UserId { get; set; }
    }
}
