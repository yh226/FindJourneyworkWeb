using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FindJourneyworkWeb.ViewModels
{
    public class UserListViewModel
    {
        public List<UserViewModel> Users { get; set; }

        public string Email { get; set; }
    }
}