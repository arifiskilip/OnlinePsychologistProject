using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface ISpecialtyService
    {
        List<Specialty> GetAll();
        Specialty GetById(int id);
        void Add(Specialty specialty);
        void Delete(Specialty specialty);
        void Update(Specialty specialty);
    }
}
