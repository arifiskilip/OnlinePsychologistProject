using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    // Danışman    
    public class Psychologist : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string ImageUrl { get; set; }
        public string Title { get; set; }
        public string AboutMe { get; set; }
        public string AppUserId { get; set; }
        public int Rating { get; set; }


        public List<Specialty> Specialties { get; set; } //uzmanlık alanı
        public AppUser AppUser { get; set; }
        public List<Appointment> Appointments { get; set; } //randevu
        public List<WorkingProgram> WorkingPrograms { get; set; }
        public List<Comment> Comments { get; set; }

    }
}
