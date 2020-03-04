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
    public partial class frmUpdatetable : Form
    {
        public frmUpdatetable()
        {
            InitializeComponent();
        }
        MySqlDataAdapter adapter2;
        private void btnUpdate_Click(object sender, EventArgs e)
        {

            String txt = txtPhonenumber.Text.ToString();
            funUpdate(txt, title_selected);
        }


        //public void funUpdate(String txt,int title)
        //{
        //   //String Phonenumber = txtPhonenumber.Text.ToString();
        //    try
        //    {
        //        MySqlConnection con = new MySqlConnection("datasource localhost;port=3306;username=root");
        //        switch (title)
        //       MySqlDataAdapter adapter;// = new MySqlDataAdapter("Select * from student.phone_service.table where Phonenumber like")






        public void funUpdate(String txt, int title)
        {
            //String phone_number = txtPhonenumber.Text.ToString();
            try
            {
                MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root");
                // = new MySqlDataAdapter("Select * From student.phone_service-table where phone_number like'" + txt + "'", con);
                switch (title)
                {
                    case 0:
                        adapter2 = new MySqlDataAdapter("UPDATE student.phone_service_table SET customer_id= "+txt+"customer_id like'" + txt + "'", con);
                        break;
                    case 1:
                        adapter2 = new MySqlDataAdapter("UPDATE student.phone_service_table SET customer_name=customer_name where customer_name like'" + txt + "%'", con);
                        break;
                    case 2:
                        adapter2 = new MySqlDataAdapter("UPDATE student.phone_service_table SET phone_number=phone_number like'" + txt + "%'", con);
                        break;
                    case 3:
                        adapter2 = new MySqlDataAdapter("UPDATE student.phone_service_table SET technical_name= technical_name like'" + txt + "%'", con);
                        break;
                    case 4:
                        adapter2 = new MySqlDataAdapter("UPDATE student.phone_service_table SET device_model=device_model like'" + txt + "%'", con);
                        break;
                    case 5:
                        adapter2 = new MySqlDataAdapter("UPDATE student.phone_service_table SET device_color=device_color like'" + txt + "%'", con);
                        break;
                    case 6:
                        adapter2 = new MySqlDataAdapter("UPDATE student.phone_service_table SET imei_1=imei_1  like'" + txt + "%'", con);
                        break;
                    case 7:
                        adapter2 = new MySqlDataAdapter("UPDATE student.phone_service_table SET imei_2=imei_2 like'" + txt + "%'", con);
                        break;
                    case 8:
                        adapter2 = new MySqlDataAdapter("UPDATE student.phone_service_table SET device_error=device_error like'" + txt + "%'", con);
                        break;
                    case 9:
                        adapter2 = new MySqlDataAdapter("UPDATE student.phone_service_table SET password_lock=password_lock like'" + txt + "%'", con);
                        break;
                    case 10:
                        adapter2 = new MySqlDataAdapter("UPDATE student.phone_service_table SET sim_card=sim_card like'" + txt + "%'", con);
                        break;
                    case 11:
                        adapter2 = new MySqlDataAdapter("UPDATE student.phone_service_table SET sd_card=sd_card like'" + txt + "%'", con);
                        break;
                    // case 12: adapter2 = new MySqlDataAdapter("Select * From student.phone_service_table where phone_number like'" + txt + "'", con);
                    // break;
                    // case 13: MySqlDataAdapter adapter = new MySqlDataAdapter("Select * From student.phone_service-table where phone_number like'" + txt + "'", con);
                    // break;
                    //case 14: MySqlDataAdapter adapter = new MySqlDataAdapter("Select * From student.phone_service-table where phone_number like'" + txt + "'", con);
                    //break;
                    case 12:
                        adapter2 = new MySqlDataAdapter("UPDATE student.phone_service_table SET amount=amount like'" + txt + "'", con);
                        break;

                }


                con.Open();
                DataSet ds = new DataSet();
                adapter2.Fill(ds, "phone_service_table");
                //dataGridView1.DataSource = ds.Tables[0];
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        int title_selected = 0;
        private void cboTitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            //switch(cboTitle.SelectedIndex)
            //{
            //    case 0: title_selected = 0; lblTitle.Text = "Customer_ID"; break;
            //    case 1: title_selected = 1; lblTitle.Text = "Customer_Name"; break;
            //    case 2: title_selected = 2; lblTitle.Text = "Phone_Number"; break;
            //    case 3: title_selected = 3; lblTitle.Text = "Technical_Name"; break;
            //    case 4: title_selected = 4; lblTitle.Text = "Device_Model"; break;
            //    case 5: title_selected = 5; lblTitle.Text = "Device_Color"; break;
            //    case 6: title_selected = 6; lblTitle.Text = "Device_imei_1"; break;
            //    case 7: title_selected = 7; lblTitle.Text = "Device_imei_2"; break;
            //    case 8: title_selected = 8; lblTitle.Text = "Device_Error"; break;
            //    case 9: title_selected = 9; lblTitle.Text = "Password_Lock"; break;
            //    case 10:title_selected = 10;lblTitle.Text = "Sim_Card";break;
            //    case 11:title_selected = 11;lblTitle.Text = "Sd_Card"; break;
            //    case 12:title_selected = 12;lblTitle.Text = "Amount"; break;

            //}

        }

        private void cboTitle_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            switch (cboTitle.SelectedIndex)
            {
                case 0: title_selected = 0; lblTitle.Text = "Customer_ID"; break;
                case 1: title_selected = 1; lblTitle.Text = "Customer_Name"; break;
                case 2: title_selected = 2; lblTitle.Text = "Phone_Number"; break;
                case 3: title_selected = 3; lblTitle.Text = "Technical_Name"; break;
                case 4: title_selected = 4; lblTitle.Text = "Device_Model"; break;
                case 5: title_selected = 5; lblTitle.Text = "Device_Color"; break;
                case 6: title_selected = 6; lblTitle.Text = "Device_imei_1"; break;
                case 7: title_selected = 7; lblTitle.Text = "Device_imei_2"; break;
                case 8: title_selected = 8; lblTitle.Text = "Device_Error"; break;
                case 9: title_selected = 9; lblTitle.Text = "Password_Lock"; break;
                case 10: title_selected = 10; lblTitle.Text = "Sim_Card"; break;
                case 11: title_selected = 11; lblTitle.Text = "Sd_Card"; break;
                case 12: title_selected = 12; lblTitle.Text = "Amount"; break;

            }
        }

        private void cboTitle_SelectedIndexChanged_2(object sender, EventArgs e)
        {
            switch (cboTitle.SelectedIndex)
            {
                //case 0: title_selected = 0; lblTitle.Text = "Customer_ID"; break;
                case 1: title_selected = 1; lblTitle.Text = "Customer_Name"; break;
                case 2: title_selected = 2; lblTitle.Text = "Phone_Number"; break;
                case 3: title_selected = 3; lblTitle.Text = "Technical_Name"; break;
                case 4: title_selected = 4; lblTitle.Text = "Device_Model"; break;
                case 5: title_selected = 5; lblTitle.Text = "Device_Color"; break;
                case 6: title_selected = 6; lblTitle.Text = "Device_imei_1"; break;
                case 7: title_selected = 7; lblTitle.Text = "Device_imei_2"; break;
                case 8: title_selected = 8; lblTitle.Text = "Device_Error"; break;
                case 9: title_selected = 9; lblTitle.Text = "Password_Lock"; break;
                case 10: title_selected = 10; lblTitle.Text = "Sim_Card"; break;
                case 11: title_selected = 11; lblTitle.Text = "Sd_Card"; break;
                case 12: title_selected = 12; lblTitle.Text = "Amount"; break;

            }


        }
        }
        }



//    }
//}
