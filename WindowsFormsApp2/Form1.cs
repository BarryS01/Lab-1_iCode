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

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        // Error Messages
        private void firstName_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(firstName.Text))
            {
                e.Cancel = true;
                firstName.Focus();
                fNameerror.SetError(firstName, "Please Enter First Name");
            }
            else
            {
                e.Cancel = false;
                fNameerror.SetError(firstName, null);
            }
        }

        private void lastName_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(lastName.Text))
            {
                e.Cancel = true;
                lastName.Focus();
                lNameerror.SetError(lastName, "Please Enter Last Name");
            }
            else
            {
                e.Cancel = false;
                lNameerror.SetError(lastName, null);
            }
        }

        private void strtAdd_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(strtAdd.Text))
            {
                e.Cancel = true;
                strtAdd.Focus();
                strtAddError.SetError(strtAdd, "Please Enter Street Address");
            }
            else
            {
                e.Cancel = false;
                strtAddError.SetError(strtAdd, null);
            }
        }

        private void city_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(city.Text))
            {
                e.Cancel = true;
                city.Focus();
                cityError.SetError(city, "Please Enter City");
            }
            else
            {
                e.Cancel = false;
                cityError.SetError(city, null);
            }
        }

        private void state_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(state.Text))
            {
                e.Cancel = true;
                state.Focus();
                stateError.SetError(state, "Please Enter State");
            }
            else
            {
                e.Cancel = false;
                stateError.SetError(state, null);
            }
        }

        private void postal_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(postal.Text))
            {
                e.Cancel = true;
                postal.Focus();
                postalError.SetError(postal, "Please Enter Postal");
            }
            else
            {
                e.Cancel = false;
                postalError.SetError(postal, null);
            }
        }

        private void phn1_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(phn1.Text))
            {
                e.Cancel = true;
                phn1.Focus();
                phn1Error.SetError(phn1, "Please Enter Phone Number");
            }
            else
            {
                e.Cancel = false;
                phn1Error.SetError(phn1, null);
            }
        }

        private void payMethod_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(payMethod.Text))
            {
                e.Cancel = true;
                payMethod.Focus();
                methodError.SetError(payMethod, "Please Enter Payment Method");
            }
            else
            {
                e.Cancel = false;
                methodError.SetError(payMethod, null);
            }
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
            dumpdis.Text = String.Empty;
            dumpAmnt.Text = String.Empty;
            exQnty.Text = String.Empty;
            exdis.Text = String.Empty;
            exAmnt.Text = String.Empty;
            dozerQnty.Text = String.Empty;
            dozerdis.Text = String.Empty;
            dozerAmnt.Text = String.Empty;
            totalPrc.Text = String.Empty;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled)){
                // Show receipt
                Form2 receipt = new Form2(this);
                receipt.ShowDialog();
            }

           

        }

        private void button3_Click(object sender, EventArgs e)
        {
            double truckQnty, excavQnty, dozeQnty;
            double truckPrice, excavPrice, dozePrice;
            double truckAmnt, excavAmnt, dozeAmnt;

            double truckdiscount, excavdiscount, dozediscount;

            truckQnty = Convert.ToDouble(dumpQnty.Text);
            excavQnty = Convert.ToDouble(exQnty.Text);
            dozeQnty = Convert.ToDouble(dozerQnty.Text);

            truckPrice = Convert.ToDouble(dumpPrc.Text);
            excavPrice = Convert.ToDouble(exPrc.Text);
            dozePrice = Convert.ToDouble(dozerPrc.Text);

            // Calculating Amount of Dump Truck
            if(truckQnty >= 2)
            {
                truckAmnt = truckQnty * truckPrice;
                truckdiscount = truckAmnt * 0.2;             //20% dicount
                double newTruckAmnt = truckAmnt - truckdiscount;

                dumpdis.Text = truckdiscount.ToString();
                dumpAmnt.Text = newTruckAmnt.ToString();
            }
            else
            {
                double newTruckAmnt = truckQnty * truckPrice;
                truckdiscount = 0;

                dumpdis.Text = truckdiscount.ToString();
                dumpAmnt.Text = newTruckAmnt.ToString();
            }

            // Calculating total Amount of Excavator
            if (excavQnty >= 2)
            {
                excavAmnt = excavQnty * excavPrice;
                excavdiscount = excavAmnt * 0.3;            // 30% discount
                double newExcavAmnt = excavAmnt - excavdiscount;

                exdis.Text = excavdiscount.ToString();
                exAmnt.Text = newExcavAmnt.ToString();
            }
            else
            {
                double newExcavAmnt = excavQnty * excavPrice;
                excavdiscount = 0;

                exdis.Text = excavdiscount.ToString();
                exAmnt.Text = newExcavAmnt.ToString();
            }

            // Calculating total Amount of Dozer
            if (dozeQnty >= 2)
            {
                dozeAmnt = dozeQnty * dozePrice;
                dozediscount = dozeAmnt * 0.3;           //30% discount
                double newDozeAmnt = dozeAmnt - dozediscount;

                dozerdis.Text = dozediscount.ToString();
                dozerAmnt.Text = newDozeAmnt.ToString();
            }
            else
            {
                double newDozeAmnt = dozeQnty * dozePrice;
                dozediscount = 0;

                dozerdis.Text = dozediscount.ToString();
                dozerAmnt.Text = newDozeAmnt.ToString();
            }

            // Instantiate new variables and assign to respective 
            // Convert total amounts to double from string
            // Calculating the total discount
            double dis1, dis2, dis3;

            dis1 = Convert.ToDouble(dumpdis.Text);
            dis2 = Convert.ToDouble(exdis.Text);
            dis3 = Convert.ToDouble(dozerdis.Text);

            double totaldis = dis1 + dis2 + dis3;
            //display in textbox
            discount.Text = totaldis.ToString();

            // Instantiate new variables and assign to respective 
            // Convert total amounts to double from string
            // Calculating Total Payment
            double truckTotal, exTotal, dozerTotal;

            truckTotal = Convert.ToDouble(dumpAmnt.Text);
            exTotal = Convert.ToDouble(exAmnt.Text);
            dozerTotal = Convert.ToDouble(dozerAmnt.Text);

            double totalPayment = truckTotal + exTotal + dozerTotal;
            // Display in textbox
            totalPrc.Text = totalPayment.ToString();
        }
    }
}
