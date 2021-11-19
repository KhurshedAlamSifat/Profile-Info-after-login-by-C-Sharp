
namespace Profile_Info
{
    partial class Profile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profile));
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LoginButton = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.namelbl = new System.Windows.Forms.Label();
            this.PPlbl = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.emaillbl = new System.Windows.Forms.Label();
            this.doblbl = new System.Windows.Forms.Label();
            this.genderlbl = new System.Windows.Forms.Label();
            this.mobileblb = new System.Windows.Forms.Label();
            this.countrylbl = new System.Windows.Forms.Label();
            this.citylbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PPlbl)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkCyan;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.button1.Location = new System.Drawing.Point(1318, -1);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "x";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.LoginButton);
            this.panel1.Location = new System.Drawing.Point(339, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(699, 631);
            this.panel1.TabIndex = 4;
            // 
            // LoginButton
            // 
            this.LoginButton.Animated = true;
            this.LoginButton.AutoRoundedCorners = true;
            this.LoginButton.BackColor = System.Drawing.Color.Transparent;
            this.LoginButton.BorderRadius = 14;
            this.LoginButton.CheckedState.Parent = this.LoginButton;
            this.LoginButton.CustomImages.Parent = this.LoginButton;
            this.LoginButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.LoginButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.LoginButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.LoginButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.LoginButton.DisabledState.Parent = this.LoginButton;
            this.LoginButton.FillColor = System.Drawing.Color.DarkCyan;
            this.LoginButton.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.LoginButton.ForeColor = System.Drawing.Color.White;
            this.LoginButton.HoverState.Parent = this.LoginButton;
            this.LoginButton.IndicateFocus = true;
            this.LoginButton.Location = new System.Drawing.Point(32, 576);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.ShadowDecoration.Parent = this.LoginButton;
            this.LoginButton.Size = new System.Drawing.Size(95, 31);
            this.LoginButton.TabIndex = 6;
            this.LoginButton.Text = "LOGOUT";
            this.LoginButton.UseTransparentBackground = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.namelbl);
            this.panel2.Controls.Add(this.PPlbl);
            this.panel2.Location = new System.Drawing.Point(23, 113);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(313, 405);
            this.panel2.TabIndex = 7;
            // 
            // namelbl
            // 
            this.namelbl.AutoSize = true;
            this.namelbl.BackColor = System.Drawing.Color.Transparent;
            this.namelbl.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namelbl.ForeColor = System.Drawing.Color.White;
            this.namelbl.Location = new System.Drawing.Point(13, 326);
            this.namelbl.Name = "namelbl";
            this.namelbl.Size = new System.Drawing.Size(75, 25);
            this.namelbl.TabIndex = 88;
            this.namelbl.Text = "Name";
            this.namelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PPlbl
            // 
            this.PPlbl.BackColor = System.Drawing.Color.Transparent;
            this.PPlbl.Image = ((System.Drawing.Image)(resources.GetObject("PPlbl.Image")));
            this.PPlbl.Location = new System.Drawing.Point(37, 34);
            this.PPlbl.Name = "PPlbl";
            this.PPlbl.Size = new System.Drawing.Size(240, 240);
            this.PPlbl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PPlbl.TabIndex = 87;
            this.PPlbl.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.citylbl);
            this.panel3.Controls.Add(this.countrylbl);
            this.panel3.Controls.Add(this.mobileblb);
            this.panel3.Controls.Add(this.genderlbl);
            this.panel3.Controls.Add(this.doblbl);
            this.panel3.Controls.Add(this.emaillbl);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(364, 113);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(313, 405);
            this.panel3.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(9, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 23);
            this.label3.TabIndex = 91;
            this.label3.Text = "Gender:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(9, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 23);
            this.label4.TabIndex = 90;
            this.label4.Text = "Date of Birth:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(9, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 23);
            this.label5.TabIndex = 89;
            this.label5.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 23);
            this.label2.TabIndex = 92;
            this.label2.Text = "Mobile:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(9, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 23);
            this.label6.TabIndex = 93;
            this.label6.Text = "Country:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(9, 329);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 23);
            this.label7.TabIndex = 94;
            this.label7.Text = "City:";
            // 
            // emaillbl
            // 
            this.emaillbl.AutoSize = true;
            this.emaillbl.BackColor = System.Drawing.Color.Transparent;
            this.emaillbl.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emaillbl.ForeColor = System.Drawing.Color.White;
            this.emaillbl.Location = new System.Drawing.Point(81, 51);
            this.emaillbl.Name = "emaillbl";
            this.emaillbl.Size = new System.Drawing.Size(21, 23);
            this.emaillbl.TabIndex = 95;
            this.emaillbl.Text = "?";
            // 
            // doblbl
            // 
            this.doblbl.AutoSize = true;
            this.doblbl.BackColor = System.Drawing.Color.Transparent;
            this.doblbl.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doblbl.ForeColor = System.Drawing.Color.White;
            this.doblbl.Location = new System.Drawing.Point(140, 101);
            this.doblbl.Name = "doblbl";
            this.doblbl.Size = new System.Drawing.Size(21, 23);
            this.doblbl.TabIndex = 96;
            this.doblbl.Text = "?";
            // 
            // genderlbl
            // 
            this.genderlbl.AutoSize = true;
            this.genderlbl.BackColor = System.Drawing.Color.Transparent;
            this.genderlbl.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderlbl.ForeColor = System.Drawing.Color.White;
            this.genderlbl.Location = new System.Drawing.Point(113, 159);
            this.genderlbl.Name = "genderlbl";
            this.genderlbl.Size = new System.Drawing.Size(21, 23);
            this.genderlbl.TabIndex = 97;
            this.genderlbl.Text = "?";
            // 
            // mobileblb
            // 
            this.mobileblb.AutoSize = true;
            this.mobileblb.BackColor = System.Drawing.Color.Transparent;
            this.mobileblb.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobileblb.ForeColor = System.Drawing.Color.White;
            this.mobileblb.Location = new System.Drawing.Point(94, 214);
            this.mobileblb.Name = "mobileblb";
            this.mobileblb.Size = new System.Drawing.Size(21, 23);
            this.mobileblb.TabIndex = 98;
            this.mobileblb.Text = "?";
            // 
            // countrylbl
            // 
            this.countrylbl.AutoSize = true;
            this.countrylbl.BackColor = System.Drawing.Color.Transparent;
            this.countrylbl.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countrylbl.ForeColor = System.Drawing.Color.White;
            this.countrylbl.Location = new System.Drawing.Point(94, 269);
            this.countrylbl.Name = "countrylbl";
            this.countrylbl.Size = new System.Drawing.Size(21, 23);
            this.countrylbl.TabIndex = 99;
            this.countrylbl.Text = "?";
            // 
            // citylbl
            // 
            this.citylbl.AutoSize = true;
            this.citylbl.BackColor = System.Drawing.Color.Transparent;
            this.citylbl.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.citylbl.ForeColor = System.Drawing.Color.White;
            this.citylbl.Location = new System.Drawing.Point(67, 329);
            this.citylbl.Name = "citylbl";
            this.citylbl.Size = new System.Drawing.Size(21, 23);
            this.citylbl.TabIndex = 100;
            this.citylbl.Text = "?";
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1350, 711);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Profile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profile";
            this.Load += new System.EventHandler(this.Profile_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PPlbl)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button LoginButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label namelbl;
        private System.Windows.Forms.PictureBox PPlbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label citylbl;
        private System.Windows.Forms.Label countrylbl;
        private System.Windows.Forms.Label mobileblb;
        private System.Windows.Forms.Label genderlbl;
        private System.Windows.Forms.Label doblbl;
        private System.Windows.Forms.Label emaillbl;
    }
}