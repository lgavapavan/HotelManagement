using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelsPro2.Entities.Enums
{
    public class Apartment
    {
        public short Id { get; set; }
        public short Number { get; set; }
        public decimal Value { get; set; }
        public bool IsModified { get; set; } // True if it is an apartment prepared for people with disabilities
        public bool HasTv { get; set; } // True if it has a tv
        public bool HasFridge { get; set; } // True if it has a fridge
        public bool HasAircon { get; set; } // True if it has an air conditioner
        public ApartmentCategory ApartmentCategory { get; set; } // One and only one category

        public Apartment()
        {

        }
    }
}
