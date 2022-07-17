using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagementSystem.Database.Models;

namespace UserManagementSystem.Database.Repository
{
    class UserRepository
    {

        public static List<User> Users { get; set; } = new List<User>()
        {
            new User("Super","Admin","admin@gmail.com","123321")
        };


        public static User Add(string name, string surname, string email, string password)
        {
            User firstUser = new User(name, surname, email, password);
            Users.Add(firstUser);
            Console.WriteLine("You successfully registered, now you can login with your new account!");
            return firstUser;
        }

        public static List<User> GetAll()
        {
            return Users;
        }
    }
}
