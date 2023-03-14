using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Business.Concrete
{
    internal class SpecialtyManager : ISpecialtyService
    {
        private readonly ISpecialtyDal _specialtyDal;

        public SpecialtyManager(ISpecialtyDal specialtyDal)
        {
            _specialtyDal = specialtyDal;
        }

        public void Add(Specialty specialty)
        {
            _specialtyDal.Add(specialty);
        }

        public void Delete(Specialty specialty)
        {
            _specialtyDal.Delete(specialty);
        }

        public List<Specialty> GetAll()
        {
            return _specialtyDal.GetAll();
        }

        public Specialty GetById(int id)
        {
            return _specialtyDal.Get(x => x.Id == id);
        }

        public void Update(Specialty specialty)
        {
            _specialtyDal.Update(specialty);
        }
    }
}
