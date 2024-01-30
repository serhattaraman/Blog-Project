using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer.Concrete;
using EntitiyLayer.Concrete;

namespace MVCBlog.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        AboutManager abm = new AboutManager();
        public ActionResult Index()
        {
            var aboutcontent= abm.GetAll();
            return View(aboutcontent);
        }

        public PartialViewResult Footer()

        {
            

           var aboutcontentlist= abm.GetAll();
            return PartialView(aboutcontentlist);
        }

        public PartialViewResult MeetTheTeam()
        {
            AuthorManager authorman = new AuthorManager();
            var authorlist = authorman.GetAll();
            return PartialView(authorlist);
        }

        [HttpGet]
        public ActionResult UpdateAboutList()
        {
            var aboutlist= abm.GetAll();
            return View(aboutlist);
        }

        [HttpPost]
        public ActionResult UpdateAbout(About p)
        {
           abm.UpdateAboutBm(p);
            return RedirectToAction("UpdateAboutList");
        }

    }
}