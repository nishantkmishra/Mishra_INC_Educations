using Mishra_INC_Educations.Shared.Enums;
using System.ComponentModel.DataAnnotations;

namespace Mishra_INC_Educations.APP.Models
{
    public class StudentViewModel
    {
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required]
        [Display(Name = "Father Name")]
        public string FatherName { get; set; }
        [Required]
        [Display(Name = "Mother Name")]
        public string MotherName { get; set; }

        [Display(Name = "Guardian Name")]
        public string GuardianName { get; set; }
        [Required]
        [Display(Name = "Father Email")]
        public string FatherEmail { get; set; }
        [Required]
        [Display(Name = "Father Mobile no")]
        public long? FatherMobileNo { get; set; }
        [Required]
        [Display(Name = "Class Standred")]
        public ClassStandred? ClassStandred { get; set; }
        [Required]
        [Display(Name = "Class Sections")]
        public ClassSections? ClassSections { get; set; }
        [Required]
        [Display(Name = "Address")]
        public string Address { get; set; }
        [Required]
        [Display(Name = "Pin Code")]
        public int? PinCode { get; set; }
    }
}
