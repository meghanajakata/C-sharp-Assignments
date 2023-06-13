// See https://aka.ms/new-console-template for more information
using BusinessLayer;
using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static bool userLogged = false;
        public static void Main(string[] args)
        {
            string name, email, password;
            while (true)
            {
                string option;
                Console.WriteLine("Please enter the required Option\n1.SignUp\n2.Login\n");
                option = Console.ReadLine();
                if (option == null)
                {
                    Console.WriteLine("Do enter an option\n");
                }
                switch(option)
                {
                    case "1":
                        Console.WriteLine("SignUp\n");
                        Console.WriteLine("Enter username");
                        name = Console.ReadLine();
                        Console.WriteLine("Enter email");
                        email = Console.ReadLine();
                        Console.WriteLine("Enter Password");
                        password = Console.ReadLine();
                        SignUp signUpObj = new SignUp();
                        signUpObj.AddUser(name, email, password);
                        signUpObj.Userss();
                        break;
                    case "2":
                        Console.WriteLine("Login\n");
                        Console.WriteLine("Enter username");
                        name = Console.ReadLine();
                        Console.WriteLine("Enter Password");
                        password = Console.ReadLine();
                        Login loginObj = new Login();
                        loginObj.LoginUser(name, password);

                        break;
                    default:
                        Console.WriteLine("Invalid Option\n");
                        break;
                }
            }

        }
    }
}

