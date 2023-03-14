using System.Collections.Generic;

namespace Entities.Concrete
{
    // Danışma'nın uzmanlık alanlarının yer aldığı tablo.
    public class Specialty : BaseEntity
    {
        public string Name { get; set; }
        public int PsychologistId { get; set; }

        public Psychologist Psychologist { get; set; }


    }
}
