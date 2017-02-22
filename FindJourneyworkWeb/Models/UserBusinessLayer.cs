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

        public User SaveUser(User u)
        {
            UserERPDAL userDal = new UserERPDAL();
            userDal.Users.Add(u);
            userDal.SaveChanges();
            return u;
        }

        public bool IsValidUser(User u)
        {
            

            if (u.Email == "Admin" && u.Password == "Admin")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}