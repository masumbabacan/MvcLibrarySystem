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
    public class WriterController : Controller
    {
        // GET: Writer
        WriterManager writerManager = new WriterManager(new EfWriterDal());
        public ActionResult Index()
        {
            var writers = writerManager.GetAll();
            return View(writers);
        }

        [HttpGet]
        public ActionResult WriterAdd()
        {
            return View();
        }

        [HttpPost]
        public ActionResult WriterAdd(Writer writer)
        {
            writerManager.Add(writer);
            return RedirectToAction("Index");
        }

        public ActionResult WriterDelete(int id)
        {
            var values = writerManager.GetById(id);
            writerManager.Delete(values);
            return RedirectToAction("Index");
        }

        public ActionResult WriterBring(int id)
        {
            var values = writerManager.GetById(id);
            return View("WriterBring", values);
        }

        public ActionResult WriterUpdate(Writer writer)
        {
            writerManager.Update(writer);
            return RedirectToAction("Index");
        }
    }
}




