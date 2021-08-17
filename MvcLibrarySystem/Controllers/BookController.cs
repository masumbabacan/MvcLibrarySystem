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
    public class BookController : Controller
    {
        // GET: Book

        BookManager bookManager = new BookManager(new EfBookDal());
        CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
        WriterManager writerManager = new WriterManager(new EfWriterDal());
        public ActionResult Index()
        {
            var books = bookManager.GetAll();
            return View(books);
        }

        [HttpGet]
        public ActionResult BookAdd()
        {
            List<SelectListItem> category = (from i in categoryManager.GetAll()
                                             select new SelectListItem
                                             {
                                                 Text = i.CategoryName,
                                                 Value = i.CategoryId.ToString()
                                             }).ToList();

            List<SelectListItem> writer = (from i in writerManager.GetAll()
                                             select new SelectListItem
                                             {
                                                 Text = i.FirstName + " " + i.LastName,
                                                 Value = i.WriterId.ToString()
                                             }).ToList();
            ViewBag.category = category;
            ViewBag.writer = writer;
            return View();
        }

        [HttpPost]
        public ActionResult BookAdd(Book book)
        {
            bookManager.Add(book);
            return RedirectToAction("Index");
        }

        public ActionResult BookDelete(int id)
        {
            var book = bookManager.GetById(id);
            bookManager.Delete(book);
            return RedirectToAction("Index");
        }


        public ActionResult BookBring(int id)
        {
            List<SelectListItem> category = (from i in categoryManager.GetAll()
                                             select new SelectListItem
                                             {
                                                 Text = i.CategoryName,
                                                 Value = i.CategoryId.ToString()
                                             }).ToList();

            List<SelectListItem> writer = (from i in writerManager.GetAll()
                                           select new SelectListItem
                                           {
                                               Text = i.FirstName + " " + i.LastName,
                                               Value = i.WriterId.ToString()
                                           }).ToList();
            ViewBag.category = category;
            ViewBag.writer = writer;
            var values = bookManager.GetById(id);
            return View("BookBring", values);
        }

        public ActionResult BookUpdate(Book book)
        {
            bookManager.Update(book);
            return RedirectToAction("Index");
        }
    }
}