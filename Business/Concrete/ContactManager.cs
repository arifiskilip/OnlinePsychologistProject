using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class ContactManager : IContactService
    {
        private readonly IContactDal _contactDal;

        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public void Add(Contact comment)
        {
            _contactDal.Add(comment);
        }

        public void Delete(Contact comment)
        {
            _contactDal.Delete(comment);
        }

        public List<Contact> GetAll()
        {
            return _contactDal.GetAll();
        }

        public Contact GetById(int id)
        {
            return _contactDal.Get(x => x.Id == id);
        }

        public void Update(Contact comment)
        {
            _contactDal.Update(comment);
        }
    }
}
