using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace UsersRegistration.Models
{
    public class Users
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter your name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter your Lastname")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please enter your Login")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Please enter your email address")]
        [RegularExpression(@".+\@.+\..+", ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter your phone number")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Please enter your pasword")]
        public string Password { get; set; }

        public Role role { get; set; }

    }
}