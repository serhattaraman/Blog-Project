using BusinessLayer.Concrete;
using EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCBlog.Controllers
{
    public class AuthorController : Controller
    {
        // GET: Author
        BlogManager blogmanager= new BlogManager();
        AuthorManager authormanager = new AuthorManager();
        public PartialViewResult AuthorAbout(int id)
        {
            var authordetail= blogmanager.GetBlogByID(id);
            return PartialView(authordetail);
        }

        //Yazarın En Çok Okunan 3 Yazısı
        public PartialViewResult AuthorPopularPost(int id)
        {
            var blogauthorid=blogmanager.GetAll().Where(x=> x.BlogId==id).Select(y=> y.AuthorId).FirstOrDefault();
            ViewBag.blogauthorid = blogauthorid;

            var authorblogs = blogmanager.GetBlogByAuthor(blogauthorid);
            return PartialView(authorblogs);
        }

        //Yazar Listesi
        public ActionResult AuthorList()
        {
            var authorlist= authormanager.GetAll();
            return View(authorlist);
        }

        [HttpGet]
        public ActionResult AddAuthor()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddAuthor(Author p)
        {
            authormanager.AddAuthorBl(p);
            return RedirectToAction("AuthorList");
        }

        [HttpGet]
        public ActionResult AuthorEdit(int id)
        {
            Author author = authormanager.FindAuthor(id);

            return View(author);
        }

        [HttpPost]
        public ActionResult AuthorEdit(Author p)
        {
            authormanager.EditAuthor(p);
            return RedirectToAction("AuthorList");
        }
    }
}