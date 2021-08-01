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
    public class CategoryController : Controller
    {
        CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
        // GET: Category
        public ActionResult Index()
        {
            var result = categoryManager.GetAll();
            return View(result);
        }

        [HttpGet]
        public ActionResult CategoryAdd()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CategoryAdd(Category category)
        {
            categoryManager.Add(category);
            return RedirectToAction("Index");
        }

        public ActionResult CategoryDelete(int id)
        {
            var category = categoryManager.GetById(id);
            categoryManager.Delete(category);
            return RedirectToAction("Index");
        }


        public ActionResult CategoryBring(int id)
        {
            var categoryValues = categoryManager.GetById(id);       //DbEntities.Categories.Find(id);
            return View("CategoryBring", categoryValues);
        }
        public ActionResult Update(Category category)
        {
            //var categoryValues = categoryManager.GetById(category.CategoryId);  //DbEntities.Categories.Find(category.CategoryId);
            // categoryValues.CategoryName = category.CategoryName;
            categoryManager.Update(category);
            return RedirectToAction("Index");
        }
    }
}