using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.NET.FINAL.Controllers
{
    public class JobsController : Controller
    {
        // GET: Jobs
       
      public ActionResult JobList() 
        {
            return View();
        }
        public ActionResult JobGrid()
        {
            return View();
        }
        public ActionResult JobDetails()
        {
            return View();
        }
        public ActionResult JobDetails2() 
        {
            return View();
        }
       
    }
}