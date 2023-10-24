using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask20
{

    internal class Company
    {
        public static int Id { get; set; }
        public string Name { get; set; }
        List<User> users = new List<User>();
        public Company(string name)
        {
            Name = name;
            Id++;
        }
        public void AddUser(User user)
        {
            users.Add(user);
        }
        public User GetUserId(int id)
        {
            try
            {
                foreach (User user in users)
                {
                    if (user.Id == id)
                    {
                        return user;
                    }
                }
            }
            catch (DataNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }
        public List<User> GetAllUsers()
        {
            return users;
        }

        public void DeleteUser(int id)
        {
            try
            {
              




                //foreach (User user in users)
                //{
                //    if (user.Id == id)
                //    {
                //        users.Remove(user);
                //    }
                
            }
            catch (DataNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }

    }

        public void UpdateUser(User person)
        {
            User newUser = null;
            try
            {
                foreach (User user in users)
                {
                    if (user.Id == person.Id)
                    {
                        newUser.Name = user.Name;
                        newUser.Surname = user.Surname;
                        newUser.Username = user.Username;
                        newUser.Id = user.Id;
                    }
                }
            }
            catch (DataNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}


   