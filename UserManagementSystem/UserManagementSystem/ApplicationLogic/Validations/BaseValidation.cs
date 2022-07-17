using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserManagementSystem.ApplicationLogic.Validations
{
    class BaseValidation
    {

        public  bool IsLengthThreeThirty(string word)
        {
            string pattern = @"[a-zA-Z]{3,30}";
            Regex regex = new Regex(pattern);


            return regex.IsMatch(word);
        }


        public  bool IsLengthTenThirty(string word)
        {
            string pattern = @"[a-zA-Z]{10,30}";
            Regex regex = new Regex(pattern);


            return regex.IsMatch(word);
        }

        public bool IsFirstLetterUpper(string word)
        {
            string pattern = @"^[A-Z]";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(word);
        }

        public bool IsNumberExist(string word)
        {
            string pattern = @"[0-9]";
            Regex regex = new Regex(pattern);

            return regex.IsMatch(word);
        }

        public bool IsOnlyNumberAndLetter(string word)
        {
            string pattern = @"[a-zA-Z0-9]";
            Regex regex = new Regex(pattern);

            return regex.IsMatch(word);
        }

        public bool IsOneLetterUpperAndLower(string word)
        {
            string firstpattern = @"[a-z]";
            string secondpattern = @"[A-Z]";

            Regex regex = new Regex(firstpattern);
            Regex secondRegex = new Regex(secondpattern);

            return regex.IsMatch(word) && secondRegex.IsMatch(word);
        }

       
    }
}
