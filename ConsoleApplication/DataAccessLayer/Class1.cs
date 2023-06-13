using System;


namespace DataAccessLayer
{
    public class Users
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

    }
    public class DataLayer
    {
        public static List<Users> userDetails = new List<Users>();
        public bool AddUser(string name, string email, string password)
        {
            if (SignedUser(name, email) == false)
            {
                userDetails.Add(new Users { Name = name, Email = email, Password = password });
                return true;
            }
            return false;
        }

        public bool SignedUser(string name ,string email)
        {
            Users u = userDetails.Find(u =>  u.Name == name );
            if (u == null)
            {
                u = userDetails.Find(u => u.Email == email);
                if (u == null)
                {
                    return false;
                }
            }
            return true;
        }
        public List<Users> GetUsers()
        {
            return userDetails;
        }

        public bool IsUserLogged(string name, string password)
        {
            Users u = userDetails.Find(u => u.Name == name );
            if(u != null)
            {
                if(u.Password == password)
                {
                    return true;
                }
            }
            return false;
        }

        public bool LoginUser(string name, string password)
        {
            bool isUser = IsUserLogged(name, password);
            return isUser;
        }
    }
}