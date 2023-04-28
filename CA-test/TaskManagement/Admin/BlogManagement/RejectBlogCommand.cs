using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Admin.MessageManagement.MessageService;
using TaskManagement.Common;
using TaskManagement.Contants;
using TaskManagement.Database.Models;
using TaskManagement.Database.Repositories;

namespace TaskManagement.Admin.BlogManagement
{
    public class RejectBlogCommand : BaseBlogModeration, ICommandHandler
    {
        public RejectBlogCommand(BlogRepository blogRepository)
            : base(blogRepository) { }

        public void Handle()
        {
            Blog blog = ValidateAndGetBlog();
            if (blog is null) return;

            blog.Status = BlogStatus.Approved;

            MessageSevives messageSevives = new MessageSevives();
            messageSevives.SendBlogRejectedMessage(blog);
        }
    }
}
