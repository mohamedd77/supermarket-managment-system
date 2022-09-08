using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket_Management_System
{
    public partial class Reportform1 : Form
    {
        CrystalReport1 CR;
        public Reportform1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            crystalReportViewer1.ReportSource = CR;
        }

        private void Reportform1_Load(object sender, EventArgs e)
        {
            CR = new CrystalReport1();
        }
    }
}
