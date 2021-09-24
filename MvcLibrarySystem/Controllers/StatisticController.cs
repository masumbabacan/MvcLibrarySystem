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
        MovementManager movementManager = new MovementManager(new EfMovementDal());
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
            //Sistemdeki Üye Sayısı
            var userCount = userManager.GetAll().Count();
            ViewBag.usrCount = userCount;

            //Sistemdeki Kitap Sayısı
            var bookCount = bookManager.GetAll().Count();
            ViewBag.bookCount = bookCount;

            //Emanette olan kitap sayısı
            var depositBookCount = bookManager.GetAllDepositBook().Count();
            ViewBag.depositBookCount = depositBookCount;

            //Kasaya Giren Para Miktarı
            var cashAmount = context.Penalties.Where(x => x.Money > 0).Sum(x => x.Money);
            ViewBag.cashAmount = cashAmount;

            //En Çok Kitabı Olan Yayınevi
            var publishingHouseWithTheMostBooks = bookManager.GetAll().GroupBy(x => x.Publisher).OrderByDescending(z => z.Count()).Select(y=> new {y.Key}).FirstOrDefault();
            ViewBag.publishingHouseWithTheMostBooks = publishingHouseWithTheMostBooks;

            //En Aktif Personel
            var mostActiveStaff = movementManager.GetAll().GroupBy(x => x.Employee.FirstName+" "+ x.Employee.LastName).OrderByDescending(z => z.Count()).Select(y => new { y.Key }).FirstOrDefault();
            ViewBag.mostActiveStaff = mostActiveStaff;

            //En Çok Okunan Kitap
            var mostReadBook = movementManager.GetAll().GroupBy(x => x.Book.BookName).OrderByDescending(z => z.Count()).Select(y => new { y.Key }).FirstOrDefault();
            ViewBag.mostReadBook = mostReadBook;

            //En Çok Kitabı Olan Yazar
            var MostWriterBook = bookManager.GetAll().GroupBy(x => x.Writer.FirstName + " " + x.Writer.LastName).OrderByDescending(z => z.Count()).Select(y => new { y.Key }).FirstOrDefault();
            ViewBag.MostWriterBook = MostWriterBook;

            //En Aktif Personel
            var mostActiveUser = movementManager.GetAll().GroupBy(x => x.User.FirstName + " " + x.User.LastName).OrderByDescending(z => z.Count()).Select(y => new { y.Key }).FirstOrDefault();
            ViewBag.mostActiveUser = mostActiveUser;

            return View();
        }
    }
}
