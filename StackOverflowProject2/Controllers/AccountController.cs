using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StackOverflowProject.ViewModels;
using StackOverflowProject.ServiceLayer;



namespace StackOverflowProject2.Controllers
{

    public class AccountController : Controller
    {

        IUsersService us;

        public AccountController(IUsersService us)
        {
            this.us = us;
        }


        // GET: Account
        public ActionResult Register()    
        {
            return View();
        }

        // POS: Account
        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Register(RegisterViewModel rvm)
        {

            if (ModelState.IsValid)
            {
                int uid = us.InsertUser(rvm);
                Session["CurrentUserID"] = uid;
                Session["CurrentUserName"] = rvm.Name;
                Session["CurrentUserEmail"] = rvm.Email;
                Session["CurrentUserPassword"] = rvm.Password;
                Session["CurrentUserIsAdmin"] = false;
                return RedirectToAction("Index", "Home");


            }
            else
            {
                ModelState.AddModelError("x", "Invalid data");
                return View(); // Register View Itself
            }

      
        }



    }
}