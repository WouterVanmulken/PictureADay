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
    public partial class PopUpForm : Form
    {
        public string latestName;
        public string latestAge;
        public PopUpForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            latestName = popUpFormNaamTxtBox.Text;
            latestAge = popUpFormLeeftijdNud.Value.ToString();
            
        }
    }
}
