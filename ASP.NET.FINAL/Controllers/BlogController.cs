using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.NET.FINAL.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
       public ActionResult BlogList() 
        {
            return View();
        }
        public ActionResult BlogDetails() 
        {
            return View();
        }
        public ActionResult BlogGrid() 
        {
            return View();
        }
            
    }
}