using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask20
{
    class Company
    {
        private int _id;
        public int Id { get; set; }
        public int Name { get; set; }
        public int MyProperty { get; set; }

        List<User> Users = new List<User>();


        public User GetUser(int id)
        {
            User user = null;
            foreach (User item in Users)
            {
                if (item.Id == id)
                {
                    user = item;
                }
            }

            if (user == null)
            {
                throw new DataNotFoundException();
            }
            return user;
        }




        public void GetAllUsers()
        {

            foreach (User user in Users)
            {
                Console.WriteLine(user);
            }

        }



        public void DeleteUser(int id)
        {



        }


        public void UpdateUser(User user)
        {
            try
            {
                User user2 = null;
                for (int i = 0; i < Users.Count; i++)
                {
                    if (Users[i].Id == user.Id)
                    {
                        user2 = Users[i];
                        break;
                    }

                    if (user2 != null)
                    {
                        user2.Name = user.Name;
                        user2.Surname = user.Surname;
                        user2.Username = user.Username;
                        user2.Id = user.Id;

                    }
                    else
                    {

                        throw new DataNotFoundException();
                    }


                }


            }
            catch (DataNotFoundException ex)
            {

            }

        }


    }
}

   