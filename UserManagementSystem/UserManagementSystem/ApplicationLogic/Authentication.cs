using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagementSystem.ApplicationLogic.Validations;
using UserManagementSystem.Database.Repository;

namespace UserManagementSystem.ApplicationLogic
{
    class Authentication
    {
        public static void Register()
        {
            Console.WriteLine("Enter name : ");
            string name = Console.ReadLine();

            while (!UserValidation.IsName(name))
            {
                Console.WriteLine("The name you entered is incorrect, make sure the name contains only letters, the first letter is capitalized," +
                    " and the length is greater than 3 and less than 30.\n Please enter name again : ");
                name = Console.ReadLine();
            }

            Console.WriteLine("Enter Surname: ");
            string surname = Console.ReadLine();
            while (!UserValidation.IsSurname(surname))
            {
                Console.WriteLine("The name you entered is incorrect, make sure the name contains only letters, the first letter is capitalized, " +
                    "and the length is greater than 3 and less than 30. \n Please enter surname again : ");
                surname = Console.ReadLine();
            }

            Console.WriteLine("enter email:");
            string email = Console.ReadLine();
            while (!(UserValidation.IsEmailValid(email) && UserValidation.IsEmailUnique(email)))
            {              
                email = Console.ReadLine();
            }

            Console.WriteLine("Enter password");
            string password = Console.ReadLine();

            Console.WriteLine("Please enter password again for security");
            string checkpassword = Console.ReadLine();

            while (!(UserValidation.IsPassword(password) && UserValidation.IsCheckPassword(password, checkpassword)))
            {
                Console.WriteLine("Please enter password again");
                password = Console.ReadLine();
                Console.WriteLine("Please enter password again for security");
                checkpassword = Console.ReadLine();
            }

            UserRepository.Add(name, surname, email, password);
            Console.WriteLine("You successfully registered, now you can login with your new account!");
        }

        public static void Login()
        {
            Console.WriteLine("Please enter email");
            string email = Console.ReadLine();
            Console.WriteLine("Please enter password");
            string password = Console.ReadLine();


            if (UserValidation.IsLogin(email,password))
            {

                if (email == "admin@gmail.com" && password == "123321")
                {
                    Console.Write("Welcome dear ");
                    Console.WriteLine(UserValidation.GetUser(email));

                    Console.WriteLine("/show-users");
                    string command = Console.ReadLine();

                    if (command == "/show-users")
                    {
                        UserRepository.GetAll();
                    }
                }
                else
                {
                    Console.Write("Welcome ");
                    UserValidation.GetUser(email);
                }
            }
            else
            {
                Console.WriteLine("Email or Password is wrong !");
            }


        }


    }
}
