using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IAppointmentTypeService
    {
        List<AppointmentType> GetAll();
        AppointmentType GetById(int id);
        void Add(AppointmentType appointmentType);
        void Delete(AppointmentType appointmentType);
        void Update(AppointmentType appointmentType);
    }
}
