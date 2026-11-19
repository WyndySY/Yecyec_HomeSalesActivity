using System;
using System.Windows.Forms;

namespace Yecyec_HomeSalesActivity
{
    public partial class Form2 : Form
    {
        public Form2(double dTotal, double eTotal, double fTotal, double gTotal)
        {
            InitializeComponent();

            lblSummary.Text = "HOME SALES SUMMARY REPORT" + Environment.NewLine +
                               "Danielle (D): " + dTotal.ToString("C") + Environment.NewLine +
                               "Edward (E): " + eTotal.ToString("C") + Environment.NewLine +
                               "Fatima (F): " + fTotal.ToString("C") + Environment.NewLine +
                               "Grand Total: " + gTotal.ToString("C");
        }
    }
}
