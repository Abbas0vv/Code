using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Common;
using TaskManagement.Contants;
using TaskManagement.Database.Models;
using TaskManagement.Database.Repositories;
using TaskManagement.Services;

namespace TaskManagement.Admin.MessageManagement.MessageService
{
    public class MessageSevives
    {
        public void SendBlogApprovedMessage(Blog blog)
        {
            string approvedMessage = BlogMessageMaker(BlogMessage.APROVED_MESSAGE_TEMPLATE, blog);
            SendMessage(approvedMessage, UserService.CurrentUser, blog.Owner);
        }
        public void SendBlogRejectedMessage(Blog blog)
        {
            string rejectedMessage = BlogMessageMaker(BlogMessage.REJECTED_MESSAGE_TEMPLATE, blog);
            SendMessage(rejectedMessage, UserService.CurrentUser, blog.Owner);
        }

        public string BlogMessageMaker(string messageTemplate, Blog blog)
        {
            return messageTemplate
                  .Replace("{firstname}", blog.Owner.Name)
                  .Replace("{lastname}", blog.Owner.LastName)
                  .Replace("{blog number}", blog.Id.ToString());
        }

        public void SendMessage(string message, User sender, User receiver)
        {
            MessageRepository messageRepository = new MessageRepository();
            Message messageObj = new Message(message, sender, receiver);
            messageRepository.Insert(messageObj);
        }
    }
}