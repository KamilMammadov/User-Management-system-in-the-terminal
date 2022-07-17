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
        public bool IsName(string name)
        {
            return IsLength(name) && !IsNumberExist(name) && IsFirstLetterUpper(name);
        }

        public bool IsSurname(string surname)
        {
            return IsLength(surname) && !IsNumberExist(surname) && IsFirstLetterUpper(surname);
        }



        public bool IsEmailValid(string email)
        {
            return IsLength(email) && IsOnlyNumberAndLetter(email) && IsEmailDomain(email);
        }


        public bool IsEmailDomain(string email)
        {
            string pattern = @"^[a-z]+[\w.]+@code+[.]+edu+[.]+az";
            Regex regex = new Regex(pattern);

            return regex.IsMatch(email);
        }



        public bool IsEmailUnique(string email)
        {
            foreach (User user in UserRepository.Users)
            {
                if (user.Email == email)
                {
                    return false;
                }
            }
            return true;
        }

        public bool IsPassword(string password)
        {
            return IsOneLetterUpperAndLower(password) && IsNumberExist(password);
        }




    }
}
