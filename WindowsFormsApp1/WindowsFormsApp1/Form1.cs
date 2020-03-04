using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            String Customername = txtCustomername.Text.ToString();
            String Phonenumber = txtPhonenumber.Text.ToString();
            String Technicalname = txtTechnicalname.Text.ToString();
            String Devicemodel = txtDevicemodel.Text.ToString();
            String Devicecolor = txtDevicecolor.Text.ToString();
            String Deviceimei_1 = txtDeviceimei_1.Text.ToString();
            String Deviceimei_2 = txtDeviceimei_2.Text.ToString();
            String Deviceerror = txtDeviceerror.Text.ToString();
            String Passwordlock = txtPasswordlock.Text.ToString();
            String Simcard = txtSdcard.Text.ToString();
            String Sdcard = txtSdcard.Text.ToString();
            String Startdate = dtpStartdate.Value.ToString("yyyy-MM-dd");
            String EndDate = dtpEnddate.Value.ToString("yyyy-MM-dd");
           // update table set date = null
            // DateTime.ParseExact(Text.ToString(), "dd/MM/yyyy", null);
            // DateTime.ParseExact(Text.ToString(), "dd/MM/yyyy", null);
            // DateTime startDate = DateTime.ParseExact(Text, "ddMMyy", null);
            //DateTime endDate = DateTime.ParseExact(Text, "yyyyMMdd", null);

            //String Startdate = txtStartdate.Text.ToString();
            // String Enddate = txtEnddate.Text.ToString();
            String Amount = txtAmount.Text.ToString();
            if (Customername == "" || Phonenumber == "" || Devicemodel == "" || Devicecolor == "" || Deviceimei_1 == "" || Deviceimei_2 == "" || Deviceerror == "" || Passwordlock == "" || Simcard == "" || Sdcard == ""  || Amount == "");
            {
                // MessageBox.Show("Please Check Your Input");
               txtCustomername.Focus();
                }
                   try
                {
               // < connectionStrings >   < add name = "MyContext" connectionString = "Datasource=localhost;Database=MyAppDb;Uid=root;Pwd=root;CHARSET=utf8;convert zero datetime=True" providerName = "MySql.Data.MySqlClient" /> </ connectionStrings >
                       // server = localhost; User Id = root; password = mautauaja; Persist Security Info = True; database = test; Convert Zero Datetime = True
                       MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root");
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                //cmd.CommandText = "INSERT INTO  student.`phone_service_table` ( customer_name, phone_number, technical_name, device_model, device_color, imei_1, imei_2, device_error, password_lock, sim_card, sd_card, start_date, end_date, amount) VALUES(NULL, @Customername, @Phonenumber, @Technicalname, @Devicemodel, @Devicecolor, @Deviceimei_1, @Deviceimei_2, @Deviceerror, @Passwordlock, @Simcard, @Sdcard, @Startdate, @Enddate, @Amount)";
                  cmd.CommandText = "INSERT INTO student.`phone_service_table` (`customer_id`, `customer_name`, `phone_number`, `technical_name`, `device_model`, `device_color`, `imei_1`, `imei_2`, `device_error`, `password_lock`, `sim_card`, `sd_card`, `start_date`, `end_date`, `amount`) VALUES (NULL, @Customername, @Phonenumber, @Technicalname, @Devicemodel, @Devicecolor, @Deviceimei_1, @Deviceimei_2, @Deviceerror, @Passwordlock, @Simcard, @Sdcard, @Startdate, @Enddate, @Amount)";

                cmd.Parameters.AddWithValue("@Customername", Customername);
                cmd.Parameters.AddWithValue("@Phonenumber", Phonenumber);
                cmd.Parameters.AddWithValue("@Technicalname", Technicalname);
                cmd.Parameters.AddWithValue("@Devicemodel", Devicemodel);
                cmd.Parameters.AddWithValue("@Devicecolor", Devicecolor);
                cmd.Parameters.AddWithValue("@Deviceimei_1", Deviceimei_1);
                cmd.Parameters.AddWithValue("@Deviceimei_2", Deviceimei_2);
                cmd.Parameters.AddWithValue("@Deviceerror", Deviceerror);
                cmd.Parameters.AddWithValue("@Passwordlock", Passwordlock);
                cmd.Parameters.AddWithValue("@Simcard", Simcard);
                cmd.Parameters.AddWithValue("@Sdcard", Sdcard);
                cmd.Parameters.AddWithValue("@Startdate", Startdate);
                cmd.Parameters.AddWithValue("@Enddate", EndDate);
               // cmd.Parameters.Add(("@StartDate", Convert.ToDateTime(Text).ToShortDateString()));
               // cmd.Parameters.Add(("@EndDate", Convert.ToDateTime(Text).ToShortDateString()));
                
                //cmd.Parameters.Add("@Enddate,Convert,TodateTime (Text).ToShortDateString");
                // cmd.Parameters.Add("@value",DateTimeParam);
                //cmd.Parameters.AddWithValue("@values", Validated);
                // cmd.Parameters.AddWithValue("@Startdate", Startdate);
                //cmd.Parameters.AddWithValue("@Enddate", Enddate);
                cmd.Parameters.AddWithValue("@Amount", Amount);

                int result = cmd.ExecuteNonQuery();
                con.Close();
                if (result>0)
                {
                    MessageBox.Show("Service Register=OK");
                    txtCustomername.Clear();
                    txtPhonenumber.Clear();
                    txtCustomername.Clear();
                    txtDevicemodel.Clear();
                    txtDevicecolor.Clear();
                    txtDeviceimei_1.Clear();
                    txtDeviceimei_2.Clear();
                    txtDeviceerror.Clear();
                    txtPasswordlock.Clear();
                    txtSdcard.Clear();
                    txtSdcard.Clear();
                    //dtpStartdate.Text.C
                    //txtEnddate.Clear();
                    txtAmount.Clear();

                   
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
       }

       }

        private void dtbStartdate_ValueChanged(object sender, EventArgs e)
        {

        }
    }

         }
          
       
   
