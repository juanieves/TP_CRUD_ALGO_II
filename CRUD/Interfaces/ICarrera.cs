using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD
{
    public interface ICarrera
    {
        string Name { get; set; }
        string Sigla { get; set; } 
        string Degree { get; set; }
        int Duration { get; set; }

        Carrera FindBySigla(string sigla);

        List<Carrera> List();

        bool NameExists(string name);

        bool SiglaExists(string sigla);
    }
}
