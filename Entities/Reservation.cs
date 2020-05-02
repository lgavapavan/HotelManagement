using HotelsPro2.Entities.Enums;
using System.Collections.Generic;
using System;

namespace HotelsPro2.Entities
{
    public class Reservation
    {
        public int Id { get; set; }
        public byte Adults { get; set; }
        public byte Kids { get; set; }
        public DateTime Checkin { get; set; }
        public DateTime Checkout { get; set; }
        public short Duration { get; set; }
        public string Notes { get; set; }
        public string Requests { get; set; }
        public DateTime EstimatedArrival { get; set; }
        public DateTime MomentOfReservation { get; set; }
        public List<Apartment> Apartment { get; set; } // At least 1 apartment

        public Reservation()
        {

        }
    }
}
