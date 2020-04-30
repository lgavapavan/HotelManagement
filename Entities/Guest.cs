using HotelsPro2.Entities.Enums;
using System;
using System.Collections.Generic;

namespace HotelsPro2.Entities
{
    public abstract class Guest // Not possible to instanciate a Guest object
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public Occupation Occupation { get; set; } 
        public DateTime Birthdate { get; set; }
        public Countries Nationality { get; set; }
        public Gender Gender { get; set; }
        public long Phone { get; set; }
        public List<PermanentAddress> Address { get; set; } //At least 1 address
        public List<Reservation> Reservation { get; set; } //Could have zero reservations

        public Guest()
        {

        }
    }
}
