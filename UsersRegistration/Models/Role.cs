using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace UsersRegistration.Models
{
    public class Role
    {
        public int Id { get; set; }
        //[Required(ErrorMessage = "Please enter your Role")]

        [Required(ErrorMessage = "Please enter your Role")]
        public bool? Name { get; set; }

    }
}