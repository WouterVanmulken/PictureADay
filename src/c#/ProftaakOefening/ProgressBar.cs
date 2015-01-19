using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProftaakOefening
{
    public partial class ProgressBar : Form
    {
        public int progres = 0;
        public ProgressBar()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = progresvariables.progres;
            label3.Text = progresvariables.progres.ToString();
            if (progressBar1.Value == 100) { this.DialogResult = DialogResult.OK; }
        }
    }
}
