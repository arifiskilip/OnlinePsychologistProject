using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IPsychologistService
    {
        List<Psychologist> GetAll();
        Psychologist GetById(int id);
        void Add(Psychologist psychologist);
        void Delete(Psychologist psychologist);
        void Update(Psychologist psychologist);
    }
}
