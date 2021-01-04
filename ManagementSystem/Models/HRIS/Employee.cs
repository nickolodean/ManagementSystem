using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ManagementSystem.Models.HRIS
{
    public enum MaritalStatus
    {
        Single,
        Engaged,
        Married,
        Widowed,
        Divorced
    }

    public class Employee
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Employee ID is required."), Display(Name = "Employee ID")]
        public string EmployeeNumber { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter worker's first name."), Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Middle Name")]
        public string MiddleName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter worker's last name."), Display(Name = "Last Name")]
        public string LastName { get; set; }
        public string Alias { get; set; }

        [Required(ErrorMessage = "Position is required.")]
        public string Position { get; set; }

        [Required(ErrorMessage = "Age is required.")]
        public int Age { get; set; }
        public decimal? Weight { get; set; }
        public decimal? Height { get; set; }
        public string Nationality { get; set; }
        public string Region { get; set; }

        [Required(ErrorMessage = "Civil status required."), Display(Name = "Civil Status")]
        public MaritalStatus CivilStatus { get; set; }

        [Required, DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Birthday { get; set; }

        [Required(ErrorMessage = "Please select user authentication method."), Display(Name = "Is this worker have a windows login?")]
        public bool IsDomainUser { get; set; }

        // Foreign Keys
        [ForeignKey("DepartmentRefId")]
        [Required, Display(Name = "Department")]
        public Department Department { get; set; }
        public virtual User User { get; set; }

        // Collections
        public virtual ICollection<EmployeeRelative> EmployeeRelatives { get; set; }

    }
}
