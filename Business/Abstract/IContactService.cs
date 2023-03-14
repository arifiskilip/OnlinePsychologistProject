using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IContactService
    {
        List<Contact> GetAll();
        Contact GetById(int id);
        void Add(Contact comment);
        void Delete(Contact comment);
        void Update(Contact comment);
    }
}
