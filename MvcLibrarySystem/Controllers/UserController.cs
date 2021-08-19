using Business.Concrete;
using DataAccess.Concrete;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcLibrarySystem.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        UserManager userManager = new UserManager(new EfUserDal());
        public ActionResult Index(int page = 1)
        {
            var result = userManager.GetAll().ToPagedList(page,6);
            return View(result);
        }

        public ActionResult UserDelete(int id)
        {
            var values = userManager.GetById(id);
            userManager.Delete(values);
            return RedirectToAction("Index");
        }
    }
}