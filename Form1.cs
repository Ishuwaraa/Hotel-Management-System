using HMS.User_Control;
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
    public partial class Form1 : Form
    {
        private string userName;
        public Form1(string userName)
        {
            InitializeComponent();
            this.userName = userName;

        }

        Form2 f = new Form2();

        private void button2_Click(object sender, EventArgs e)
        {
            f.AddRoom(); // Call the method on Form2
            f.Show();
            this.Hide();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Welcome " + this.userName + "!";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            f.CusReg(); 
            f.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            f.CheckOut(); 
            f.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            f.Emp(); 
            f.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            f.CusDet(); 
            f.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            f.CusRev(); 
            f.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FormAdminLogin obj = new FormAdminLogin();
            obj.Show();
            this.Hide();
        }
    }
}
