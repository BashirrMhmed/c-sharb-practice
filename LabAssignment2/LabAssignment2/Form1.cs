using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LabAssignment2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                 
                int NumberofPackaget;
                double price;
                double subTotal;
                double DiscountRate = 0;
                double DiscountAmount = 0;
                double TotalAmount;





              if (!int.TryParse(txtNumofPackage.Text, out NumberofPackaget) ||
                !double.TryParse(txxtPrice.Text, out price))
                {
                    MessageBox.Show("Please input numeric data");
                    return;
                }

                if (NumberofPackaget <= 0 || price <= 0)
                {
                    MessageBox.Show("Cant be negative");
                    return;
                }

                // calculating subTotal
                subTotal = NumberofPackaget * price;


                // calculating discount
                if (NumberofPackaget >= 10 && NumberofPackaget <= 19)
                {
                    DiscountAmount = subTotal * 0.2;
                    DiscountRate = 20;
                }
                else if (NumberofPackaget >= 20 && NumberofPackaget <= 49)
                {
                    DiscountAmount = subTotal * 0.3;
                    DiscountRate = 30;
                }
                else if (NumberofPackaget >= 50 && NumberofPackaget <= 99)
                {
                    DiscountAmount = subTotal * 0.4;
                    DiscountRate = 40;
                }
                else if (NumberofPackaget >= 100)
                {
                    DiscountAmount = subTotal * 0.5;
                    DiscountRate = 50;
                }
                // calculating tOTAL
                TotalAmount = subTotal - DiscountAmount;

                // output using list box
                SoftwaresalesResults.Items.Add("Number of Packages: " + NumberofPackaget);
                SoftwaresalesResults.Items.Add("Price per package:" + price);
                SoftwaresalesResults.Items.Add("Subtotal (before discount):" + subTotal);
                SoftwaresalesResults.Items.Add("Discount Rate:" + DiscountAmount);
                SoftwaresalesResults.Items.Add("Discount Amount:" + DiscountAmount);
                SoftwaresalesResults.Items.Add("Total Amount after discount:" + TotalAmount);







            }
            catch (Exception ex)
            {

            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNumofPackage.Clear();
            txxtPrice.Text = "";
            SoftwaresalesResults.Items.Clear();




        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
