using System;
using System.Windows.Forms;

namespace Yecyec_HomeSalesActivity
{
    public partial class Form1 : Form
    {
        double totalDanielle = 0;
        double totalEdward = 0;
        double totalFatima = 0;
        double grandTotal = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void getSalesPerson_Amount(String salesInitial, double salesAmount)
        {
            string initial = salesInitial.ToUpper();

            if (initial == "D")
            {
                totalDanielle = totalDanielle + salesAmount;
                lblOutput.Text = "Sale added for Danielle." + Environment.NewLine +
                                 "Danielle's Total: " + totalDanielle.ToString("C");
            }
            else if (initial == "E")
            {
                totalEdward = totalEdward + salesAmount;
                lblOutput.Text = "Sale added for Edward." + Environment.NewLine +
                                 "Edward's Total: " + totalEdward.ToString("C");
            }
            else if (initial == "F")
            {
                totalFatima = totalFatima + salesAmount;
                lblOutput.Text = "Sale added for Fatima." + Environment.NewLine +
                                 "Fatima's Total: " + totalFatima.ToString("C");
            }
            else
            {
                lblOutput.Text = "Invalid Initial! Please enter D, E, or F.";
            }
        }

        private void clearEntry()
        {
            txtInitial.Text = "";
            txtAmount.Text = "";
            lblOutput.Text = "";
            txtInitial.Focus();
        }

        private void Btn_Submit_Click(object sender, EventArgs e)
        {
            if (txtInitial.Text == "" || txtAmount.Text == "")
            {
                lblOutput.Text = "Please fill in all fields.";
                return;
            }

            double amount = Convert.ToDouble(txtAmount.Text);
            getSalesPerson_Amount(txtInitial.Text, amount);
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            clearEntry();
        }

        private void Btn_Print_Click(object sender, EventArgs e)
        {
            grandTotal = totalDanielle + totalEdward + totalFatima;

            Form2 summaryForm = new Form2(totalDanielle, totalEdward, totalFatima, grandTotal);
            summaryForm.Show();
        }
    }
}
