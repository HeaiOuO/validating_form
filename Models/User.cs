using System;
using System.ComponentModel.DataAnnotations;

namespace Validating_Form.Models
{
    public class User
    {
        [Required]
        [RegularExpression("^[a-zA-Z]+(([',. -][a-zA-Z ])?[a-zA-Z]*)*$", ErrorMessage="First Name must be an actual name!")]
        [MinLength(2, ErrorMessage="First Name must be at least 2 characters!")]
        [MaxLength(25, ErrorMessage="First Name cannot exceed 25 characters!")]
        public string FirstName { get; set; }


        [Required]
        [RegularExpression("^[a-zA-Z]+(([',. -][a-zA-Z ])?[a-zA-Z]*)*$", ErrorMessage="LastName must be an actual name!")]
        [MinLength(2, ErrorMessage="Last Name must be at least 2 characters!")]
        [MaxLength(25, ErrorMessage="Last Name must cannot exceed 25 characters!")]
        public string LastName { get; set; }


        [Required]
        [Range(0, 120, ErrorMessage="You are definitly not that old/young. Try again!")]
        public int Age { get; set; }


        [Required]
        [EmailAddress(ErrorMessage="Please enter in a valid email address!")]
        public string Email { get; set; }


        [Required]
        [MinLength(8, ErrorMessage="Password must be at least 8 characters!")]
        [DataType(DataType.Password, ErrorMessage="Password invalid!")]
        public string Password { get; set; }
    }
}