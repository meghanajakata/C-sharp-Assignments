using System;
using System.ComponentModel;
using DataAccessLayer;

namespace BusinessLayer
{
    

    public class SignUp
    {
        DataLayer dataObject = new DataLayer(); 
        public void AddUser(string username, string email, string password)
        {
            
            bool Signed = dataObject.AddUser(username, email, password);
            if (Signed)
            {
                Console.WriteLine("\nWELCOME!!!!!! \n");
            }
            else
            {
                Console.WriteLine("\nThe user has already signed In\n");
            }

        }

        public void Userss()
        {
           List<Users> allusers =  dataObject.GetUsers();
            foreach(Users user in allusers)
            {
                Console.WriteLine(user.Name + " " + user.Email + " " + user.Password);
            }
            Console.WriteLine("In userss method");
        }

    }

    public class Login
    {
        DataLayer dataObject = new DataLayer();
        public void LoginUser(string name , string password)
        {
            bool LoggedIn = dataObject.LoginUser(name, password);
            if (LoggedIn) 
            {
                Console.WriteLine("\nWELCOME!!\n");
            }
            else
            {
                Console.WriteLine("\nInvalid Login!!!\n");
            }
        }
    }
}