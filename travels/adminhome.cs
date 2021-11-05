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

namespace travels
{
    public partial class adminhome : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=LENOVO\SQLEXPRESS;Initial Catalog=sasi;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        public adminhome()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // this.Size = new Size(1000,0);
            panel1.Visible = true;

        }

        private void button3_Click(object sender, EventArgs e)
        {

            cmd.CommandText = "insert into driver (dname,dexp,dcharge) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')";
            cmd.Connection = con;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Saved successfully");
            textBox1.Text = textBox2.Text = textBox3.Text = "";

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {

            cmd.CommandText = "insert into vehicle (vname,vnum,vcap,vcharge) values('" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "')";
            cmd.Connection = con;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Saved successfully");
            textBox4.Text = textBox5.Text = textBox6.Text =textBox7.Text="";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }
    }
}
