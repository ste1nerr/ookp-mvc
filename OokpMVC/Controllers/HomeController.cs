using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using OokpMVC.Data;
using OokpMVC.Models;

namespace OokpMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Registration()
        {
            return View();
        }

        public List<StuffModel> GetServiceItems(DatabaseContext dbContext)
        {
            return dbContext.Stuff.ToList();
        }

        public ActionResult SuccessPage()
        {
            List<StuffModel> items;

            using (DatabaseContext dbContext = new DatabaseContext())
            {
                items = GetServiceItems(dbContext);
            }
            return View(items);
        }

        [HttpPost]
        public ActionResult Index(AdminModel admin)
        {
            using (DatabaseContext dbContext = new DatabaseContext())
            {
                if (dbContext.Admin
                    .AsNoTracking()
                    .Any(x => (x.Login == admin.Login && x.Password == admin.Password))) return RedirectToAction("SuccessPage");
                else
                {
                    ViewBag.IsLoginFailed = true;
                    return View();
                }
            }
        }

        [HttpPost]
        public ActionResult Registration(AdminModel admin)
        {
            using (DatabaseContext dbContext = new DatabaseContext())
            {
                dbContext.Admin.Add(admin);
                dbContext.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}