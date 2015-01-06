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

        int PersonIdCounter = 1;


        public PopUpForm()
        {
            InitializeComponent();
            RefreshForm();
        }


        private void addBtn_Click(object sender, EventArgs e)
        {

             int nummer = 0;
            if (tbName.Text.Length == 0 )
            {
                MessageBox.Show("Please enter a valid Name");
            }
            else if (!int.TryParse(tbAge.Text, out nummer) && nummer<=130)
            {
                MessageBox.Show("Please enter a valid Age");
            }
            else if (tbAge.Text.Length >= 4)
            {
                MessageBox.Show("Please enter a valid Age");
            }
            else if (cbGender.Text != "Male" && cbGender.Text != "Female")
            {
                MessageBox.Show("Please enter a valid Gender");
            }
            else
            {
                while (Person.VoegToe(PersonIdCounter, Convert.ToString(tbName.Text), Convert.ToInt32(tbAge.Text), Convert.ToString(cbGender.Text)) == false)
                {
                    PersonIdCounter++; 
                }
            }
            RefreshForm();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (lbPeople.SelectedIndex >= 0)
            {
                Person.Verwijder(lbPeople.SelectedItem as Person);
                RefreshForm();
            }
        }
        
        private void RefreshForm()
        {
            lbPeople.Items.Clear();

            foreach (Person persoon in Person.Laden())
            {
                lbPeople.Items.Add(persoon);
            }
            groupBox1.Text = "People :" + lbPeople.Items.Count;
        }

    }
}
