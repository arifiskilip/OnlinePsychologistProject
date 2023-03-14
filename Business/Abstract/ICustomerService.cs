using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        List<Customer> GetAll();
        Customer GetById(int id);
        void Add(Customer customer);
        void Delete(Customer customer);
        void Update(Customer customer);
    }
}
