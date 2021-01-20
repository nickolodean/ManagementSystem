using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ManagementSystem.Models.IMS
{
    public class Type
    {
        [Key]
        public int Id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Incident Type name is required. Please fill out the filled.")]
        public string Name { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Description is critically required. Please fill out the filled.")]
        public string Description { get; set; }

        // Collections
        public virtual ICollection<TypeCategory> TypeCategories { get; set; }
    }
}
