using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinaryCrud.Model
{
    public interface IPetRepository
    {
         void Add(Pet pet);
        void Edit(Pet pet);
        void Delete(int id);
        IEnumerable<Pet> GetAll();
        IEnumerable<Pet> GetByValue(string value);
    }
}
