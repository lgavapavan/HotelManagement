using HotelsPro2.Entities;
using HotelsPro2.Entities.Enums;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelsPro2.Entities
{
    static class Globals
    {
        public static string hotelCountry = "Brazil";
        public static string foreignDocument = "Passport";
        public static string connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
        
        public static int guestId;
        public static int reservationId;

        //NewReservation
        public static List<Apartment> apartments = new List<Apartment>();
    }

    
}
