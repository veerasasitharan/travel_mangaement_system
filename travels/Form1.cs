using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace travels
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void adminToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach(Form f in Application.OpenForms)
            {
                if (f.GetType() == typeof(adminreg))
                {
                    f.Activate();
                    return;
                }
            }
            adminreg frm = new adminreg();
            
            frm.MdiParent = this;
            frm.Show();
        }

        private void userToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach(Form f in Application.OpenForms)
            {
                if (f.GetType() == typeof(userreg))
                {
                    f.Activate();
                    return;
                }
            }
            userreg frm = new userreg();
            frm.MdiParent = this;
            frm.Show();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {

            foreach (Form f in Application.OpenForms)
            {
                if (f.GetType() == typeof(adminlog))
                {
                    f.Activate();
                    return;
                }
            }
            adminlog frm = new adminlog();
            frm.MdiParent = this;
            frm.Show();
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {

            foreach (Form f in Application.OpenForms)
            {
                if (f.GetType() == typeof(userrlog))
                {
                    f.Activate();
                    return;
                }
            }
            userrlog frm = new userrlog();
            frm.MdiParent = this;
            frm.Show();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
