using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeadFirstChapter4Ex2
{
    public partial class Form1 : Form
    {
        Elephant lucinda = new Elephant() { Name = "Lucinda", EarSize = 33 };
        Elephant lloyd = new Elephant() { Name = "Lloyd", EarSize = 40 };

        public Form1()
        {
            InitializeComponent();
        }

        private void lloydBtn_Click(object sender, EventArgs e)
        {
            lloyd.WhoAmI();
        }

        private void lucindaBtn_Click(object sender, EventArgs e)
        {
            lucinda.WhoAmI();
        }

        private void swapBtn_Click(object sender, EventArgs e)
        {
            Elephant pen = lloyd;
            lloyd = lucinda;
            lucinda = pen;
            pen = null;
            MessageBox.Show("Values Swapped!", "The Swappening");
        }
    }
}
