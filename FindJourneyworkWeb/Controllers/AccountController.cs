using FindJourneyworkWeb.Models;
using FindJourneyworkWeb.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FindJourneyworkWeb.Controllers
{
    public class AccountController : Controller
    {
        [Authorize]
        // GET: User
        public ActionResult Index()
        {
            UserListViewModel userListViewModel = new UserListViewModel();
            UserBusinessLayer userBal = new UserBusinessLayer();
            userListViewModel.Email = User.Identity.Name;


            List<User> usersList = userBal.GetUsers();

            //List<WorkType> worktypes = worktypeBal.GetWorkTypes();

            List<UserViewModel> userViewModels = new List<UserViewModel>();

            for(int i=0;i< usersList.Count; i++)
            {
                if(userListViewModel.Email== usersList[i].Email)
                {
                    UserViewModel userViewModel = new UserViewModel();
                    userViewModel.FirstName = usersList[i].FirstName;
                    userViewModel.LastName = usersList[i].LastName;
                    userViewModel.Email = usersList[i].Email;
                    userViewModel.Password = usersList[i].Password;
                    userViewModel.Phone = usersList[i].Phone;
                    userViewModel.UserType = usersList[i].UserType;

                    userListViewModel.Users = userViewModels;
                    userViewModels.Add(userViewModel);

                    return View("Index", userListViewModel);
                }

            }


            //foreach (User user in users)
            //{
            //    UserViewModel userViewModel = new UserViewModel();
            //    userViewModel.FirstName = user.FirstName;
            //    userViewModel.LastName = user.LastName;
            //    userViewModel.Email = user.Email;
            //    userViewModel.Password = user.Password;
            //    userViewModel.Phone = user.Phone;
            //    userViewModel.UserType = user.UserType;

            //    userListViewModel.Users = userViewModels;

            //    userViewModels.Add(userViewModel);
            //}


            return View("Index", userListViewModel);
        }
    }
}