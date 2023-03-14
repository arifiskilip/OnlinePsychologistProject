using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IAppointmentService
    {
        List<Appointment> GetAll();
        Appointment GetById(int id);
        void Add(Appointment appointment);
        void Delete(Appointment appointment);
        void Update(Appointment appointment);
    }
}
