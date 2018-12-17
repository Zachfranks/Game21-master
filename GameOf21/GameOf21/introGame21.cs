using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GameOf21
{
    public partial class introGame21 : Form
    {
        //global veubles
        public int bet = 0;
        public static int totalbet = 0;

        public introGame21()
        {
            InitializeComponent();           
        }

        //make a new form
        private void btnAgian_Click(object sender, EventArgs e)
        {
            using (var form1 = new Game21())
            {
                //rest game
                Visible = false;
                form1.ShowDialog();
                Close();
            }
        }

        //get bet vaules of bet and dispalyes it
        private void pic5_Click(object sender, EventArgs e)
        {                       
                bet = 5;
                totalbet = bet + totalbet;
            label2.Text = "$" + string.Format("{0:0.00}", totalbet);
        }

        private void pic10_Click(object sender, EventArgs e)
        {
            bet = 10;
            totalbet = bet + totalbet;
            label2.Text = "$" + string.Format("{0:0.00}", totalbet);
        }

        private void pic25_Click(object sender, EventArgs e)
        {
            bet = 25;
            totalbet = bet + totalbet;
            label2.Text = "$" + string.Format("{0:0.00}", totalbet);
        }

        private void pic50_Click(object sender, EventArgs e)
        {
            bet = 50;
            totalbet = bet + totalbet;
            label2.Text = "$" + string.Format("{0:0.00}", totalbet);
        }

        private void pic100_Click(object sender, EventArgs e)
        {
            bet = 100;
            totalbet = bet + totalbet;
            label2.Text = "$" + string.Format("{0:0.00}", totalbet);
        }

        private void pic500_Click(object sender, EventArgs e)
        {
            bet = 500;
            totalbet = bet + totalbet;
            label2.Text = "$" + string.Format("{0:0.00}", totalbet);
        }

        private void pic1000_Click(object sender, EventArgs e)
        {
            bet = 1000;
            totalbet = bet + totalbet;
            label2.Text = "$" + string.Format("{0:0.00}", totalbet);
        }

        private void pic5000_Click(object sender, EventArgs e)
        {
            bet = 5000;
            totalbet = bet + totalbet;
            label2.Text = "$" + string.Format("{0:0.00}", totalbet);
        }

         
    }
}
