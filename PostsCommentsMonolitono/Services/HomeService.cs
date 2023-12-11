using PostsCommentsMonolitono.Repository;
using PostsCommentsMonolitono.Repository.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ApplicationServices;
using System.Web.Mvc;

namespace PostsCommentsMonolitono.Services
{
    public class HomeService
    {
        private readonly HomeDAL homeDAL = new HomeDAL();

        public List<TabPost> GetAllPosts()
        {
            var posts = homeDAL.GetAllPosts();
            return posts;
        }
        public bool InsertComment(TabPost tabPost)
        {
            var posts = homeDAL.InsertComment(tabPost);
            return posts;
        }
        public bool DeleteComment(int id)
        {
            homeDAL.DeleteComment(id);
            return true;
        }
    }
}