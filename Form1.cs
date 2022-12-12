using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Managment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Searchbutton_Click(object sender, EventArgs e)
        {

        }

        private void clearbutton_Click(object sender, EventArgs e)
        {   
            txtProductID.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            cbMac.Checked = false;
            cbHpEnvy.Checked = false;
            cbChromebook.Checked = false;
            cbDellInspiron.Checked = false;

            rbOne.Checked = false;
            rbTwo.Checked = false;
            rbThree.Checked = false;
            rbFour.Checked = false;

            brandListBox.SelectedItems.Clear();
            outPutBox.Items.Clear();
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confrim if you want to exit", "Inventory_Managment", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(iExit == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void addItemsbutton_Click(object sender, EventArgs e)
        {
            List<string> itemsList = new List<string>();
            itemsList.Add("Mac");
            itemsList.Add("HP-Envy");
            itemsList.Add("Chromebook");
            itemsList.Add("Dell-Inspiron");

            MessageBox.Show("The List has " + itemsList.Count + " objects stored in it.");

            for (int index = 0; index < itemsList.Count; index++) 
            {
                MessageBox.Show(itemsList[index]); 
            }

        }

        private void DisplayList(List<string> itemsList)
        {
            foreach (string str in itemsList)
            {
                MessageBox.Show(str);
            }
        }

        private void productIDlabel_Click(object sender, EventArgs e)
        {

        }
    }

}
