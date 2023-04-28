using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Admin.ShowUser;
using TaskManagement.Admin.UserManagement;
using TaskManagement.Common;
using TaskManagement.Database;

namespace TaskManagement.Admin
{
    public class AdminDashboard : IDashboard
    {
        public void Introduction()
        {
            Console.WriteLine("Hello dear admin");

            while (true)
            {
                string command = Console.ReadLine()!;

                switch (command)
                {
                    case "/show-users":
                        ShowUsersCommand showUsersCommand = new ShowUsersCommand();
                        showUsersCommand.Handle();
                        break;
                    case "/show-user-by-email":
                        ShowUserByEmailCommand showUserByEmailCommand = new ShowUserByEmailCommand();
                        showUserByEmailCommand.Handle();
                        break;
                    case "/show-user-by-id":
                        ShowUserByIdCommand showUserByIdCommand = new ShowUserByIdCommand();
                        showUserByIdCommand.Handle();
                        break;
                    case "/add-user":
                        AddUserCommand addUserCommand = new AddUserCommand();
                        addUserCommand.Handle();
                        break;
                    case "/logout":
                        Console.WriteLine("Bye-bye");
                        return;
                    default:
                        Console.WriteLine("Invalid command, pls try again");
                        break;
                }
            }
        }
    }
}
