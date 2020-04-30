using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelsPro2.Entities;
using HotelsPro2.Entities.Enums;
using HotelsPro2.Forms;
using MySql.Data.MySqlClient;

namespace HotelsPro2
{
    public partial class GuestRegistrationFrm : Form
    {
        public GuestRegistrationFrm()
        {
            InitializeComponent();
            comboNationality.DataSource = Enum.GetValues(typeof(Countries));
            comboNationality.SelectedIndex = 29;

            comboIssuingCountry.DataSource = Enum.GetValues(typeof(Countries));
            comboIssuingCountry.SelectedIndex = 29;

            comboOccupation.DataSource = Enum.GetValues(typeof(Occupation));

            comboIssuingBody.DataSource = Enum.GetValues(typeof(IssuingBody));

            comboDocumentType.DataSource = Enum.GetValues(typeof(DocumentType));
        }

        private void radioFemale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {            
            // Converting to enums
            try
            {
                Countries nationality = (Countries)Enum.Parse(typeof(Countries), comboNationality.SelectedItem.ToString());
                Countries issuingCountry = (Countries)Enum.Parse(typeof(Countries), comboIssuingCountry.SelectedItem.ToString());
                Occupation occupation = (Occupation)Enum.Parse(typeof(Occupation), comboOccupation.SelectedItem.ToString());
                DocumentType documentType = (DocumentType)Enum.Parse(typeof(DocumentType), comboDocumentType.SelectedItem.ToString());
                IssuingBody issuingBody = (IssuingBody)Enum.Parse(typeof(IssuingBody), comboIssuingBody.SelectedItem.ToString());
                string gender;
                if (radioMale.Checked)
                    gender = "Male";
                else
                    gender = "Female";

                //Check whether it is a national or international guest
            
            if (comboNationality.SelectedItem.ToString() == Globals.hotelCountry)
            {
                NationalGuest guest = new NationalGuest(
                    txtFirstName.Text,
                    txtLastName.Text,
                    txtEmail.Text,
                    occupation,
                    dtpBirth.Value,
                    nationality,
                    Convert.ToInt64(txtPhone.Text),
                    Convert.ToInt64(txtDocument.Text),
                    documentType,
                    issuingBody
                );

                MySqlConnection con = new MySqlConnection(Globals.connString);
                con.Open();

                try
                {
                    MySqlCommand cmd = new MySqlCommand("SaveNewGuest", con);
                    cmd.Parameters.Add("_first_name", MySqlDbType.VarChar, 55).Value = guest.FirstName;
                    cmd.Parameters.Add("_last_name", MySqlDbType.VarChar, 55).Value = guest.LastName;
                    cmd.Parameters.Add("_email", MySqlDbType.VarChar, 60).Value = guest.Email;
                    cmd.Parameters.Add("_occupation", MySqlDbType.VarChar, 45).Value = guest.Occupation;
                    cmd.Parameters.Add("_birth_date", MySqlDbType.Date).Value = guest.Birthdate;
                    cmd.Parameters.Add("_nationality", MySqlDbType.VarChar, 60).Value = Globals.hotelCountry;
                    cmd.Parameters.Add("_gender", MySqlDbType.VarChar, 6).Value = gender;
                    cmd.Parameters.Add("_phone", MySqlDbType.VarChar, 50).Value = guest.Phone;
                    cmd.Parameters.Add("_document", MySqlDbType.VarChar, 50).Value = guest.Document;
                    cmd.Parameters.Add("_document_type", MySqlDbType.VarChar, 25).Value = guest.DocumentType;
                    cmd.Parameters.Add("_issuing_body", MySqlDbType.VarChar, 45).Value = guest.IssuingBody;
                    cmd.Parameters.Add("_issuing_country", MySqlDbType.VarChar, 60).Value = Globals.hotelCountry;
                    cmd.Parameters.Add("_is_international", MySqlDbType.Int16).Value = 0;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();
                    
                    MessageBox.Show("Guest saved successfully!");
                    this.Close();

                    var form = new GuestListFrm();
                    form.Show();
                }
                catch (Exception ex)
                {
                    throw ex;
                }

                con.Close();
            }
            else
            {
                InternationalGuest guest = new InternationalGuest(
                    txtFirstName.Text, 
                    txtLastName.Text, 
                    txtEmail.Text, 
                    occupation, 
                    dtpBirth.Value, 
                    nationality, 
                    Convert.ToInt64(txtPhone.Text),
                    txtDocument.Text,
                    issuingCountry
                );

                MySqlConnection con = new MySqlConnection(Globals.connString);
                con.Open();

                try
                {
                    MySqlCommand cmd = new MySqlCommand("SaveNewGuest", con);
                    cmd.Parameters.Add("_first_name", MySqlDbType.VarChar, 55).Value = guest.FirstName;
                    cmd.Parameters.Add("_last_name", MySqlDbType.VarChar, 55).Value = guest.LastName;
                    cmd.Parameters.Add("_email", MySqlDbType.VarChar, 60).Value = guest.Email;
                    cmd.Parameters.Add("_occupation", MySqlDbType.VarChar, 45).Value = guest.Occupation;
                    cmd.Parameters.Add("_birth_date", MySqlDbType.Date).Value = guest.Birthdate;
                    cmd.Parameters.Add("_nationality", MySqlDbType.VarChar, 60).Value = guest.Nationality;
                    cmd.Parameters.Add("_gender", MySqlDbType.VarChar, 6).Value = gender;
                    cmd.Parameters.Add("_phone", MySqlDbType.VarChar, 50).Value = guest.Phone;
                    cmd.Parameters.Add("_document", MySqlDbType.VarChar, 50).Value = guest.Passport;
                    cmd.Parameters.Add("_document_type", MySqlDbType.VarChar, 25).Value = Globals.foreignDocument;
                    cmd.Parameters.Add("_issuing_body", MySqlDbType.VarChar, 45).Value = null;
                    cmd.Parameters.Add("_issuing_country", MySqlDbType.VarChar, 60).Value = issuingCountry;
                    cmd.Parameters.Add("_is_international", MySqlDbType.Int16).Value = 1;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Guest saved successfully!");
                    this.Close();

                    var form = new GuestListFrm();
                    form.Show();
                }
                catch (Exception ex)
                {
                    throw ex;
                }

                con.Close();
            }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }             
            
        }
    }
}
