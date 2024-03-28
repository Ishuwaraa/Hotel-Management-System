using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Linq.Expressions;
using HMS;
using System.Security.Cryptography.X509Certificates;

namespace WindowsFormsApp4
{
    public partial class FormAdminLogin : System.Windows.Forms.Form
    {
        public FormAdminLogin()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Db\hotelMgt.mdf;Integrated Security=True;Connect Timeout=30");

        private void FormAdminLogin_Load(object sender, EventArgs e)
        {
            panelAdminLogin.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userName = textBox1.Text;
            Form1 form1 = new Form1(userName);
            string password = textBox2.Text;

            try
            {
                conn.Open();
                string qry = "select * from empDetails where fName = '" + textBox1.Text + "' and pass = '" + textBox2.Text + "' ";
                SqlDataAdapter sda = new SqlDataAdapter(qry, conn);

                DataTable dTable = new DataTable();
                sda.Fill(dTable);

                if(string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Please fill in all the fields.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if(dTable.Rows.Count > 0)
                {

                    //Form1 form1 = new Form1();
                    form1.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password.", "", MessageBoxButtons.OK ,MessageBoxIcon.Information);
                    textBox1.Text = "";
                    textBox2.Text = "";
                }
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Do you want to Exit?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(res == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Show();
            }
        }
    }
}
