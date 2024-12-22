using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace LMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtUsername_MouseEnter(object sender, EventArgs e)
        {
          
        }

        private void txtUsername_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtUsername.Text == "Username")
            {
                txtUsername.Clear();
            }
        }

        private void txtPassword_MouseClick(object sender, MouseEventArgs e)
        {
            if(txtPassword.Text =="Password")
            {
                txtPassword.Clear();
                txtPassword.PasswordChar = '*';
            }
        }

        private void pictureBoxYoutube_Click(object sender, EventArgs e)
        {
            string url = "https://www.youtube.com/channel/UCO7UXa_dl8DoeTNxXbIt7PQ";
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = url;
            psi.UseShellExecute = true;
            Process.Start(psi);
             
        }

        private void pictureBoxFacebook_Click(object sender, EventArgs e)
        {
            string url = "https://www.facebook.com/BOOKXSTUFF1/";
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = url;
            psi.UseShellExecute = true;
            Process.Start(psi);
            
        }

        private void pictureBoxInsta_Click(object sender, EventArgs e)
        {
            string url = "https://www.instagram.com/e_book_library/";
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = url;
            psi.UseShellExecute = true;
            Process.Start(psi);
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-VPBEN25\\SQLEXPRESS ; database = library; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from  loginTable where username = '" + txtUsername.Text + "'and pass = '" + txtPassword.Text + "' ";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            if (ds.Tables[0].Rows.Count != 0)
            {
                this.Hide();
                Dashboard dsa = new Dashboard();
                dsa.Show();
            }
            else
            {
                MessageBox.Show("Wrong Username or Password","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }    
        }
    }
}