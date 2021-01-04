using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ManagementSystem.Models.MS
{
    public class ContactPerson
    {
        public int Id { get; set; }

        [Display(Name = "Client Name"), MaxLength(20, ErrorMessage = "Max length of characters is 20. Please shorten the name of client.")]
        public string Name { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter contact details."), DataType(DataType.PhoneNumber),
            RegularExpression(@"^(09|\+639)\d{9}$", ErrorMessage = "Please make sure that the phone number is valid for Philippines.")]
        public string Phone { get; set; }
        public string? Landline { get; set; }

        // Foreign Keys
        [ForeignKey("ContactRefId")]
        public Client Client { get; set; }
    }
}
