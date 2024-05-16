using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRUD.Models;

namespace CRUD.ViewModels
{
    public class UserListViewModel
    {
        public List<User> Users { get; set;}

        public UserListViewModel()
        {
            SetUsers();
        }

        private void SetUsers()
        {
            Users = new()
            {
                new(){ Id = 1, Name = "John", LastName = "Doe", UserName = "jdoe", Password = "password1" },
                new(){ Id = 2, Name = "Jane", LastName = "Smith", UserName = "jsmith", Password = "password2" },
                new(){ Id = 3, Name = "Michael", LastName = "Johnson", UserName = "mjohnson", Password = "password3" },
                new(){ Id = 4, Name = "Emily", LastName = "Davis", UserName = "edavis", Password = "password4" },
                new(){ Id = 5, Name = "Chris", LastName = "Brown", UserName = "cbrown", Password = "password5" },
                new(){ Id = 6, Name = "Jessica", LastName = "Miller", UserName = "jmiller", Password = "password6" },
                new(){ Id = 7, Name = "David", LastName = "Wilson", UserName = "dwilson", Password = "password7" },
                new(){ Id = 8, Name = "Sarah", LastName = "Moore", UserName = "smoore", Password = "password8" },
                new(){ Id = 9, Name = "Daniel", LastName = "Taylor", UserName = "dtaylor", Password = "password9" }
            };
        }

        public void AddUser()
        {
            System.Console.Write("enter name: ");
            string name = Console.ReadLine();
            System.Console.Write("enter last name: ");
            string lastName = Console.ReadLine();
            System.Console.Write("enter username: ");
            string userName = Console.ReadLine();
            System.Console.Write("enter password: ");
            string password = Console.ReadLine();

            var user = new User()
            {
                Id = Users.Count + 1,
                Name = name,
                LastName = lastName,
                UserName = userName,
                Password = password
            };

            if(user != null)
            {
                Users.Add(user);
                ShowOperationSuccessful();
            }
        }

        public void GetAll()
        {
            Console.WriteLine();
            foreach(var user in Users)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"{user.Id} {user.Name} {user.LastName} {user.UserName} {user.Password}");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        public void EditUser()
        {
            Console.Write("enter user id: ");
            int id = Convert.ToInt32(Console.ReadLine());
            
            var user = Users.Find(x => x.Id == id);

            if(user != null)
            {
                Console.Write("enter new name: ");
                string name = Console.ReadLine();

                Console.Write("enter new last name: ");
                string lastName = Console.ReadLine();

                Console.Write("enter new username: ");
                string userName = Console.ReadLine();

                Console.Write("enter new password: ");
                string password = Console.ReadLine();

                user.Name = name;
                user.LastName = lastName;
                user.UserName = userName;
                user.Password = password;

                ShowOperationSuccessful();
            }
            else
            {
               ShowOperationFailed();
            }
            
        }

        public void DeleteUser()
        {
            Console.Write("enter user id: ");
            int id = Convert.ToInt32(Console.ReadLine());

            var user = Users.Find(x => x.Id==id);

            if(user != null)
            {
                Users.Remove(user);
                ShowOperationSuccessful();
            }
            else
            {
                ShowOperationFailed();
            }
        }

        private void ShowOperationSuccessful()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine("Operation successful");
            Console.ForegroundColor = ConsoleColor.White;
        }

        private void ShowOperationFailed()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine("Such id does not exist");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}