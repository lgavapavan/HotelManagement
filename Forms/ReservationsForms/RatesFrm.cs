using HotelsPro2.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelsPro2.Forms
{
    public partial class RatesFrm : Form
    {
        public RatesFrm()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(Globals.connString);
            con.Open();
                        
            try
            {
                MySqlCommand cmd = new MySqlCommand("UpdateDailyPrice_SingleDate", con);
                cmd.Parameters.Add("_price", MySqlDbType.Decimal).Value = Decimal.Parse(txtDailyRate.Text);
                cmd.Parameters.Add("_date", MySqlDbType.Int32).Value = ConvertDateToNumber(dtpSingleDate.Value);
                cmd.Parameters.Add("_category", MySqlDbType.VarChar, 20).Value = "standard_deluxe_room";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
                MessageBox.Show($"Updated {dtpSingleDate.Value} rate successfully!");
            }
            catch (Exception)
            {
                con.Close();
                throw;
            }
            con.Close();
        }

        private void btnUpdateMultipleDates_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(Globals.connString);
            con.Open();

            try
            {
                MySqlCommand cmd = new MySqlCommand("UpdateDailyPrice_MultipleDates", con);
                cmd.Parameters.Add("_price", MySqlDbType.Decimal).Value = Decimal.Parse(txtDailyRateMultipleDates.Text);
                cmd.Parameters.Add("_checkin", MySqlDbType.Int32).Value = ConvertDateToNumber(dtpCheckinMultipleDates.Value);
                cmd.Parameters.Add("_checkout", MySqlDbType.Int32).Value = ConvertDateToNumber(dtpCheckoutMultipleDates.Value);
                cmd.Parameters.Add("_category", MySqlDbType.VarChar, 40).Value = "standard_deluxe_room";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
                MessageBox.Show($"Updated prices between {dtpCheckinMultipleDates.Value} and {dtpCheckoutMultipleDates.Value} successfully!");
            }
            catch (Exception)
            {
                con.Close();
                throw;
            }
            con.Close();
        }

        private int ConvertDateToNumber(DateTime date)
        {
            int days = 0;
            if (DateTime.IsLeapYear(date.Year))
            {
                switch (date.Month)
                {
                    case 1:
                        days += 0;
                        break;
                    case 2:
                        days += 31;
                        break;
                    case 3:
                        days = 60;
                        break;
                    case 4:
                        days = 91;
                        break;
                    case 5:
                        days = 121;
                        break;
                    case 6:
                        days = 152;
                        break;
                    case 7:
                        days = 182;
                        break;
                    case 8:
                        days = 213;
                        break;
                    case 9:
                        days = 244;
                        break;
                    case 10:
                        days = 274;
                        break;
                    case 11:
                        days = 305;
                        break;
                    case 12:
                        days = 335;
                        break;
                    default:
                        break;
                }
            }
            else
            {
                switch (date.Month)
                {
                    case 1:
                        days += 0;
                        break;
                    case 2:
                        days += 31;
                        break;
                    case 3:
                        days = 59;
                        break;
                    case 4:
                        days = 90;
                        break;
                    case 5:
                        days = 120;
                        break;
                    case 6:
                        days = 151;
                        break;
                    case 7:
                        days = 181;
                        break;
                    case 8:
                        days = 212;
                        break;
                    case 9:
                        days = 243;
                        break;
                    case 10:
                        days = 273;
                        break;
                    case 11:
                        days = 304;
                        break;
                    case 12:
                        days = 334;
                        break;
                    default:
                        break;
                }
            }
            days += date.Day;
            return days;
        }

        
    }
}
