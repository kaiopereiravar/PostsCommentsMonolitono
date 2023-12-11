using PostsCommentsMonolitono.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PostsCommentsMonolitono.Repository.DAL
{
    public class HomeDAL
    {
        public List<TabPost> GetAllPosts()
        {
            using (var _ctx = new DesafioPostsComentariosEntities())
            {
                var posts = _ctx.TabPosts.ToList();
                return posts;
            }
        }
        public bool InsertComment(TabPost tabPost)
        {
            using (var _ctx = new DesafioPostsComentariosEntities())
            {
                _ctx.TabPosts.Add(tabPost);
                _ctx.SaveChanges();
                return true;
            }
        }
        public bool DeleteComment(int id)
        {
            using (var _ctx = new DesafioPostsComentariosEntities())
            {
                var comment = _ctx.TabPosts.FirstOrDefault(x => x.id == id);
                _ctx.TabPosts.Remove(comment);
                _ctx.SaveChanges();
                return true;
            }
        }

    }
}