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
    public partial class Form2 : Form
    {
        Form1 f1;
        public Form2(Form1 frm1)
        {
            InitializeComponent();
            this.f1 = frm1;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            customerName.Text = f1.firstName.Text+" "+f1.lastName.Text;
            customerAddress.Text = f1.strtAdd.Text+", "+f1.city.Text+", "+f1.state.Text;
            datePay.Text = f1.payDate.Text;
            payMethodLbl.Text = f1.payMethod.Text;

            dumpQntyLbl.Text = f1.dumpQnty.Text;
            dumpPrcLbl.Text = f1.dumpPrc.Text;
            dumpAmntLbl.Text = f1.dumpAmnt.Text;

            ExQntyLbl.Text = f1.exQnty.Text;
            exPrcLbl.Text = f1.exPrc.Text;
            exAmntLbl.Text = f1.exAmnt.Text;

            dozerQntyLbl.Text = f1.dozerQnty.Text;
            dozerPrcLbl.Text = f1.dozerPrc.Text;
            dozerAmntLbl.Text = f1.dozerAmnt.Text;



        }

        private void exAmntLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
