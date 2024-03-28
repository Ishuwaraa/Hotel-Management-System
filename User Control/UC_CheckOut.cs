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
    public partial class UC_CheckOut : UserControl
    {
        public UC_CheckOut()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Db\hotelMgt.mdf;Integrated Security=True;Connect Timeout=30");


        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            if (name != "")
            {
                string qry = "delete from CustomerDetails where name = '" + name + "'";
                SqlCommand cmd = new SqlCommand(qry, conn);            
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    UC_CheckOut_Load(this, null);
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
                MessageBox.Show("No customer is selected");
            }
            
            
        }
        public void clearAll()
        {
            textBox1.Text = "";
        }

        private void UC_CheckOut_Leave(object sender, EventArgs e)
        {
            clearAll();
        }

        public void UC_CheckOut_Load(object sender, EventArgs e)
        {
            try
            {
                string qry = "select * from CustomerDetails";
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

        private void button2_Click(object sender, EventArgs e)
        {
            UC_CheckOut_Load(this, null);
        }
    }
}
