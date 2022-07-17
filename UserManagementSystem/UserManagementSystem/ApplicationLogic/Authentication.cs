using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagementSystem.ApplicationLogic.Validations;

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
                Console.WriteLine("Name is not correct ! Please enter name again : ");
                name = Console.ReadLine();
            }

            Console.WriteLine("Enter Surname: ");
            string surname = Console.ReadLine();
            while (!UserValidation.IsSurname(surname))
            {
                Console.WriteLine("Surname is not correct ! Please enter surname again : ");
                surname = Console.ReadLine();
            }

            Console.WriteLine("enter email:");
            string email = Console.ReadLine();
            while (!UserValidation.IsEmailValid(email) & !UserValidation.IsEmailUnique(email))
            {

                if (!UserValidation.IsEmailValid(email))
                {
                    Console.WriteLine("Email duzgun deyil");
                }
                else if (!UserValidation.IsEmailUnique(email))
                {
                    Console.WriteLine("Email is already exist");
                }

                email = Console.ReadLine();
            }

            Console.WriteLine("Enter password");
            string password = Console.ReadLine();
            
            Console.WriteLine("Please enter password again for security");
            string checkpassword = Console.ReadLine();

            while (!UserValidation.IsPassword(password) & !UserValidation.IsCheckPassword(password, checkpassword))
            {
                Console.WriteLine("Please enter password again");
                password = Console.ReadLine();
                Console.WriteLine("Please enter password again for security");
                checkpassword = Console.ReadLine();          
            }




        }



    }
}
