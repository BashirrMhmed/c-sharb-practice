using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotelroom_and_booking_calculator
{
    public partial class lblpricepernight : Form
    {
        public lblpricepernight()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                string guestName = txtGuesName.Text;
                string roomType = txtRoomType.Text;

                int nights = int.Parse(txtNights.Text);
                double pricePerNight = double.Parse(txtPriceNight.Text);

                double totalCost = nights * pricePerNight;

                double serviceTax = totalCost * 0.10;
                double discount = totalCost * 0.05;

                double totalAmount = (totalCost * 2) + serviceTax - discount;

                lblServiceTax.Text = serviceTax.ToString("C");
                lblDiscount.Text = discount.ToString("C");
                lblTotalAmount.Text = totalAmount.ToString("C");
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numbers for nights and price.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
