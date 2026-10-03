using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_score_average
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcualate_Click(object sender, EventArgs e)
        {
            try
            {
                double test1 = double.Parse(txttest1.Text);
                double test2 = double.Parse(txttest2.Text);
                double test3 = double.Parse(txttest3.Text);

                double Average = (test1 + test2 + test3) / 3;

                if (Average >= 0)
                {
                    lblaverage.Text = Average.ToString("n1");
                }
                else
                {
                    lblaverage.Text = "Invalid";
                }
            }
            catch
            {
                MessageBox.Show("Please enter valid numbers.");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txttest1.Clear();
            txttest2.Clear();
            txttest3.Clear();
            lblaverage.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

