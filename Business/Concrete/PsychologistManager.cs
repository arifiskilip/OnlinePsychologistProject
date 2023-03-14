using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class PsychologistManager : IPsychologistService
    {
        private readonly IPsychologistDal _psychologistDal;

        public PsychologistManager(IPsychologistDal psychologistDal)
        {
            _psychologistDal = psychologistDal;
        }

        public void Add(Psychologist psychologist)
        {
            _psychologistDal.Add(psychologist);
        }

        public void Delete(Psychologist psychologist)
        {
            _psychologistDal.Delete(psychologist);
        }

        public List<Psychologist> GetAll()
        {
            return _psychologistDal.GetAll();
        }

        public Psychologist GetById(int id)
        {
            return _psychologistDal.Get(x => x.Id == id);
        }

        public void Update(Psychologist psychologist)
        {
            _psychologistDal.Update(psychologist);
        }
    }
}
