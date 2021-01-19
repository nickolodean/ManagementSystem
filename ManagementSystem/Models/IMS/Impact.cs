using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ManagementSystem.Models.IMS
{
    public class Impact
    {
        public int Id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Incident Impact name is required. Please fill out the filled.")]
        public string Name { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Description is critically required. Please fill out the filled.")]
        public string Description { get; set; }
    }
}
