using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace FindJourneyworkWeb.Models
{
    public class Assignment
    {
        [Key]
        public int AssignmentId { get; set; }
        public string Date { get; set; }
        public string Price { get; set; }
        public string Location { get; set; }
        public string description { get; set; }
        public string phone { get; set; }

    }
}