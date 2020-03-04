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
    public partial class frmShowAll : Form
    {
        public frmShowAll()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmShowAll_Load(object sender, EventArgs e)
        {
            try
            {

                MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root");
                MySqlDataAdapter adapter = new MySqlDataAdapter("select * from student.phone_service_table", con);
                con.Open();
                DataSet ds = new DataSet();
                adapter.Fill(ds, "phone_service_table");
                dgvServicedata.DataSource = ds.Tables[0];
                con.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do You Want To Remove This Row?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes);

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmSearchBy_Title v = new frmSearchBy_Title();
            v.Show();
        }
    }
}
