using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace Supermarket_Management_System
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void form1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            payments f1 = new payments();
            f1.Show();
        }

        private void form2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cashier f2 = new cashier();
            f2.Show();
        }

        private void form3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            products f3 = new products();
            f3.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void menu_Load(object sender, EventArgs e)
        {

        }

        private void productsCrystalreportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportform1 f5 = new Reportform1();
            f5.Show();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reportform2 f6 = new reportform2();
            f6.Show();
        }
    }
}
