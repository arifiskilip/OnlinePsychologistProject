using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class AppointmentManager : IAppointmentService
    {
        private readonly IAppointmentDal _appointmentDal;

        public AppointmentManager(IAppointmentDal appointmentDal)
        {
            _appointmentDal = appointmentDal;
        }

        public void Add(Appointment appointment)
        {
            _appointmentDal.Add(appointment);
        }

        public void Delete(Appointment appointment)
        {
            _appointmentDal.Delete(appointment);
        }

        public List<Appointment> GetAll()
        {
            return _appointmentDal.GetAll();
        }

        public Appointment GetById(int id)
        {
            return _appointmentDal.Get(x => x.Id == id);
        }

        public void Update(Appointment appointment)
        {
            _appointmentDal.Update(appointment);
        }
    }
}
