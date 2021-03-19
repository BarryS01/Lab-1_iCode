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
          
            dumpAmnt.Text = String.Empty;
            exQnty.Text = String.Empty;
            
            exAmnt.Text = String.Empty;
            dozerQnty.Text = String.Empty;
            
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
