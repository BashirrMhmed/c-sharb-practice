using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_room_booking_system
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {


            try
            {
                // Get guest information
                string guestName = txtname.Text;
                int guestAge, nights, guests;
                bool bookingApproved = true;

                // Check guest name
                if (guestName == "")
                {
                    MessageBox.Show("Guest name cannot be empty.");
                    return;
                }

                // Validate guest age
                if (!int.TryParse(txtage.Text, out guestAge))
                {
                    MessageBox.Show("Invalid guest age.");
                    return;
                }
                else if (guestAge < 18 || guestAge > 90)
                {
                    MessageBox.Show("Age must be between 18 and 90.");
                    return;
                }

                // Validate number of nights
                if (!int.TryParse(txtNights.Text, out nights))
                {
                    MessageBox.Show("Invalid number of nights.");
                    return;
                }
                else if (nights < 1 || nights > 30)
                {
                    MessageBox.Show("Nights must be between 1 and 30.");
                    return;
                }

                // Validate number of guests
                if (!int.TryParse(txtGuest.Text, out guests))
                {
                    MessageBox.Show("Invalid number of guests.");
                    return;
                }
                else if (guests < 1 || guests > 6)
                {
                    MessageBox.Show("Guests must be between 1 and 6.");
                    return;
                }

                // Declare room variables
                double roomRate = 0;
                int maxGuests = 0;
                string roomType = "";

                // Select room type and set room rate
                if (rdoStandard.Checked)
                {
                    roomType = "Standard";
                    switch (roomType)
                    {
                        case "Standard":
                            roomRate = 50;
                            maxGuests = 2;
                            break;
                    }
                }
                else if (rdoNormal.Checked)
                {
                    roomType = "Normal";
                    switch (roomType)
                    {
                        case "Normal":
                            roomRate = 80;
                            maxGuests = 4;
                            break;
                    }
                }
                else if (rdoHight.Checked)
                {
                    roomType = "Hight";
                    switch (roomType)
                    {
                        case "Hight":
                            roomRate = 130;
                            maxGuests = 6;
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Select room type.");
                    return;
                }

                // Check room capacity
                if (guests > maxGuests)
                {
                    bookingApproved = false;
                    MessageBox.Show("Too many guests for this room.");
                    return;
                }

                // Check booking approval
                if (!bookingApproved)
                    return;

                // Calculate room cost
                double roomCost = roomRate * nights;
                double breakfastCost = 0;

                // Calculate breakfast cost
                if (chkBreakfast.Checked)
                    breakfastCost = 10 * guests * nights;

                // Calculate discount rate
                double discountRate = 0;

                if (nights >= 5 && nights <= 9)
                    discountRate = 0.05;
                else if (nights >= 10)
                    discountRate = 0.12;

                // Calculate room discount
                double discount = roomCost * discountRate;

                // Calculate senior discount
                double seniorDiscount = 0;

                if (guestAge >= 60)
                    seniorDiscount = roomCost * 0.05;

                // Calculate service surcharge
                double serviceSurcharge = 0;

                if (guests > 4)
                    serviceSurcharge = roomCost * 0.05;

                // Calculate total amount
                double totalAmount = roomCost + breakfastCost
                    - discount - seniorDiscount + serviceSurcharge;

                // Display booking details
                bookingdetails.Text =
                    "Guest Name: " + guestName + "\n" +
                    "Guest Age: " + guestAge + "\n" +
                    "Room Type: " + roomType + "\n" +
                    "Number of Nights: " + nights + "\n" +
                    "Number of Guests: " + guests + "\n" +
                    "Room Cost: $" + roomCost.ToString("N2") + "\n" +
                    "Breakfast: $" + breakfastCost.ToString("N2") + "\n" +
                    "Discount: $" + discount.ToString("N2") + "\n" +
                    "Senior Discount: $" + seniorDiscount.ToString("N2") + "\n" +
                    "Service Surcharge: $" + serviceSurcharge.ToString("N2") + "\n" +
                    "Total Amount: $" + totalAmount.ToString("N2") + "\n" +
                    "Booking Status: Approved";
            }
            catch
            {
                // Display error message
                MessageBox.Show("Please check your input.");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear input fields
            txtname.Clear();
            txtage.Clear();
            txtNights.Clear();
            txtGuest.Clear();

            // Clear room selection
            rdoStandard.Checked = false;
            rdoNormal.Checked = false;
            rdoHight.Checked = false;

            // Clear breakfast selection and booking details
            chkBreakfast.Checked = false;
            bookingdetails.Items.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

