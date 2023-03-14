using System.Collections.Generic;

namespace Entities.Concrete
{
    //Randevu Türleri
    public class AppointmentType : BaseEntity 
    {
        public string Name { get; set; }
        public double Price { get; set; }


        public List<Appointment> Appointments { get; set; }
    }
}
