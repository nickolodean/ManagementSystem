using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ManagementSystem.Models.HRIS
{
    public class Department
    {
        public int Id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter a valid department name"), 
            MinLength(2, ErrorMessage = "Department name must be at least 2 characters"), 
            MaxLength(150, ErrorMessage = "Only 150 characters are allowed for this field.")]
        public string Name { get; set; }

        // Collection
        public virtual ICollection<Employee> Employees { get; set; }

    }
}
