﻿using IA_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace IA_Project.Controllers
{
    public class HomeController : Controller
    {
     //  [Authorize]
        public ActionResult Index()
        {
            return View();
        }

        /*public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Admin modle, string returnUrl)
        {
            ProjectContext db = new ProjectContext();
            var dataItem = db.Admins.Where(x => x.User_Name == modle.User_Name && x.password == modle.password).First();
            if (dataItem != null)
            {
                FormsAuthentication.SetAuthCookie(dataItem.User_Name, false);
                if (Url.IsLocalUrl(returnUrl) && returnUrl.Length > 1 && returnUrl.StartsWith("/")
                    && !returnUrl.StartsWith("//") && !returnUrl.StartsWith("/\\"))
                {
                    return Redirect(returnUrl);
                }
                else
                {
                    return RedirectToAction("Index");

                }
            }
            else
            {
                ModelState.AddModelError("", "Invalid user/pass");
                return View();
            }
        }
        */
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


        [Authorize]
        [AllowAnonymous]
        
        public ActionResult Logout()
        {

            FormsAuthentication.SignOut();
            return RedirectToAction("Login", "Login");

        }



    }
}