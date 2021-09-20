﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;

namespace DataAccessLayer.Repositories
{
    public class BlogRepository : IBlogDal
    {
       

        public void AddBlog(Blog blog)
        {
            using var db = new Context();
            db.Add(blog);
            db.SaveChanges();
        }

        public void DeleteBlog(Blog blog)
        {
            using var db = new Context();
            db.Remove(blog);
            db.SaveChanges();
        }

        public Blog GetById(int id)
        {
            using var db = new Context();
            return db.Blogs.Find(id);
        }

        public List<Blog> ListAllBlog()
        {
            using var db = new Context();
            return db.Blogs.ToList();
        }

        public void UpdateBlog(Blog blog)
        {
            using var db = new Context();
            db.Update(blog);
            db.SaveChanges();
        }
    }
}
