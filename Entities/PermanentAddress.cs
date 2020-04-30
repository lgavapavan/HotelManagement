using HotelsPro2.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelsPro2.Entities
{
    public class PermanentAddress
    {
        public int Id { get; set; }
        public string StreetName { get; set; }
        public string Number { get; set; }
        public string Complement { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public Countries Country { get; set; }
    }
}
