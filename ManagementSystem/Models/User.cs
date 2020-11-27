using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ManagementSystem.Models
{
    public enum UserLevel
    {
        Admin,
        Manager,
        Supervisor,
        Member
    }

    public class User
    {
        public int Id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter a username"), 
            RegularExpression("(?!^[0-9]*$)(?!^[a-zA-Z]*$)^([a-zA-Z0-9]{6,15})$")]
        public string Username { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Password is required."), DataType(DataType.Password), 
            RegularExpression("(?!^[0-9]*$)(?!^[a-zA-Z]*$)^([a-zA-Z0-9]{6,})$", 
            ErrorMessage = "Your password needs to be: \n  • Include bot lower and upper case characters. \n " +
            "• Include at least one number or symbol. \n " +
            "• be at least 6 characters long.")]
        public string Password { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter a user level access."), Display(Name = "User Level")]
        public UserLevel UserLevel { get; set; }
    }
}
