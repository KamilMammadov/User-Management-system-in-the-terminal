using System;

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

                }
                else if(command == "/login")
                {

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
