using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS
{
    public partial class AddBooks : Form
    {
        public AddBooks()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtBookName.Text != "" && txtAuthor.Text != "" && txtPublication.Text != "" && txtPrice.Text != "" && txtQuantity.Text != "")
            {
                string bname = txtBookName.Text;
                string bauthor = txtAuthor.Text;
                string publication = txtPublication.Text;
                string pdate = dateTimePicker1.Text;
                Int64 price = Int64.Parse(txtPrice.Text);
                Int64 quan = Int64.Parse(txtQuantity.Text);

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-VPBEN25\\SQLEXPRESS;Initial Catalog=library;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = "insert into NewBook(bName,bAuthor,bPubl,bPDate,bPrice,bQuan) values ('" + bname + "', '" + bauthor + "', '" + publication + "', '" + pdate + "', " + price + ", " + quan + " )";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data Saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBookName.Clear();
                txtAuthor.Clear();
                txtPublication.Clear();
                txtPrice.Clear();
                txtQuantity.Clear();
            }
            else
            {
                MessageBox.Show("Empty Field Not Allowed","Warning",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This will Delete your Unsaved Data", "Are you sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
