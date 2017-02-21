using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FindJourneyworkWeb.DataAccessLaye;
using FindJourneyworkWeb.Models;

namespace FindJourneyworkWeb.ViewModels
{
    public class UserBusinessLayer
    {
        public List<User> GetUsers()
        {
            UserERPDAL userDal = new UserERPDAL();

            return userDal.Users.ToList();

        }
    }
}