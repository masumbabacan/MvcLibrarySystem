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
    public class OnLoanController : Controller
    {
        MovementManager movementManager = new MovementManager(new EfMovementDal());
        BookManager bookManager = new BookManager(new EfBookDal());
        EfBookDal efBookDal = new EfBookDal();
        // GET: OnLoan
       
        [HttpGet]
        public ActionResult Lend()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Lend(Movement movement)
        {
            var result =efBookDal.Get(x => x.BookId == movement.BookId);
            if (result.Status == true)
            {
                movementManager.Add(movement);
                return RedirectToAction("BookReturnList");
            }
            else
            {
                return View();
            }
        }

        public ActionResult BookReturnList()
        {
            var result = movementManager.GetAllProcessFalse();
            return View(result);
        }

        public ActionResult BookReturnProcess(int id)
        {
            var result = movementManager.GetById(id);
            return View("BookReturnProcess",result);
        }

        [HttpPost]
        public ActionResult BookReturnUpdate(Movement movement)
        {
            movement.ProcessStatus = true;
            movementManager.Update(movement);
            return RedirectToAction("BookReturnList");
        }
    }
}