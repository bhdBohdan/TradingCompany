using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradingCompany.DAL.Concrete;
using TradingCompany.Dto;

namespace TradingCompany
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to TradingCompany!");
            char c = 's';

            while (c != 'q' && c != 'Q')
            {
                switch (c)
                {
                    case '1':
                        Console.WriteLine("You chose to get all Users.");

                        GetAllUsers();
                        break;
                    case '2':
                        Console.WriteLine("You chose to get all Roles.");
                        break;
                    case '3':
                        Console.WriteLine("You chose to insert a user.");

                        InsertUser();
                        break;
                    case 'q':
                        Console.WriteLine("You chose to Quit.");
                        break;
                    default:
                        if (c != 's')
                        {
                            Console.WriteLine("Invalid choice. Please try again.");
                        }
                        break;
                }

                Console.WriteLine("\nType:\n1 to get all Users;\n2 to get all Roles;\n3 to insert a user;\nq to Quit.");

                c = Console.ReadLine()[0];
            }
        }

        private static void InsertUser()
        {
            var dal = new UserDAL();

            var oldUser = new User
            {
               
            };

            var newUser = dal.Register(oldUser);

            //Console.WriteLine($"Inserted User: {newUser.UserId}: {newUser.Title} - {newUser.Role.Name} - {newUser.ReleaseDate.ToShortDateString()}");
        }

        private static void GetAllUsers()
        {
            var dal = new UserDAL();
            var users = dal.GetAll();

            foreach (var user in users)
            {
                Console.WriteLine($"{user.UserId}: {user.FirstName} - {user.Role.RoleName} - {user.RegistrationDate.ToShortDateString()}");
            }
        }
    }
}
