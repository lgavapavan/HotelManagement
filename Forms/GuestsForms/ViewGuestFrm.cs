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
    public partial class ViewGuestFrm : Form
    {
        public ViewGuestFrm()
        {
            InitializeComponent();
            //Loading the datasource for comboboxes
            comboNationality.DataSource = Enum.GetValues(typeof(Countries));            
            comboIssuingCountry.DataSource = Enum.GetValues(typeof(Countries));            
            comboOccupation.DataSource = Enum.GetValues(typeof(Occupation));
            comboIssuingBody.DataSource = Enum.GetValues(typeof(IssuingBody));
            comboDocumentType.DataSource = Enum.GetValues(typeof(DocumentType));

        }

        // Loading the selected guest's information
        private void EditGuestFrm_Load(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(Globals.connString);

            con.Open();

            MySqlCommand cmd = new MySqlCommand("DisplayGuestInfo", con);
            cmd.Parameters.Add("_id", MySqlDbType.Int32).Value = Globals.guestId;
            cmd.CommandType = CommandType.StoredProcedure;
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                txtFirstName.Text = StringExtensions.FirstCharToUpper(reader["first_name"].ToString());
                txtLastName.Text = StringExtensions.FirstCharToUpper(reader["last_name"].ToString());
                txtEmail.Text = (reader["email"].ToString());
                comboNationality.Text = StringExtensions.FirstCharToUpper(reader["nationality"].ToString());
                comboOccupation.Text = StringExtensions.FirstCharToUpper(reader["occupation"].ToString());
                txtDocument.Text = StringExtensions.FirstCharToUpper(reader["document"].ToString());
                comboDocumentType.Text = (reader["document_type"].ToString().ToUpper());
                comboIssuingBody.Text = (reader["issuing_body"].ToString().ToUpper());
                comboIssuingCountry.Text = StringExtensions.FirstCharToUpper(reader["issuing_country"].ToString());
                txtPhone.Text = StringExtensions.FirstCharToUpper(reader["phone"].ToString());
                if (StringExtensions.FirstCharToUpper(reader["gender"].ToString()) == "Male")
                {
                    radioMale.Checked = true;
                }
                else
                {
                    radioFemale.Checked = true;
                }
                dtpBirth.Text = reader["birth_date"].ToString();
            }

            con.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
