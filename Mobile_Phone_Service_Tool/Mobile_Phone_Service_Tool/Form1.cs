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
using MySql.Data;


namespace Mobile_Phone_Service_Tool
{
    public partial class Form1 : Form
    {
       

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void lblDevicecolor_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnInsertdata_Click(object sender, EventArgs e)
        {

            String Username = txtUsername.Text.ToString();
            String Phonenumber = txtPhonenumber.Text.ToString();
            String Technicalname = txtTechnicalname.Text.ToString();
            String Devicemodel = cboDevicemodel.Text.ToString();
            String Devicecolor = cboDevicecolor.Text.ToString();
            String Deviceimei_1 = txtDeviceimei_1.Text.ToString();
            String Deviceimei_2 = txtDeviceimei_2.Text.ToString();
            String Deviceerror = txtDeviceerror.Text.ToString();
            String Patternlock = txtPatternlock.Text.ToString();
            String Simcard = cboSimcard.Text.ToString();
            String Sdcard = cboSdcard.Text.ToString();
            String Startdate = txtStartdate.Text.ToString();
            String Enddate = txtEnddate.Text.ToString();
            String Amount = txtAmount.Text.ToString();
            if( Username==""||Phonenumber== ""|| Technicalname==""|| Devicemodel==""||Devicecolor==""|| Deviceimei_1==""||Deviceimei_2==""|Deviceerror==""||Patternlock==""||Simcard==""||Sdcard==""||Startdate==""||Enddate==""||Amount=="")
            {
                MessageBox.Show("Please Check Your Input");
                return;
                
            }
            try
            {
                MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root");
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                // cmd.CommandText = INSERT INTO  student.service_table (customer_name`, `phone_number`, `technical_name`, `device_model`, `device_color`, `imei_1`, `imei_2`, `device_error`, `pattern_lock`, `simcard`, `sd_card`, `start_date`, `end_date`, `amount`) "VALUES(NULL, 'kyaw kyaw soe', '09967044010', 'aung kyaw soe', 'samsung note7', 'gold', '8123', '8345', '', '4598', 'no', 'no', '9.1.2020', '10.1.2020', '10000')";
                cmd.CommandText = "INSERT INTO student.service_table( customer_name, phone_number, technical_name, device_model, device_color, imei_1, imei_2, device_error, pattern_lock, simcard, sd_card, start_date, end_date, amount) VALUES ('" + Username + "','" + Phonenumber + "','" + Technicalname + "','" + Devicemodel + "','" + Devicecolor + "','" + Deviceimei_1 + "','" + Deviceimei_2 + "','" + Deviceerror + "','" + Patternlock + "','" + Simcard +"','" + Sdcard + "','" + Startdate + "','" + Enddate + "','" + Amount+"')"; //kyaw kyaw soe', '09967044010', 'aung kyaw soe', 'samsung note7', 'gold', '8123', '8345', '', '4598', 'no', 'no', '9.1.2020', '10.1.2020', '10000')";
                //cmd.CommandText = "INSERT INTO student.`service_table` (`customer_name`, `phone_number`, `technical_name`, `device_model`, `device_color`, `imei_1`, `imei_2`, `device_error`, `pattern_lock`, `simcard`, `sd_card`, `start_date`, `end_date`, `amount`) VALUES( '@Username', '@Phonenumber', '@Technicalname', '@Devicemodel', '@Devicecolor', '@Deviceimei_1', '@Deviceimei_2', '@Deviceerror', '@Patternlock', '@Simcard', '@Sdcard', '@Startdate', '@Enddate', '@Amount')";
                // cmd.Parameters.AddWithValue("@Username", Username);

                // "VALUES (@Username,@Phonenumber,@Technicalname,@Devicemodel,@Devicecolor,@Deviceimei_1,@Deviceimei_2,@Deviceerror,@Patternlock,@Startdate,@Enddate,@Amount)";
                // "VALUES (NULL, 'kyaw kyaw soe', '09967044010', 'aung kyaw soe', 'samsung note7', 'gold', '8123', '8345', '', '4598', 'no', 'no', '9.1.2020', '10.1.2020', '10000')";
               // cmd.Parameters.AddWithValue("@Username", Username);
               //// cmd.Parameters.AddWithValue("@Username", Username);
               // cmd.Parameters.AddWithValue("@Phonenumber", Phonenumber);
               // cmd.Parameters.AddWithValue("@Technicalname", Technicalname);
               // cmd.Parameters.AddWithValue("@Devicemodel", cboDevicemodel);
               // cmd.Parameters.AddWithValue("@Devicecolor", Devicecolor);
               // cmd.Parameters.AddWithValue("@Deviceimei_1", Deviceimei_1);
               // cmd.Parameters.AddWithValue("@Deviceimei_2", Deviceimei_1);
               // cmd.Parameters.AddWithValue("@Deviceerror", Deviceerror);
               // cmd.Parameters.AddWithValue("@Patternlock", Patternlock);
               // cmd.Parameters.AddWithValue("@Simcard", Simcard);
               // cmd.Parameters.AddWithValue("@Sdcard", Sdcard);
               // cmd.Parameters.AddWithValue("@Startdate", Startdate);
               // cmd.Parameters.AddWithValue("@Enddate", Enddate);
               // cmd.Parameters.AddWithValue("@Amount", Amount);


                int result = cmd.ExecuteNonQuery();
                con.Close();
                if (result > 0)
                {
                    MessageBox.Show("Service Register=OK");
                    txtUsername.Clear();
                    txtPhonenumber.Clear();
                    txtTechnicalname.Clear();
                    cboDevicemodel.Items.Clear();
                    cboDevicecolor.Items.Clear();
                    txtDeviceimei_1.Clear();
                    txtDeviceimei_2.Clear();
                    txtDeviceerror.Clear();
                    txtPatternlock.Clear();
                    cboSdcard.Items.Clear();
                    cboSdcard.Items.Clear();
                    txtStartdate.Clear();
                    txtEnddate.Clear();
                    txtAmount.Clear();
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = "Mi Mi";
            string age = "13";
            string msg = "insert into table (name,age) values ('" + name + "','" + age + "')";
            MessageBox.Show(msg);
        }
    }       
  
}
