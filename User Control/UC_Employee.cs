using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS.User_Control
{
    public partial class UC_Employee : UserControl
    {
        public UC_Employee()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Db\hotelMgt.mdf;Integrated Security=True;Connect Timeout=30");

        private void UC_Employee_Load(object sender, EventArgs e)
        {
            try
            {
                string qry = "select * from empDetails";
                SqlDataAdapter sda = new SqlDataAdapter(qry, conn);
                DataTable dTable = new DataTable();
                sda.Fill(dTable);

                dataGridView1.DataSource = dTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string pass = textBox2.Text;
            string mail = textBox4.Text;
            int phone;
            int.TryParse(textBox3.Text, out phone);

            if(name != "" && mail != "" && phone != 0)
            {
                string qry = "insert into empDetails values('" + name + "', '" + pass + "', '" + phone + "', '" + mail + "')";
                SqlCommand cmd = new SqlCommand(qry, conn);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    UC_Employee_Load(this, null);
                    clearAll();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally { conn.Close(); }
            }
            else
                MessageBox.Show("All fields are Required");


            /*if (int.TryParse(textBox3.Text, out int phone))
            {

                if (name != "" && mail != "")
                {
                    try
                    {
                        string qry = "insert into empDetails values('" + name + "', '" + pass + "', '" + phone + "', '" + mail + "')";
                        SqlCommand cmd = new SqlCommand(qry, conn);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        UC_Employee_Load(this, null);
                        clearAll();
                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        //MessageBox.Show("Enter Employee name");
                    }
                }
                else
                    MessageBox.Show("All fields Required");
            }
            else
            {
                MessageBox.Show("Invalid phone number format. Please enter a valid number.");
            }*/
        }

        public void clearAll()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void UC_Employee_Leave(object sender, EventArgs e)
        {
            clearAll(); //doesnt work?!
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string pass = textBox2.Text;
            string email = textBox4.Text;
            int phone;
            int.TryParse(textBox3.Text, out phone);

            if (name != "")
            {
                string qry = "update empDetails set pass = '" + pass + "', phone = '" + phone + "', email = '" + email + "' where fname = '" + name + "'";
                SqlCommand cmd = new SqlCommand(qry, conn);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    UC_Employee_Load(this, null);
                    clearAll();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally { conn.Close(); }

            }
            else
                MessageBox.Show("All fields are required!");

            /*if (int.TryParse(textBox3.Text, out int phone))
            {

                if (name != "")
                {
                    try
                    {
                        conn.Open();
                        string qry = "update empDetails set pass = '" + pass + "', phone = '" + phone + "', email = '" + email + "' where fname = '" + name + "'";
                        SqlCommand cmd = new SqlCommand(qry, conn);
                        cmd.ExecuteNonQuery();
                        UC_Employee_Load(this, null);
                        clearAll();
                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                    MessageBox.Show("All fields Required");
            }
            else
            {
                MessageBox.Show("Invalid phone number format. Please enter a valid number.");
            }*/
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id;
            int.TryParse(textBox5.Text, out id);

            if(id != 0)
            {
                string qry = "delete from empDetails where empId = '" + id + "'";
                SqlCommand cmd = new SqlCommand(qry, conn);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    UC_Employee_Load(this, null);

                    clearAll();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally { conn.Close(); }
            }
            else
            {
                MessageBox.Show("Enter an ID");
            }

            /*if (textBox5.Text != "")
            {
                try
                {
                    int id = int.Parse(textBox5.Text);
                    string qry = "delete from empDetails where empId = '" + id + "'";
                    SqlCommand cmd = new SqlCommand(qry, conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    UC_Employee_Load(this, null);

                    clearAll();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Enter an ID");
            }*/
        }
    }
}
