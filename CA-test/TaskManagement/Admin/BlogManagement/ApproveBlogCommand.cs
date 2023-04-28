using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Admin.MessageManagement.MessageService;
using TaskManagement.Common;
using TaskManagement.Contants;
using TaskManagement.Database.Models;
using TaskManagement.Database.Repositories;
using TaskManagement.Services;

namespace TaskManagement.Admin.BlogManagement
{
    public class ApproveBlogCommand : BaseBlogModeration, ICommandHandler
    {
        public ApproveBlogCommand(BlogRepository blogRepository)
        : base(blogRepository) { }

        public void Handle()
        {
            Blog blog = ValidateAndGetBlog();
            if (blog is null) return;

            blog.Status = BlogStatus.Approved;

            MessageSevives messageSevives = new MessageSevives();
            messageSevives.SendBlogApprovedMessage(blog);
        }

    }
}
