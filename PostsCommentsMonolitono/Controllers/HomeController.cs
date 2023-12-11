using PostsCommentsMonolitono.Repository;
using PostsCommentsMonolitono.Repository.DAL;
using PostsCommentsMonolitono.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PostsCommentsMonolitono.Controllers
{
    public class HomeController : Controller
    {
        private readonly HomeService homeService = new HomeService();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Home()
        {
            var posts = homeService.GetAllPosts();
            return View(posts);
        }
        public ActionResult InsertComment()
        {
            TabPost tabPost = new TabPost()
            {
                Foto = Request.Form["titulo"],
                NomeConta = Request.Form["titulo"],
                Comentarios = Request.Form["comentarios"]
            };

            var postInserido = homeService.InsertComment(tabPost);
            if(postInserido == true)
            {
                return View();
            }

            return RedirectToAction("Index", "Home");
        }
        public ActionResult DeleteComment(int id)
        {
            var posts = homeService.DeleteComment(id);
            if (posts == true)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

    }
}