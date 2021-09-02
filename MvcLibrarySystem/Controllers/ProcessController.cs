using Business.Concrete;
using DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcLibrarySystem.Controllers
{
    public class ProcessController : Controller
    {

        MovementManager movementManager = new MovementManager(new EfMovementDal());

        public ActionResult Index()
        {
           var result = movementManager.GetAllProcessTrue();
            return View(result);
        }
    }
}