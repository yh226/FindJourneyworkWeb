using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FindJourneyworkWeb.ViewModels
{
    public class UserViewModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
        //[Required(ErrorMessage = "Enter First Name")]
        public string FirstName { get; set; }
        //[StringLength(5, ErrorMessage = "Last Name length should not be greater than 5")]
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string City { get; set; }
        public string UserType { get; set; }
    }
}