using Business.Concrete;
using DataAccess;
using DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcLibrarySystem.Controllers
{
    public class StatisticController : Controller
    {
        // GET: Statistic
        UserManager userManager = new UserManager(new EfUserDal());
        BookManager bookManager = new BookManager(new EfBookDal());
        PenaltyManager penaltyManager = new PenaltyManager(new EfPenaltyDal());
        Context context = new Context();
        public ActionResult Index()
        {
            var userCount = userManager.GetAll().Count();
            ViewBag.usrCount = userCount;

            var bookCount = bookManager.GetAll().Count();
            ViewBag.bookCount = bookCount;

            var depositBookCount = bookManager.GetAllDepositBook().Count();
            ViewBag.depositBookCount = depositBookCount;

            var cashAmount = context.Penalties.Sum(x => x.Money);

            ViewBag.cashAmount = cashAmount;

            return View();
        }

        public ActionResult Hava()
        {
            return View();
        }

        public ActionResult HavaKart()
        {
            return View();
        }        
        
        public ActionResult LinqCard()
        {
            return View();
        }
    }
}
