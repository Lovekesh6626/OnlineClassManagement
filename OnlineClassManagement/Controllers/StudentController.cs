using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineClassManagement.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Notification()
        {
            return View();
        }
        public ActionResult Profile()
        {
            return View();
        }
        public ActionResult Message()
        {
            return View();
        }
        public ActionResult MyProfile()
        {
            return View();
        }
    }
}