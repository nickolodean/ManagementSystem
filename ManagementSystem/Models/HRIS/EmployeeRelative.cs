using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ManagementSystem.Models.HRIS
{
    public class EmployeeRelative
    {
        public int Id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter worker's first name."), Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter worker's last name."), Display(Name = "Last Name")]
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Occupation { get; set; }
        public string Address { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter contact details."), DataType(DataType.PhoneNumber),
            RegularExpression(@"^(09|\+639)\d{9}$", ErrorMessage = "Please make sure that the phone number is valid for Philippines.")]
        public string Phone { get; set; }

        // Foreign Keys
        [ForeignKey("EmployeeRefId")]
        public Employee Employee { get; set; }

    }
}
