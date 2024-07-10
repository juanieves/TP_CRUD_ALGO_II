
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD
{
    internal class User : IUser, IABMC<User>
    {
        static List<User> List_User = new List<User>();

        private static int Last_ID = 1;

        public int ID { get; set; }
        public string Name { get; set; }
        public int Dni { get; set; }
        public string email { get; set; }


        public List <User> List()
        {
            return List_User;
        }

        public void Add(User user)
        {
            if (EmailExist(user.email)) throw new Exception("Ya hay otro usuario con el email ingresado");
            if (DniExist(user.Dni)) throw new Exception("Ya hay otro usuario con el dni ingresado");

            user.ID = Last_ID;
            Last_ID++;
            List_User.Add(user);

        }

        public bool DniExist(int Dni)
        {
            foreach (User u in List_User)
            {
                if (u.Dni == Dni) return true;
            }
            return false;
        }

        public bool EmailExist(string email)
        {
            {
                foreach (User u in List_User)
                {
                    if (u.email == email) return true;
                }
                return false;
            }
        }

        public void Erase(User user)
        {
            foreach (User u in List_User)
            {
                if (u.Dni == user.Dni)
                {
                    List_User.Remove(u); return;
                }
                throw new Exception("No se puede eliminar el usuario con el ID mencionado: " + user.Dni);
            }

        }

        public User Find(int ID)
        {
            foreach (User u in List_User)
            {
                if (u.ID == ID) return u;
            }
            throw new Exception("No se encuentra el usuario con el ID: " + ID);
        }

        public User FindByDni(int Dni)
        {
            foreach (User u in List_User)
            {
                if (u.Dni == Dni) return u;
            }
            throw new Exception("No se encuentra el usuario con el DNI ingresado: " + Dni);
        }

        public User FindByEmail(string email)
        {
            foreach (User u in List_User)
            {
                if (u.email == email) return u;
            }
            throw new Exception("No se encuentra el usuario con el email ingresado: " + email);
        }


        public void Modify(User user)
        {
            User u =Find(user.ID);
            if (u == null) throw new Exception("El usuario que desea modificar no existe en la lista");
            u.Name = user.Name;  
        }



    }
}
