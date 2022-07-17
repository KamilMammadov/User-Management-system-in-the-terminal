using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagementSystem.Database.Models
{
    class User
    {
        

        private static int _idCounter;
        public int Id { get; set; }
        public string  Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        
        public DateTime RegisterTime { get; set; }



        public User(string name,string surname,string email,string password)
        {
            Id = _idCounter;
            Name = name;
            Surname = surname;
            Email = email;
            Password = password;
            _idCounter++;
            RegisterTime = DateTime.Now;
        }

    }
}
