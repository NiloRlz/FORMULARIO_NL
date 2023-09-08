using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inicio_de_sesion_2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        //holitas
        private void button1_Click(object sender, EventArgs e) => this.Close();

        private void button1_Click_1(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://admisionsenati.com/?gad=1&gclid=EAIaIQobChMIws6iypmcgQMVC-mRCh1M9ws5EAAYASAAEgIRs_D_BwE");
            Process.Start(sInfo);
        }
    }
}
