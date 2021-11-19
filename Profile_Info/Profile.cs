using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Profile_Info
{
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(120, 10, 50, 50);
            panel2.BackColor = Color.FromArgb(120, 0, 0, 0);
            panel3.BackColor = Color.FromArgb(120, 0, 0, 0);
            PPlbl.Image = WelcomePage.dp;
            namelbl.Text = WelcomePage.nm;
            emaillbl.Text = WelcomePage.em;
            doblbl.Text = WelcomePage.dob;
            genderlbl.Text = WelcomePage.gdr;
            mobileblb.Text = WelcomePage.mbl;
            countrylbl.Text = WelcomePage.cntry;
            citylbl.Text = WelcomePage.city;
            
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            new WelcomePage().Show();
            this.Hide();
        }
    }
}
