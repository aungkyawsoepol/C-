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
namespace MySqlCURD
{
    public partial class Form1 : Form
    {
        String ConnectionString = @"Server=localhost;Database=bookdb;Uid=root;";
        int BookID = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Clear();
            GridFill();
        }
        void Clear()
        {
            txtBookName.Text = txtAuthor.Text = txtDescription.Text = txtSearch.Text = "";
            BookID = 0;
            btnSave.Text = "Save";
            btnDelete.Enabled = false;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            MySqlConnection mysqlcon = new MySqlConnection(ConnectionString);

            {

                mysqlcon.Open();
                MySqlCommand mySqlcmd = new MySqlCommand("BookAddOrEdit", mysqlcon);
                mySqlcmd.CommandType = CommandType.StoredProcedure;
                // cmd.Parameters.AddWithValue
                //cmd.Parameters.AddWithValue("_BookID",);
                mySqlcmd.Parameters.AddWithValue("_BookID", BookID);
                mySqlcmd.Parameters.AddWithValue("_BookName", txtBookName.Text.Trim());
                mySqlcmd.Parameters.AddWithValue("_Author", txtAuthor.Text.Trim());
                mySqlcmd.Parameters.AddWithValue("_Description", txtDescription.Text.Trim());
                mySqlcmd.ExecuteNonQuery();
                MessageBox.Show("Submitted Successfully");
                Clear();
                GridFill();

            }


        }

        void GridFill()
        {
            MySqlConnection mysqlcon = new MySqlConnection(ConnectionString);
            // MySqlConnection mysqlCon = new MySqlConnection(ConectionString) ;
            mysqlcon.Open();
            MySqlDataAdapter sqlDa = new MySqlDataAdapter("BookViewAll", mysqlcon);
            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dtblbook = new DataTable();
            sqlDa.Fill(dtblbook);
            dgvBook.DataSource = dtblbook;
            dgvBook.Columns[0].Visible = false;
        }

        private void dgvBook_DoubleClick(object sender, EventArgs e)
        {
            if (dgvBook.CurrentRow.Index != -1)
            {
                txtBookName.Text = dgvBook.CurrentRow.Cells[1].Value.ToString();
                txtAuthor.Text = dgvBook.CurrentRow.Cells[2].Value.ToString();
                txtDescription.Text = dgvBook.CurrentRow.Cells[3].Value.ToString();
            }   BookID = Convert.ToInt32(dgvBook.CurrentRow.Cells[0].Value.ToString());
            btnSave.Text = "Update";
            btnDelete.Enabled = Enabled;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            {
                txtBookName.Text = dgvBook.CurrentRow.Cells[1].Value.ToString();
                txtAuthor.Text = dgvBook.CurrentRow.Cells[2].Value.ToString();
                txtDescription.Text = dgvBook.CurrentRow.Cells[3].Value.ToString();
            }
            BookID = Convert.ToInt32(dgvBook.CurrentRow.Cells[0].Value.ToString());
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            MySqlConnection mysqlcon = new MySqlConnection(ConnectionString);
            {
                // MySqlConnection mysqlCon = new MySqlConnection(ConectionString) ;
                mysqlcon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("BookSearchByValue", mysqlcon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDa.SelectCommand.Parameters.AddWithValue("_SearchValue",txtSearch.Text);
                DataTable dtblbook = new DataTable();
                sqlDa.Fill(dtblbook);
                dgvBook.DataSource = dtblbook;
                dgvBook.Columns[0].Visible = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MySqlConnection mysqlcon = new MySqlConnection(ConnectionString);

            {

                mysqlcon.Open();
                MySqlCommand mySqlcmd = new MySqlCommand("BookDeleteByID", mysqlcon);
                mySqlcmd.CommandType = CommandType.StoredProcedure;
                // cmd.Parameters.AddWithValue
                //cmd.Parameters.AddWithValue("_BookID",);
                mySqlcmd.Parameters.AddWithValue("_BookID", BookID);
               // mySqlcmd.Parameters.AddWithValue("_BookName", txtBookName.Text.Trim());
               // mySqlcmd.Parameters.AddWithValue("_Author", txtAuthor.Text.Trim());
               // mySqlcmd.Parameters.AddWithValue("_Description", txtDescription.Text.Trim());
                mySqlcmd.ExecuteNonQuery();
                MessageBox.Show("Deleted Successfully");
                Clear();
                GridFill();

            }
        }
    }
} //private void Form1_Load (object sender,EventArgs e)
