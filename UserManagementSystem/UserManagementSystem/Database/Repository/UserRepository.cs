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
            
            return firstUser;
        }

        public static void GetAll()
        {
            foreach (User user in Users)
            {
                Console.WriteLine(user.Id+" "+ user.Name+" "+ user.Surname+" "+user.Email+" "+user.Password+ "   "  + user._registerTime);
            }
        }

        public static string GetUser(string email)
        {
            foreach (User user in Users)
            {
                if (user.Email == email)
                {
                    return $"{user.Id} {user.Name} {user.Surname}  Email : {user.Email} Password :  {user.Password} Register Time : {user._registerTime}";
                }
            }
            return "You are not admin";
        }
    }
}
