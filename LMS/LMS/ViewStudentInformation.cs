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
    public partial class ViewStudentInformation : Form
    {
        public ViewStudentInformation()
        {
            InitializeComponent();
        }

        private void txtSearchEnrollement_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchEnrollement.Text != "")
            {   label1.Visible = false;
                Image image = Image.FromFile("C:\\Users\\hp\\Downloads\\oop lab project.vs\\Liberay Management System Icon and Images\\Liberay Management System\\search1.gif");
                pictureBox1.Image = image;

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-VPBEN25\\SQLEXPRESS;Initial Catalog=library;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from NewStudent where enroll LIKE '"+txtSearchEnrollement.Text+"%' ";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                dataGridView1.DataSource = DS.Tables[0];
            }
            else
            {
                label1.Visible = true;
                Image image = Image.FromFile("C:\\Users\\hp\\Downloads\\oop lab project.vs\\Liberay Management System Icon and Images\\Liberay Management System\\search.gif");
                pictureBox1.Image = image;

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-VPBEN25\\SQLEXPRESS;Initial Catalog=library;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from NewStudent";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                dataGridView1.DataSource = DS.Tables[0];
            }
        }

        private void ViewStudentInformation_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-VPBEN25\\SQLEXPRESS;Initial Catalog=library;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from NewStudent";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            dataGridView1.DataSource = DS.Tables[0];
        }

        int bid;
        Int64 rowid;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                bid = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            panel2.Visible=true;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-VPBEN25\\SQLEXPRESS;Initial Catalog=library;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from NewStudent where stuid = "+bid+" ";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            rowid = Int64.Parse(DS.Tables[0].Rows[0][0].ToString());

            txtSName.Text = DS.Tables[0].Rows[0][1].ToString();
            txtEnrollment.Text = DS.Tables[0].Rows[0][2].ToString();
            txtDepartment.Text = DS.Tables[0].Rows[0][3].ToString();    
            txtSemester.Text = DS.Tables[0].Rows[0][4].ToString();
            txtContact.Text = DS.Tables[0].Rows[0][5].ToString();
            txtEmail.Text = DS.Tables[0].Rows[0][6].ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string sname = txtSName.Text;
            string enroll = txtEnrollment.Text;
            string dep = txtDepartment.Text;
            string sem = txtSemester.Text;
            Int64 contact = Int64.Parse(txtContact.Text);
            string semail = txtEmail.Text;

            if (MessageBox.Show("Data will be Updated. Confirm?", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-VPBEN25\\SQLEXPRESS;Initial Catalog=library;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "update NewStudent set sname = '" + sname + "', enroll = '" + enroll + "', dep = '" + dep + "', sem = '" + sem + "', contact = '" + contact + "', email = '" + semail + "' where stuid = " + rowid + " ";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                ViewStudentInformation_Load(this, null);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearchEnrollement.Clear();
            ViewStudentInformation_Load(this, null);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data will be Deleted. Are You Sure?", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-VPBEN25\\SQLEXPRESS;Initial Catalog=library;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "delete from NewStudent where stuid = " + rowid + " ";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                ViewStudentInformation_Load(this, null);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Unsaved Data will be lost.","Are You Sure?",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close(); 
            }
        }
    }
}
