using FindJourneyworkWeb.Models;
using FindJourneyworkWeb.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FindJourneyworkWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            UserListViewModel userListViewModel = new UserListViewModel();
            UserBusinessLayer userBal = new UserBusinessLayer();
            TypeUserBusinessLayer TypeuserBal = new TypeUserBusinessLayer();

           
            List<User> users = userBal.GetUsers();
          
            //List<WorkType> worktypes = worktypeBal.GetWorkTypes();

            List<UserViewModel> userViewModels = new List<UserViewModel>();


           
            

            foreach (User user in users)
            {
                UserViewModel userViewModel = new UserViewModel();
                userViewModel.FirstName = user.FirstName;
                userViewModel.LastName = user.LastName;
                userViewModel.Email = user.Email;
                userViewModel.Password = user.Password;
                userViewModel.Phone = user.Phone;
                userViewModel.UserType = user.UserType;

                userListViewModel.Users = userViewModels;

                userViewModels.Add(userViewModel);
            }


            return View("Index", userListViewModel);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}