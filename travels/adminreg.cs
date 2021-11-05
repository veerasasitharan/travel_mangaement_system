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
   
    public partial class adminreg : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LENOVO\SQLEXPRESS;Initial Catalog=sasi;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        
        public adminreg()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "insert into tab (adname,admail,adpass) values('"+textBox1.Text+"','"+textBox2.Text+"','"+textBox3.Text+"')";
            cmd.Connection = con;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Registered successfully");
        }
    }
}
