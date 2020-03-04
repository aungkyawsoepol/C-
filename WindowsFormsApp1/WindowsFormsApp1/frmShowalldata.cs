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
    public partial class frmShowalldata : Form
    {
        public frmShowalldata()
        {
            InitializeComponent();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            funShowalldata();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmShowalldata_Load(object sender, EventArgs e)
        {
            funShowalldata();

        }
        DataSet ds = new DataSet();
        MySqlDataAdapter adapter;
        MySqlCommandBuilder bdrcmd;
        public void funShowalldata()
        {
            try
            {

                MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root");
                adapter = new MySqlDataAdapter("Select * from student.phone_service_table", con);
                bdrcmd = new MySqlCommandBuilder(adapter);
                con.Open();
               // DataSet ds = new DataSet();
                adapter.Fill(ds, "student.phone_service_table");
                dgvServicedata.DataSource = ds.Tables[0];
                con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            //try
            //{

            //    MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root");
            //    MySqlDataAdapter adapter = new MySqlDataAdapter("Select * from student.phone_service_table", con);
            //    con.Open();
            //    DataSet ds = new DataSet();
            //    adapter.Fill(ds, "student.phone_service_table");
            //    dgvServicedata.DataSource = ds.Tables[0];
            //    con.Close();
            //}
            //   catch (Exception ex)
            //{

            //    MessageBox.Show(ex.Message);
            //}
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dgvServicedata.DataSource = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do You Want To Remove This Row?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes) 
            {
                dgvServicedata.Rows.RemoveAt(dgvServicedata.SelectedRows[0].Index);
                adapter.Update(ds.Tables[0]);
            }
        }
    }
}
