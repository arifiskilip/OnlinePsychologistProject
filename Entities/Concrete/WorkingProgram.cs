using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public class WorkingProgram : BaseEntity
    {
        public int PsychologistId { get; set; }
        public DateTime WorkingDate { get; set; }
        public string TimeRange { get; set; } // 12:00 - 13:00


        public Psychologist Psychologist { get; set; }
        public List<Appointment> Appointments { get; set; }
    }
}
