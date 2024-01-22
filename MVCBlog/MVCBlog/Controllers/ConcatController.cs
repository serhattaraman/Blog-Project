using BusinessLayer.Concrete;
using EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCBlog.Controllers
{
    public class ConcatController : Controller
    {
        // GET: Concat
        ConcatMAnager cm = new ConcatMAnager();
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult SendMessage()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SendMessage(Concat p)
        {
            cm.BlConcatAdd(p);
            return View();
        }

    }
}