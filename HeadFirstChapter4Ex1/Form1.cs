using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeadFirstChapter4Ex1
{
    public partial class Form1 : Form
    {
        int startingMilage = 0;
        int endingMilage = 0;
        double milesTraveled;
        double reimburseRate = .39;
        double amountOwed;

        public Form1()
        {
            InitializeComponent();
        }

        private void calculateAmountBtn_Click(object sender, EventArgs e)
        {
            startingMilage = (int)startingMilageAmount.Value;
            endingMilage = (int)endingMilageAmount.Value;
            if(endingMilage < startingMilage)
            {
                MessageBox.Show("The starting milage must be less than the ending milage.", "Cannot calculate milage");
            }
            else
            {
                milesTraveled = endingMilage - startingMilage;
                amountOwed = milesTraveled * reimburseRate;
                amountOwedDisplay.Text = "$" + amountOwed;
            }
        }

        private void showMilesBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("" + milesTraveled + " miles", "Miles Travelled");
        }
    }
}
