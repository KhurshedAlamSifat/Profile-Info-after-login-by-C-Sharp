using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Profile_Info
{
    public partial class SingUpPage : Form
    {
        public SingUpPage()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SingUpPage_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(120, 10, 50, 50);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            new WelcomePage().Show();
            this.Hide();
        }

        private void buttonUploadDP_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select image";
            ofd.Filter = "Image File (.png;.jpg) | *.png; *.jpg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                PictureBoxSetDP.Image = new Bitmap(ofd.FileName);
            }
        }
        string connectionString = "Data Source=ASUS-SIFAT;Initial Catalog=ProfileInfo;Integrated Security=True";
        
        private void SingupButton_Click(object sender, EventArgs e)
        {
            if (textFullname.Text != "" && textEmail.Text != "" && DateTimePickerDOB.Text != "" && genderComboBox.Text != "" && textMobile.Text != "" && textCountry.Text != "" && textCity.Text != "" && textSetPass.Text != "" && textConfirmPass.Text != "")

            {
                string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
                if (Regex.IsMatch(textEmail.Text, pattern))

                {
                    if (textConfirmPass.Text == textSetPass.Text)

                    {
                        SqlConnection con = new SqlConnection(connectionString);
                        con.Open();
                        SqlCommand cmd = con.CreateCommand();
                        var Picture = new ImageConverter().ConvertTo(PictureBoxSetDP.Image, typeof(Byte[]));
                        cmd.Parameters.AddWithValue("@Picture", Picture);
                        cmd.CommandText = "insert into Profile_Info(Name, Email, DOB, Gender, Mobile, Country, City, SetPass, Picture) values('" + textFullname.Text + "', '" + textEmail.Text + "', '" + DateTimePickerDOB.Text + "', '" + genderComboBox.Text + "', '" + textMobile.Text + "', '" + textCountry.Text + "', '" + textCity.Text + "', '" + textSetPass.Text + "', @Picture)";
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("SignUp done!");
                            new WelcomePage().Show();
                            this.Hide();
                        }
                        else { MessageBox.Show("Sign Up Error!"); }
                        con.Close();
                    }
                    else
                    {
                        MessageBox.Show("Please set your password correctly!");
                    }
                }
                else
                {
                    MessageBox.Show("Please provide valide Email ID !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please fill all required fields");
            }
        }

        private void checkBoxPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPass.Checked)
            {
                textSetPass.UseSystemPasswordChar = false;
                textConfirmPass.UseSystemPasswordChar = false;
            }
            else
            {
                textSetPass.UseSystemPasswordChar = true;
                textConfirmPass.UseSystemPasswordChar = true;
            }
        }
    }
}
