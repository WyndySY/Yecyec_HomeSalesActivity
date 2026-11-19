using System;
using System.Windows.Forms;
using Yecyec_HomeSalesActivity;

namespace Yecyec_HomeSalesActivity
{
    public partial class Form1 : Form
    {
    
        double totalDanielle = 0;
        double totalEdward = 0;
        double totalFatima = 0;

        public Form1()
        {
            InitializeComponent();
        }


        private void getSalesPerson_Amount(String salesInitial, double salesAmount)
        {
            string initial = salesInitial.Trim().ToUpper();

            if (initial == "D")
            {
                totalDanielle += salesAmount;
                lblOutput.Text = "Sale added for Danielle.\nDanielle's Running Total: " + totalDanielle.ToString("C");
            }
            else if (initial == "E")
            {
                totalEdward += salesAmount;
                lblOutput.Text = "Sale added for Edward.\nEdward's Running Total: " + totalEdward.ToString("C");
            }
            else if (initial == "F")
            {
                totalFatima += salesAmount;
                lblOutput.Text = "Sale added for Fatima.\nFatima's Running Total: " + totalFatima.ToString("C");
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
            double amount;

            if (double.TryParse(txtAmount.Text, out amount))
            {
                getSalesPerson_Amount(txtInitial.Text, amount);
            }
            else
            {
                lblOutput.Text = "Please enter a valid numeric amount.";
            }
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            clearEntry();
        }

        private void Btn_Print_Click(object sender, EventArgs e)
        {
            double grandTotal = totalDanielle + totalEdward + totalFatima;

            Form2 summaryForm = new Form2();
            summaryForm.lblSummary.Text =
                "HOME SALES SUMMARY REPORT\n\n" +
                "Danielle (D): " + totalDanielle.ToString("C") + "\n" +
                "Edward (E): " + totalEdward.ToString("C") + "\n" +
                "Fatima (F): " + totalFatima.ToString("C") + "\n\n" +
                "Grand Total: " + grandTotal.ToString("C");

            summaryForm.Show();
        }
    }
}
