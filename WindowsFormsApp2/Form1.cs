using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
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

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            firstName.Text = String.Empty;
            lastName.Text = String.Empty;
            strtAdd.Text = String.Empty;
            city.Text = String.Empty;
            state.Text = String.Empty;
            postal.Text = String.Empty;
            phn1.Text = String.Empty;
            phn2.Text = String.Empty;
            fax.Text = String.Empty;
            payMethod.Text = String.Empty;
            discount.Text = String.Empty;
            payDate.Text = String.Empty;
            dumpQnty.Text = String.Empty;
            dumpPrc.Text = String.Empty;
            dumpAmnt.Text = String.Empty;
            exQnty.Text = String.Empty;
            exPrc.Text = String.Empty;
            exAmnt.Text = String.Empty;
            dozerQnty.Text = String.Empty;
            dozerPrc.Text = String.Empty;
            dozerAmnt.Text = String.Empty;
            totalPrc.Text = String.Empty;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Show receipt
            Form2 receipt = new Form2(this);
            receipt.ShowDialog();

            // Show Name
            String fName = firstName.Text;
            String lName = lastName.Text;

            

        }
    }
}
