using HotelsPro2.Entities.Enums;
using System;

namespace HotelsPro2.Entities
{
    class NationalGuest : Guest
    {
        public long Document { get; set; }
        public DocumentType DocumentType { get; set; }
        public IssuingBody IssuingBody { get; set; }

        public NationalGuest()
        {

        }
        public NationalGuest(
                string firstName,
                string lastName,
                string email,
                Occupation occupation,
                DateTime birth,
                Countries nationality,
                long phone,
                long document,
                DocumentType documentType,
                IssuingBody issuingBody
            )
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.Occupation = occupation;
            this.Birthdate = birth;
            this.Nationality = nationality;
            this.Phone = phone;
            this.Document = document;
            this.DocumentType = documentType;
            this.IssuingBody = issuingBody;
        }
    }
}
