using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface ISubscriberService
    {
        List<Subscriber> GetAll();
        Subscriber GetById(int id);
        void Add(Subscriber subscriber);
        void Delete(Subscriber subscriber);
        void Update(Subscriber subscriber);
    }
}
