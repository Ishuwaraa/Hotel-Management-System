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
    public partial class UC_CustomerRegistration : UserControl
    {
        public UC_CustomerRegistration()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Db\hotelMgt.mdf;Integrated Security=True;Connect Timeout=30");


        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox2.Text;
            string address = textBox4.Text;  
            string gender = comboBox1.Text;
            string dob = dateTimePicker1.Text;
            string checkIn = dateTimePicker2.Text;
            string checkOut = dateTimePicker3.Text;
            int phone;
            int.TryParse(textBox3.Text, out phone);
            int roomNum;
            int.TryParse(textBox5.Text, out roomNum);
            int price;
            int.TryParse(textBox6.Text, out price);

            if (name != "" && phone != 0 && address != "" && roomNum != 0 && price != 0 && gender != "" && comboBox2.Text != "" && comboBox3.Text != "" && dob != "" && checkIn != "" && checkOut != "")
            {
                //Data base code
                string qry = "insert into CustomerDetails(roomNum, name, phone, gender, dob, address, checkin, checkout, price) values" +
                    "('" + roomNum + "', '" + name + "', " + phone + ", '" + gender + "', '" + dob + "', '" + address + "','" + checkIn + "', '" + checkOut + "', " + price + ")";
                SqlCommand cmd = new SqlCommand(qry, conn);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    clearAll();

                    UC_CheckOut f1 = new UC_CheckOut();
                    f1.UC_CheckOut_Load(this, null);

                    UC_CustomerDetails f2 = new UC_CustomerDetails();
                    f2.UC_CustomerDetails_Load(this, null);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally { conn.Close(); }
            }
            else
            {
                MessageBox.Show("All Fields are Required");
            }

            /*try
            {
                int phone = int.Parse(textBox3.Text);
                int roomNum = int.Parse(textBox5.Text);
                int price = int.Parse(textBox6.Text);

                if (textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && comboBox1.Text != "" && comboBox2.Text != "" && comboBox3.Text != "" && dateTimePicker1.Text != "" && dateTimePicker2.Text != "" && dateTimePicker3.Text != "")
                {
                    //Data base code
                    string qry = "insert into CustomerDetails(roomNum, name, phone, gender, dob, address, checkin, checkout, price) values" +
                        "('" + roomNum + "', '" + name + "', " + phone + ", '" + gender + "', '" + dob + "', '" + address + "','" + checkIn + "', '" + checkOut + "', " + price + ")";
                    SqlCommand cmd = new SqlCommand(qry, conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    clearAll();

                    UC_CheckOut f1 = new UC_CheckOut();
                    f1.UC_CheckOut_Load(this, null);

                    UC_CustomerDetails f2 = new UC_CustomerDetails();
                    f2.UC_CustomerDetails_Load(this, null);
                    conn.Close();


                }
                else
                {
                    MessageBox.Show("All Fields are Required");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
        }
        public void clearAll()
        {
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            dateTimePicker1.ResetText();
            dateTimePicker2.ResetText();
            dateTimePicker3.ResetText();
        }

        private void UC_CustomerRegistration_Leave(object sender, EventArgs e)
        {//not in use
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {//not in use
        }

        private void label6_Click(object sender, EventArgs e)
        {//not in use
        }
    }
}
