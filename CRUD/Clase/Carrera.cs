
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD
{
    public class Carrera : ICarrera, IID, IABMC<Carrera>
    {
        public string Name { get; set; }
        public string Sigla { get; set; }
        public string Degree { get; set; }
        public int Duration { get; set; }
        public int ID { get; set; }

        private static int Last_ID = 1;

        private static List<Carrera> List_Carrera = new List<Carrera>();


        public Carrera FindBySigla(string sigla)
        {
            return List_Carrera.FirstOrDefault(c => c.Sigla == sigla);
        }
 
        public List<Carrera> List()
        {
            return List_Carrera;
        }

        public bool NameExists(string nombre)
        {
            return List_Carrera.Any(c => c.Name == nombre);
        }

        public bool SiglaExists(string sigla)
        {
            return List_Carrera.Any(c => c.Sigla == sigla);
        }

        public void Modify(Carrera data)
        {
            Carrera carrera = Find(data.ID);
            if (carrera != null)
            {
                carrera.Name = data.Name;
                carrera.Degree = data.Degree;
                carrera.Duration = data.Duration;
                carrera.Sigla = data.Sigla;
            }
            else
            {
                throw new Exception("La carrera que deseas editar, no se encuentra disponible");
            }
            

        }

        public void Add(Carrera data)
        {
                if (NameExists(data.Name)) throw new Exception("Ya hay otra carrera con el nombre ingresado");
                if (SiglaExists(data.Sigla)) throw new Exception("Ya hay otra carrera con la sigla ingresada");

                data.ID = Last_ID;
                Last_ID++;
                List_Carrera.Add(data);

        }

        public void Erase(Carrera data)
        {
            foreach (Carrera c in List_Carrera)
            {
                if (c.Name == data.Name)
                {
                    List_Carrera.Remove(c);
                }
                throw new Exception("No se puede eliminar la carrera con el nombre mencionado: " + data.Name);
            }
        }

       public Carrera Find(int ID)
        {
            foreach (Carrera c in List_Carrera)
            {
                if (c.ID == ID) return c;
            }
            throw new Exception("No se encuentra la carrera con la ID escrita: " + ID);
        }
    } 
}

