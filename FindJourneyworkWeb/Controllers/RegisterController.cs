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
            TypeUserBusinessLayer TypeuserBal = new TypeUserBusinessLayer();
            List<TypeUser> TypesuserList = TypeuserBal.GetTypeUser();

            SelectList Droplist = new SelectList(TypesuserList, "TypeId", "TypeName");
            ViewBag.DropDownValues = Droplist;//new SelectList(new[] { "-" });

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
                        TypeUserBusinessLayer TypeuserBal = new TypeUserBusinessLayer();
                        List<TypeUser> TypesuserList = TypeuserBal.GetTypeUser();

                        string selectValueID = Request.Form["MydropDown"].ToString();
                        for(int i=0;i< TypesuserList.Count; i++)
                        {
                            if (TypesuserList[i].TypeId.ToString().Equals(selectValueID))
                            {
                                u.UserType = TypesuserList[i].TypeName;
                                userBal.SaveUser(u);
                                return RedirectToAction("Index", "Login");
                               // break;
                            }
                        }

                        
                        //userBal.SaveUser(u);
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
