using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp4;

namespace HMS
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.BackColor = Color.FromArgb(7, 10, 82);
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
            button6.BackColor = Color.White;
            button7.BackColor = Color.White;
            button8.BackColor = Color.White;
            uC_AddRoom1.Visible = true;
            uC_AddRoom1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button2.BackColor = Color.White;
            button3.BackColor = Color.FromArgb(7, 10, 82);
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
            button6.BackColor = Color.White;
            button7.BackColor = Color.White;
            button8.BackColor = Color.White;
            uC_CustomerRegistration2.Visible = true;
            uC_CustomerRegistration2.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.FromArgb(7, 10, 82);
            button5.BackColor = Color.White;
            button6.BackColor = Color.White;
            button7.BackColor = Color.White;
            button8.BackColor = Color.White;
            uC_CheckOut1.Visible = true;
            uC_CheckOut1.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
            button5.BackColor = Color.FromArgb(7, 10, 82);
            button6.BackColor = Color.White;
            button7.BackColor = Color.White;
            button8.BackColor = Color.White;
            uC_CustomerDetails1.Visible = true;
            uC_CustomerDetails1.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
            button6.BackColor = Color.FromArgb(7, 10, 82);
            button7.BackColor = Color.White;
            button8.BackColor = Color.White;
            uC_Employee1.Visible = true;
            uC_Employee1.BringToFront();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
            button6.BackColor = Color.White;
            button7.BackColor = Color.FromArgb(7, 10, 82);
            button8.BackColor = Color.White;
            uC_CustomerReview1.Visible = true;
            uC_CustomerReview1.BringToFront();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
            button6.BackColor = Color.White;
            button7.BackColor = Color.White;
            button8.BackColor = Color.FromArgb(7, 10, 82);

            FormAdminLogin obj = new FormAdminLogin();
            obj.Show();
            this.Hide();
        }
        public void AddRoom()
        {
            button2.BackColor = Color.FromArgb(7, 10, 82);
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
            button6.BackColor = Color.White;
            button7.BackColor = Color.White;
            button8.BackColor = Color.White;
            uC_AddRoom1.Visible = true;
            uC_AddRoom1.BringToFront();
        }
        public void CusReg()
        {
            button2.BackColor = Color.White;
            button3.BackColor = Color.FromArgb(7, 10, 82);
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
            button6.BackColor = Color.White;
            button7.BackColor = Color.White;
            button8.BackColor = Color.White;
            uC_CustomerRegistration2.Visible = true;
            uC_CustomerRegistration2.BringToFront();
        }
        public void CheckOut()
        {
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.FromArgb(7, 10, 82);
            button5.BackColor = Color.White;
            button6.BackColor = Color.White;
            button7.BackColor = Color.White;
            button8.BackColor = Color.White;
            uC_CheckOut1.Visible = true;
            uC_CheckOut1.BringToFront();
        }
        public void Emp()
        {
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
            button6.BackColor = Color.FromArgb(7, 10, 82);
            button7.BackColor = Color.White;
            button8.BackColor = Color.White;
            uC_Employee1.Visible = true;
            uC_Employee1.BringToFront();
        }
        public void CusDet()
        {
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
            button5.BackColor = Color.FromArgb(7, 10, 82);
            button6.BackColor = Color.White;
            button7.BackColor = Color.White;
            button8.BackColor = Color.White;
            uC_CustomerDetails1.Visible = true;
            uC_CustomerDetails1.BringToFront();
        }
        public void CusRev()
        {
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
            button6.BackColor = Color.White;
            button7.BackColor = Color.FromArgb(7, 10, 82);
            button8.BackColor = Color.White;
            uC_CustomerReview1.Visible = true;
            uC_CustomerReview1.BringToFront();
        }
    }

}
