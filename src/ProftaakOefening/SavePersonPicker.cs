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
    public partial class SavePersonPicker : Form
    {
        public int personSelected;
        public SavePersonPicker()
        {
            InitializeComponent();
            listBox1.Items.Clear();
        }

        private void SavePersonPicker_Load(object sender, EventArgs e)
        {
            foreach (Person persoon in Person.Laden())
            {
                listBox1.Items.Add(persoon);
            }
            groupBox1.Text = "People :" + listBox1.Items.Count;
            if (listBox1.Items.Count != -1) { listBox1.SetSelected(0, true); }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            personSelected = listBox1.SelectedIndex;
            string [] splitter =listBox1.GetItemText(personSelected).Split('0');
            Int32.TryParse(splitter[0], out personSelected);
        }
    }
}
