using System;
using UserManagementSystem.ApplicationLogic;

namespace UserManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Commands : ");
            Console.WriteLine("/register");
            Console.WriteLine("/login");
            Console.WriteLine("/exit");
            while (true)
            {
                string command = Console.ReadLine();

                if (command == "/register")
                {
                    Authentication.Register();

                }
                else if(command == "/login")
                {
                    Authentication.Login();
                }
                else if (command == "/exit")
                {
                    break;
                }
                else
                {
                    Console.WriteLine($"{command} is not a command");
                    
                }
            }
        }
    }
}
