using System;

namespace Entities.Concrete
{
    //Randevu
    public class Appointment : BaseEntity
    {
        public int WorkingProgramId { get; set; }
        public int ApppintmentTypeId { get; set; } 
        public int CustomerId { get; set; }
        public int PsychologistId { get; set; }
        public string Description { get; set; }

        public WorkingProgram WorkingProgram { get; set; }
        public AppointmentType AppointmentType { get; set; }
        public Customer Customer { get; set; }
        public Psychologist Psychologist { get; set; }

    }
}
