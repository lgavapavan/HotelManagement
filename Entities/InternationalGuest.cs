using HotelsPro2.Entities.Enums;
using System;

namespace HotelsPro2.Entities
{
    public class InternationalGuest : Guest
    {
        public string Passport { get; set; }
        public Countries IssuingCountry { get; set; }

        public InternationalGuest()
        {

        }
        public InternationalGuest(
                string firstName,
                string lastName,
                string email,
                Occupation occupation,
                DateTime birth,
                Countries nationality,
                long phone,
                string passport,
                Countries issuingCountry
            )
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.Occupation = occupation;
            this.Birthdate = birth;
            this.Nationality = nationality;
            this.Phone = phone;
            this.Passport = passport;
            this.IssuingCountry = issuingCountry;
        }
        
    }

    
}
