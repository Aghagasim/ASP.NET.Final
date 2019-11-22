using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.NET.FINAL.Controllers
{
    public class CandidatesController : Controller
    {
        // GET: Candidates
       
        public ActionResult CandidatesListing() 
        {
            return View();
        }
        public ActionResult CandidatesProfile() 
        {
            return View();
        }
        public ActionResult CreateResume() 
        {
            return View();
        }
    }
}