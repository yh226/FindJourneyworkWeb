using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace FindJourneyworkWeb.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        //[Required(ErrorMessage = "Enter First Name")]
        public string FirstName { get; set; }
        //[StringLength(5, ErrorMessage = "Last Name length should not be greater than 5")]
        public string LastName { get; set; }
        public string EMail { get; set; }
        public string Phone { get; set; }
        public string City { get; set; }

       
    }
}