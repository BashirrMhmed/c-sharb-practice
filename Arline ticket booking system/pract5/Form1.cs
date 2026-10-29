using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pract5
{
    public partial class Form1 : Form
    {
        public Form1() { 
        
            InitializeComponent();
        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            
            


           bool bookingApproved=false;
            string passengerName = txtpassengername.Text;

            int age;
            int tickets;
            double baggageWeight;

            if (passengerName == "")
            {
                MessageBox.Show("Please enter passenger name.");
                return;
            }

            if (!int.TryParse(txtpassengerage.Text, out age))
            {
                MessageBox.Show("Please enter a valid age.");
                return;
            }
            else if (age < 1 || age > 100)
            {
                MessageBox.Show("Age must be between 1 and 100.");
                return;
            }

            if (!int.TryParse(txtnumberoftikets.Text, out tickets))
            {
                MessageBox.Show("Please enter a valid number of tickets.");
                return;
            }
            else if (tickets < 1 || tickets > 5)
            {
                MessageBox.Show("Tickets must be between 1 and 5.");
                return;
            }

            if (!double.TryParse(txtbaggageweight.Text, out baggageWeight))
            {
                MessageBox.Show("Please enter a valid baggage weight.");
                return;
            }
            else if (baggageWeight < 0 || baggageWeight > 50)
            {
                MessageBox.Show("Baggage must be between 0 and 50 kg.");
                return;
            }

            double ticketPrice = 0;

            if (rdoFirstClass.Checked)
            {
                if (age < 12)
                {
                    MessageBox.Show(
                        "Passengers below 12 years cannot book First Class.");
                    return;
                }

                ticketPrice = 500;
            }
            else if (rdoNormalClass.Checked)
            {
                ticketPrice = 200;
            }
            else if (rdoBusinessClass.Checked)
            {
                ticketPrice = 350;
            }
            else
            {
                MessageBox.Show("Please select a travel class.");
                return;
            }

            double basicCost = ticketPrice * tickets;
            double discountRate = 0;

            if (tickets >= 3 && tickets <= 4)
            {
                discountRate += 0.05;
            }
            else if (tickets == 5)
            {
                discountRate += 0.10;
            }

            if (age < 12)
            {
                discountRate += 0.20;
            }
            else if (age >= 60)
            {
                discountRate += 0.10;
            }

            double discount = basicCost * discountRate;
            double insurance = 0;

            if (checktravelinsurance.Checked)
            {
                insurance = 25 * tickets;
            }

            double totalAmount = basicCost - discount + insurance;

            bookingApproved = true;

            chkTravelInsurance.Text =
                "AIRLINE BOOKING DETAILS\r\n" +
                "------------------------------\r\n" +
                "Passenger Name: " + passengerName + "\r\n" +
                "Passenger Age: " + age + "\r\n" +
                "Number of Tickets: " + tickets + "\r\n" +
                "Baggage Weight: " + baggageWeight + " kg\r\n" +
                "Ticket Price: $" + ticketPrice.ToString("N2") + "\r\n" +
                "Basic Cost: $" + basicCost.ToString("N2") + "\r\n" +
                "Discount: $" + discount.ToString("N2") + "\r\n" +
                "Travel Insurance: $" + insurance.ToString("N2") + "\r\n" +
                "Total Amount: $" + totalAmount.ToString("N2") + "\r\n" +
                "Booking Approved: " + bookingApproved;
            
        }

        private void bntClear_Click(object sender, EventArgs e)
        {
            txtpassengername.Clear();
            txtpassengerage.Clear();
            txtnumberoftikets.Clear();
            txtbaggageweight.Clear();
            chkTravelInsurance.Items.Clear();

            rdoFirstClass.Checked = false;
            rdoNormalClass.Checked = false;
            rdoBusinessClass.Checked = false;
            checktravelinsurance.Checked = false;

          
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
    }
    










