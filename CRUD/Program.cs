using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User();

            user.Name = "Juan Nieves";
            user.Dni = 10123321;
            user.email = "jnieves@outlook.es";

            User user2 = new User();
            user2.Name = "Pablo Sanchez";
            user2.Dni = 23456654;
            user2.email = "psanchez@outlook.es";

            user.Add(user);
            user2.Add(user2);

            List<User> List_Users = user.List();
            foreach(User u in List_Users)
            {
                Console.WriteLine(u.Name);
            }
        }
    }
}
