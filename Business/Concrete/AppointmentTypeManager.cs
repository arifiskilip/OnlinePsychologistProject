using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class AppointmentTypeManager : IAppointmentTypeService
    {
        private readonly IAppointmentTypeDal _appointmentTypeDal;

        public AppointmentTypeManager(IAppointmentTypeDal appointmentTypeDal)
        {
            _appointmentTypeDal = appointmentTypeDal;
        }

        public void Add(AppointmentType appointmentType)
        {
            _appointmentTypeDal.Add(appointmentType);
        }

        public void Delete(AppointmentType appointmentType)
        {
            _appointmentTypeDal.Delete(appointmentType);
        }

        public List<AppointmentType> GetAll()
        {
            return _appointmentTypeDal.GetAll();
        }

        public AppointmentType GetById(int id)
        {
            return _appointmentTypeDal.Get(x => x.Id == id);
        }

        public void Update(AppointmentType appointmentType)
        {
            _appointmentTypeDal.Update(appointmentType);
        }
    }
}
