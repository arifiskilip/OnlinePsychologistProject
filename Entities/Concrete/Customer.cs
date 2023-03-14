using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public class Customer : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string ImageUrl { get; set; }
        public string AppUserId { get; set; }

        public AppUser AppUser { get; set; }
        public List<Appointment> Appointments { get; set; }
    }
}
