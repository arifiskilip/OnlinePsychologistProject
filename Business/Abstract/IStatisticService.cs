using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IStatisticService
    {
        List<Statistic> GetAll();
        Statistic GetById(int id);
        void Add(Statistic statistic);
        void Delete(Statistic statistic);
        void Update(Statistic statistic);
    }
}
