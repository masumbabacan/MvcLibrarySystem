using Business.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcLibrarySystem.Controllers
{
    public class HomePageController : Controller
    {
        BookManager bookManager = new BookManager(new EfBookDal());
        ContactManager contactManager = new ContactManager(new EfContactDal());

        // GET: HomePage
        [HttpGet]
        public ActionResult Index()
        {
            var books = bookManager.GetAll();
            return View(books);
        }
        [HttpPost]
        public ActionResult Index(Contact contact)
        {
            contactManager.Add(contact);
            return RedirectToAction("Index");
        }
    }
}