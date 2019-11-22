using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.NET.FINAL.Controllers
{
    public class EmployersController : Controller
    {
        // GET: Employers
     
        public ActionResult EmployersList() 
        {
            return View();
        }
        public ActionResult CompanyDetail() 
        {
            return View();
        }
    }
}