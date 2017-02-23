using FindJourneyworkWeb.Models;
using FindJourneyworkWeb.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace FindJourneyworkWeb.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public ActionResult DoLogin(User u, string BtnSubmit)
        {
            switch (BtnSubmit)
            {
                case "Login":
                    UserBusinessLayer bal = new UserBusinessLayer();
                    if (bal.IsValidUser(u))
                    {
                        FormsAuthentication.SetAuthCookie(u.Email, true);
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        ModelState.AddModelError("CredentialError", "Invalid Username or Password");
                        return View("Index");
                    }
                case "Register":
                    return RedirectToAction("Index", "Register");
            }
            return new EmptyResult();
        }
                 
        
        
        
          
            

        

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");

        }

        public ActionResult AddNewUser()
        {
            return View("CreateUser");
        }


    }
}
    
       