using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DomainUpDown.DomainUpDownItemCollection collection = this.Month.Items;
            collection.Add("January");
            collection.Add("February");
            collection.Add("March");
            collection.Add("April");
            collection.Add("May");
            collection.Add("June");
            collection.Add("July");
            collection.Add("August");
            collection.Add("September");
            collection.Add("October");
            collection.Add("November");
            collection.Add("December");
            this.Month.Text = " ";
            
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void propertyGrid1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox6_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {
       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ep.Clear();

            bool isallTrue = true;
            if (FN.Text.Trim() == "")
            {
                ep.SetError(FN, "First Name is Empty");
                isallTrue = false;
            }
            if (MN.Text.Trim() == "")
            {
                ep.SetError(MN, "Middle Name is Empty");
                isallTrue = false;

            }
            if (LN.Text.Trim() == "")
            {
                ep.SetError(LN, "Last Name is Empty");
                isallTrue = false;

            }
            if (Email.Text.Trim() == "")
            {
                ep.SetError(Email, "Enter Your E-mail");
                isallTrue = false;

            }
            if (ph.Text.Trim() == "")
            {
                ep.SetError(ph, "Enter Your Phone Number");
                isallTrue = false;

            }
            if (ad1.Text.Trim() == "")
            {
                ep.SetError(ad1, "Enter Your Adress");
                isallTrue = false;

            }
            if (ad2.Text.Trim() == "")
            {
                ep.SetError(ad2, "Enter Your Adress Line2");
                isallTrue = false;

            }
            if (Day.Text.Trim() == "")
            {
                ep.SetError(Day, "Enter Your BirthDay");
                isallTrue = false;

            }
            if (City.Text.Trim() == "")
            {
                ep.SetError(City, "Enter Your City");
                isallTrue = false;

            }
            if (State.Text.Trim() == "")
            {
                ep.SetError(State, "Enter Your State\\Province");
                isallTrue = false;

            }
            if (Month.Text.Trim() == "")
            {
                ep.SetError(Month, "Enter Your BirthMonth");
                isallTrue = false;

            }
            if (Year.Text.Trim() == "")
            {
                ep.SetError(Year, "Enter Your BirthYear");
                isallTrue = false;

            }warn.Visible = true;
            if (isallTrue)
            {
                MessageBox.Show("Thank's Sir");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            warn.Visible = false;
            ep.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void Day_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
