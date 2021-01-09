namespace WindowsFormsApp3
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ph = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.Year = new System.Windows.Forms.NumericUpDown();
            this.Day = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Month = new System.Windows.Forms.DomainUpDown();
            this.FN = new System.Windows.Forms.TextBox();
            this.LN = new System.Windows.Forms.TextBox();
            this.MN = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.ad2 = new System.Windows.Forms.TextBox();
            this.ad1 = new System.Windows.Forms.TextBox();
            this.City = new System.Windows.Forms.TextBox();
            this.State = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.ep = new System.Windows.Forms.ErrorProvider(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.warn = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Year)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Day)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(678, 94);
            this.label1.TabIndex = 0;
            this.label1.Text = "Business Loan Application";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Personal Information";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name of Applicant :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(233, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "First Name";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(502, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Last Name";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(366, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Middle Name";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 18);
            this.label7.TabIndex = 9;
            this.label7.Text = "E-mail of Applicant :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(233, 220);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "example@example.com";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 287);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(220, 18);
            this.label9.TabIndex = 14;
            this.label9.Text = "Phone number of Applicant :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // ph
            // 
            this.ph.BeepOnError = true;
            this.ph.Location = new System.Drawing.Point(322, 288);
            this.ph.Mask = "(999) 000-0000";
            this.ph.Name = "ph";
            this.ph.Size = new System.Drawing.Size(253, 22);
            this.ph.TabIndex = 16;
            this.ph.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox6_MaskInputRejected);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label10.Location = new System.Drawing.Point(319, 312);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(199, 17);
            this.label10.TabIndex = 17;
            this.label10.Text = "Area Code   -   Phone Number";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(13, 360);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(174, 18);
            this.label13.TabIndex = 20;
            this.label13.Text = "Address of Applicant *";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(13, 578);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(208, 18);
            this.label14.TabIndex = 31;
            this.label14.Text = "Date of Birth of Applicant *";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Year
            // 
            this.Year.Location = new System.Drawing.Point(233, 630);
            this.Year.Maximum = new decimal(new int[] {
            2021,
            0,
            0,
            0});
            this.Year.Minimum = new decimal(new int[] {
            1920,
            0,
            0,
            0});
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(68, 22);
            this.Year.TabIndex = 32;
            this.Year.Value = new decimal(new int[] {
            2021,
            0,
            0,
            0});
            // 
            // Day
            // 
            this.Day.Location = new System.Drawing.Point(161, 630);
            this.Day.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.Day.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Day.Name = "Day";
            this.Day.Size = new System.Drawing.Size(49, 22);
            this.Day.TabIndex = 34;
            this.Day.Value = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.Day.ValueChanged += new System.EventHandler(this.Day_ValueChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label15.Location = new System.Drawing.Point(19, 418);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(102, 17);
            this.label15.TabIndex = 35;
            this.label15.Text = "Street Address";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label17.Location = new System.Drawing.Point(233, 655);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(38, 17);
            this.label17.TabIndex = 37;
            this.label17.Text = "Year";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label18.Location = new System.Drawing.Point(158, 655);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(33, 17);
            this.label18.TabIndex = 38;
            this.label18.Text = "Day";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label19.Location = new System.Drawing.Point(19, 655);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(47, 17);
            this.label19.TabIndex = 39;
            this.label19.Text = "Month";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label22.Location = new System.Drawing.Point(179, 531);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(108, 17);
            this.label22.TabIndex = 42;
            this.label22.Text = "State / Province";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label23.Location = new System.Drawing.Point(19, 531);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(31, 17);
            this.label23.TabIndex = 43;
            this.label23.Text = "City";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label24.Location = new System.Drawing.Point(19, 474);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(145, 17);
            this.label24.TabIndex = 44;
            this.label24.Text = "Street Address Line 2";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(546, 703);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 33);
            this.button1.TabIndex = 45;
            this.button1.Text = "Finish";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Month
            // 
            this.Month.Location = new System.Drawing.Point(19, 630);
            this.Month.Name = "Month";
            this.Month.Size = new System.Drawing.Size(120, 22);
            this.Month.TabIndex = 46;
            this.Month.Text = "domainUpDown1";
            this.Month.SelectedItemChanged += new System.EventHandler(this.domainUpDown1_SelectedItemChanged);
            // 
            // FN
            // 
            this.FN.Location = new System.Drawing.Point(236, 110);
            this.FN.Name = "FN";
            this.FN.Size = new System.Drawing.Size(100, 22);
            this.FN.TabIndex = 47;
            // 
            // LN
            // 
            this.LN.Location = new System.Drawing.Point(505, 110);
            this.LN.Name = "LN";
            this.LN.Size = new System.Drawing.Size(100, 22);
            this.LN.TabIndex = 48;
            // 
            // MN
            // 
            this.MN.Location = new System.Drawing.Point(369, 110);
            this.MN.Name = "MN";
            this.MN.Size = new System.Drawing.Size(100, 22);
            this.MN.TabIndex = 49;
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(233, 195);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(285, 22);
            this.Email.TabIndex = 50;
            this.toolTip1.SetToolTip(this.Email, "Enter Your E-Mail");
            // 
            // ad2
            // 
            this.ad2.Location = new System.Drawing.Point(19, 449);
            this.ad2.Name = "ad2";
            this.ad2.Size = new System.Drawing.Size(311, 22);
            this.ad2.TabIndex = 51;
            // 
            // ad1
            // 
            this.ad1.Location = new System.Drawing.Point(19, 393);
            this.ad1.Name = "ad1";
            this.ad1.Size = new System.Drawing.Size(311, 22);
            this.ad1.TabIndex = 52;
            // 
            // City
            // 
            this.City.Location = new System.Drawing.Point(19, 506);
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(151, 22);
            this.City.TabIndex = 53;
            // 
            // State
            // 
            this.State.Location = new System.Drawing.Point(179, 506);
            this.State.Name = "State";
            this.State.Size = new System.Drawing.Size(151, 22);
            this.State.TabIndex = 54;
            // 
            // ep
            // 
            this.ep.ContainerControl = this;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(401, 703);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 33);
            this.button2.TabIndex = 55;
            this.button2.Text = "Retry";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // warn
            // 
            this.warn.AutoSize = true;
            this.warn.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warn.ForeColor = System.Drawing.Color.Red;
            this.warn.Location = new System.Drawing.Point(7, 703);
            this.warn.Name = "warn";
            this.warn.Size = new System.Drawing.Size(275, 17);
            this.warn.TabIndex = 56;
            this.warn.Text = "Please Complete Your Application *";
            this.warn.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(675, 748);
            this.Controls.Add(this.warn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.State);
            this.Controls.Add(this.City);
            this.Controls.Add(this.ad1);
            this.Controls.Add(this.ad2);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.MN);
            this.Controls.Add(this.LN);
            this.Controls.Add(this.FN);
            this.Controls.Add(this.Month);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.Day);
            this.Controls.Add(this.Year);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ph);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Business Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Year)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Day)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox ph;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown Year;
        private System.Windows.Forms.NumericUpDown Day;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DomainUpDown Month;
        private System.Windows.Forms.TextBox State;
        private System.Windows.Forms.TextBox City;
        private System.Windows.Forms.TextBox ad1;
        private System.Windows.Forms.TextBox ad2;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox MN;
        private System.Windows.Forms.TextBox LN;
        private System.Windows.Forms.TextBox FN;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ErrorProvider ep;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label warn;
    }
}

