using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelsPro2.Entities
{
    public class ApartmentCategory
    {
        public byte Id { get; set; }
        public string Title { get; set; }
        public decimal DailyRate { get; set; }
        public byte RoomCapacity { get; set; }
        public byte SingleBeds { get; set; }
        public byte QueenBeds { get; set; }
        public byte KingBeds { get; set; }
        public byte StandardDoubleBeds { get; set; }
        public string Description { get; set; }

    }
}
