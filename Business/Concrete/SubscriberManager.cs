using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class SubscriberManager : ISubscriberService
    {
        private readonly ISubscriberDal _subscriberDal;

        public SubscriberManager(ISubscriberDal subscriberDal)
        {
            _subscriberDal = subscriberDal;
        }

        public void Add(Subscriber subscriber)
        {
            _subscriberDal.Add(subscriber);
        }

        public void Delete(Subscriber subscriber)
        {
            _subscriberDal.Delete(subscriber);
        }

        public List<Subscriber> GetAll()
        {
            return _subscriberDal.GetAll();
        }

        public Subscriber GetById(int id)
        {
            return _subscriberDal.Get(x => x.Id == id);
        }

        public void Update(Subscriber subscriber)
        {
            _subscriberDal.Update(subscriber);
        }
    }
}
