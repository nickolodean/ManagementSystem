using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ManagementSystem.Models.IMS
{
    public class TypeCategory
    {
        public int Id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Incident Type Category name is required. Please fill out the filled.")]
        public string Name { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Description is critically required. Please fill out the filled.")]
        public string Description { get; set; }

        // Foreign Keys
        [ForeignKey("TypeRefId")]
        public Type Type { get; set; }
    }
}
