using Business.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MvcLibrarySystem.Controllers
{
    public class LoginController : Controller
    {
        UserManager userManager = new UserManager(new EfUserDal());

        AuthManager authManager = new AuthManager(new EfUserDal());

        [HttpGet]
        public ActionResult SignIn()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignIn(User user)
        {
            //bilgiler
            var informations = authManager.GetUser(user.Email, user.Password);

            if (informations != null)
            {
                FormsAuthentication.SetAuthCookie(informations.Email, false);
                return RedirectToAction("Index", "Panel");
            }
            else
            {
                return View();
            }
        }








        [HttpGet]
        public ActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SignUp(User user)
        {
            if (!ModelState.IsValid)
            {
                return View("Kayit");
            }
            userManager.Add(user);
            return RedirectToAction("Index", "HomePage");
        }
    }
}