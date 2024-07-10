
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD
{
    internal interface IUser
    {
        string Name { get; set; }

        int Dni { get; set; }

        String email { get; set; }

        bool DniExist(int Dni);

        bool EmailExist(string email);

        User FindByEmail(string email);

        User FindByDni(int Dni);

        List<User> List();
    
    }
}
