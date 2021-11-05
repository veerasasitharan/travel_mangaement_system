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
    public partial class adminlog : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=LENOVO\SQLEXPRESS;Initial Catalog=sasi;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        public adminlog()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd.CommandText="select * from tab where admail='"+textBox1.Text+"'and adpass='"+textBox2.Text+"'";
            cmd.Connection = con;
            con.Open();
            dr=cmd.ExecuteReader();
            
            if (dr.Read())
            {
                adminhome frm = new adminhome();
                this.Hide();
                frm.Show();
            }else
            {
                MessageBox.Show("Invalid Login");
            }
        }
    }
}
