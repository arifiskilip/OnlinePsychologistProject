using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class StatisticManager : IStatisticService
    {
        private readonly IStatisticDal _statisticDal;

        public StatisticManager(IStatisticDal statisticDal)
        {
            _statisticDal = statisticDal;
        }

        public void Add(Statistic statistic)
        {
            _statisticDal.Add(statistic);
        }

        public void Delete(Statistic statistic)
        {
            _statisticDal.Delete(statistic);
        }

        public List<Statistic> GetAll()
        {
            return _statisticDal.GetAll();
        }

        public Statistic GetById(int id)
        {
            return _statisticDal.Get(x => x.Id == id);
        }

        public void Update(Statistic statistic)
        {
            _statisticDal.Update(statistic);
        }
    }
}
