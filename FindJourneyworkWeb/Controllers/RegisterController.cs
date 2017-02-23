using FindJourneyworkWeb.Models;
using FindJourneyworkWeb.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FindJourneyworkWeb.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Register
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AddNew()
        {
            return View("Index");
        }

        public ActionResult SaveUser(User u, string BtnSubmit)
        {
            switch (BtnSubmit)
            {

                case "SaveUser":
                    if (ModelState.IsValid)
                    {
                        UserBusinessLayer userBal = new UserBusinessLayer();
                        userBal.SaveUser(u);
                        return RedirectToAction("Index", "Login");

                    }
                    else
                    {
                        return View("Index");
                    }
                case "Cancel":
                    return RedirectToAction("Index", "Login");
            }
            return new EmptyResult();

        }
    }
}
