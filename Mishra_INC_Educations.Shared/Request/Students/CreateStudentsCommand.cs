using Mishra_INC_Educations.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mishra_INC_Educations.Shared.Request.Students
{
    public class CreateStudentsCommand
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string GuardianName { get; set; }
        public string FatherEmail { get; set; }
        public long FatherMobileNo { get; set; }
        public ClassStandred ClassStandred { get; set; }
        public ClassSections ClassSections { get; set; }
        public string Address { get; set; }
        public int PinCode { get; set; }
    }
}
