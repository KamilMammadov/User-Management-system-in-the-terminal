using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using UserManagementSystem.Database.Models;
using UserManagementSystem.Database.Repository;

namespace UserManagementSystem.ApplicationLogic.Validations
{
    class UserValidation : BaseValidation
    {
        public static bool IsName(string name)
        {
            return IsLength(name) && !IsNumberExist(name) && IsFirstLetterUpper(name);
        }

        public static bool IsSurname(string surname)
        {
            return IsLength(surname) && !IsNumberExist(surname) && IsFirstLetterUpper(surname);
        }


        
        public static bool IsEmailValid(string email)
        {
            return (IsEmailLength(email) && IsOnlyNumberAndLetter(email) && IsEmailDomain(email) && IsEmailUnique(email));
        }


        public static bool IsEmailDomain(string email)
        {
            string pattern = @"^[a-z]+[\w.]+@code+[.]+edu+[.]+az";
            Regex regex = new Regex(pattern);

            return regex.IsMatch(email);
        }



        public static bool IsEmailUnique(string email)
        {
            foreach (User user in UserRepository.Users)
            {
                if (user.Email == email)
                {
                    Console.WriteLine("This Mail Is Used");
                    return false;
                }
            }

            return true;
        }

        public static bool IsPassword(string password)
        {
            if (IsOneLetterUpperAndLower(password) && IsNumberExist(password) && IsPasswordLength(password))
            {
                return true;
            }

            Console.WriteLine("Password must have 1 capital letter , 1 lowercase letter and you cant use symbols in your password");
            return false;
        }


        public static bool IsCheckPassword(string password,string checkPassword)
        {
            if (password==checkPassword)
            {   
                return true;
            }
            Console.WriteLine("Security password is not correct!");
            return false;
        }
        
        public static bool IsEmailLength(string email)
        {
            
                string pattern = @"[a-zA-Z]{10,30}";
                Regex regex = new Regex(pattern);


                return regex.IsMatch(email);
            
        }

        public static bool IsPasswordLength(string word)
        {
            string pattern = @"[a-zA-Z]{8,}";
            Regex regex = new Regex(pattern);


            return regex.IsMatch(word);
        }

        ////////////////////////////////////////////////////////////\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
        ///////////////////////////////////////////////         LOGIN PART      \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\


        public static bool IsLogin(string email,string password)
        {
            foreach (User user in UserRepository.Users)
            {
                if (user.Email==email && user.Password==password)
                {
                    return true;
                }           
            }
            return false;
        }

        

        


    }
}
