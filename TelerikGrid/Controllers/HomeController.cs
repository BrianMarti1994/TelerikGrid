using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TelerikGrid.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //Create List Variable 

            List<Student> list = new List<Student>();

            //Initialize  Entity

            using (SchoolEntities dc = new SchoolEntities())
            {
                list = dc.Students.OrderBy(a => a.StudentID).ToList();
            }
            return View(list);
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