using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Profile_Info
{
    public partial class WelcomePage : Form
    {
        public WelcomePage()
        {
            InitializeComponent();
        }
        public static string nm;
        public static string em;
        public static string dob;
        public static string gdr;
        public static string mbl;
        public static string cntry;
        public static string city;
        public static Image dp;
        public static string pass;

        private void WelcomePage_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(120, 10, 50, 50);
            //Welcome.BackColor = Color.FromArgb(0, 0, 0, 100);
            //label1.BackColor = Color.FromArgb(0, 0, 0, 100);
            //EmailText.BackColor = Color.FromArgb(200, 0, 0, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SingupButton_Click(object sender, EventArgs e)
        {
            new SingUpPage().Show();
            this.Hide();
        }
        public Image getPhoto(byte[] photo)
        {
            using (MemoryStream ms = new MemoryStream(photo))
            {
                return Image.FromStream(ms);
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (textEmaillog.Text != "" && textpasslog.Text != "")
            {
                string connectionString = "Data Source=ASUS-SIFAT;Initial Catalog=ProfileInfo;Integrated Security=True";
                SqlConnection connection = new SqlConnection(connectionString);

                SqlCommand cmd = new SqlCommand("select *FROM Profile_Info WHERE Email COLLATE Latin1_general_CS_AS = @Email  and SetPass COLLATE Latin1_general_CS_AS =@SetPass ", connection);

                connection.Open();
                cmd.Parameters.Add(new SqlParameter("Email ", textEmaillog.Text));
                cmd.Parameters.Add(new SqlParameter("SetPass", textpasslog.Text));

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sqlDataAdapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    nm = dt.Rows[0]["Name"].ToString();
                    em = dt.Rows[0]["Email"].ToString();
                    dob = dt.Rows[0]["DOB"].ToString();
                    gdr = dt.Rows[0]["Gender"].ToString();
                    mbl = dt.Rows[0]["Mobile"].ToString();
                    cntry = dt.Rows[0]["Country"].ToString();
                    city = dt.Rows[0]["City"].ToString();
                    dp = getPhoto((byte[])dt.Rows[0]["Picture"]);
                    // pass = dt.Rows[0]["SetPass"].ToString();
                    MessageBox.Show("LogIn successful !");
                    new Profile().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Log in failed,doesn't match email or Password", "Enter valide information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                connection.Close();
            }
            else { MessageBox.Show("Please insert your email or Password"); }
        }

        private void pictureBoxHidePass_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxHidePass_MouseClick(object sender, MouseEventArgs e)
        {
            textpasslog.UseSystemPasswordChar = false;
            pictureBoxHidePass.Visible = false;
            pictureBoxShowPass.Visible = true;
        }

        private void pictureBoxShowPass_MouseClick(object sender, MouseEventArgs e)
        {
            textpasslog.UseSystemPasswordChar = true;
            pictureBoxHidePass.Visible = true;
            pictureBoxShowPass.Visible = false;
        }

        private void textpasslog_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBoxHidePass.Visible = true;
            textpasslog.UseSystemPasswordChar = true;
        }

        private void textEmaillog_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBoxHidePass.Visible = false;
            pictureBoxShowPass.Visible = false;
        }
    }
}
