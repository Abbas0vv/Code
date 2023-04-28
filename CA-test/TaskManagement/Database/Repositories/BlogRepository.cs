using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Contants;
using TaskManagement.Database.Models;

namespace TaskManagement.Database.Repositories
{
    public class BlogRepository
    {
        public List<Blog> GetAllByStatus(BlogStatus status)
        {
            List<Blog> filteredBlogs = new List<Blog>(); 

            foreach (Blog blog in DataContext.Blogs)
            {
                if (blog.Status == status)
                {
                    filteredBlogs.Add(blog);
                }
            }

            return filteredBlogs;
        }

        public void Insert(Blog blog)
        {
            DataContext.Blogs.Add(blog);
        }

        public Blog GetById(int id)
        {
            foreach (Blog blog in DataContext.Blogs)
            {
                if (blog.Id == id)
                {
                    return blog;
                }
            }

            return default;
        }
    }
}
