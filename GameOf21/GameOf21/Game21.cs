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
    public partial class Game21 : Form
    { 
        //create an empty list of card images
        List<Image> listCardImages = new List<Image>();
        List<int> listCardValues = new List<int>();
        int hitCounter;
        int cards = 0;
        int cardValue;

        Random cardIndexGen;

        public Game21()
        {
            InitializeComponent();
            cardIndexGen = new Random();
           
        }

        private int DealCard(ref PictureBox aPictureBox) 
        {
            //declare local variables
            int cardindex;
            
            //this is the index of the card
            cardindex = cardIndexGen.Next(0, listCardImages.Count());

            //
            aPictureBox.Image = listCardImages[cardindex];
            cardindex += listCardValues[cardValue];

            listCardImages.RemoveAt(cardindex);
            listCardValues.RemoveAt(cardindex);

            return cardValue;
        }

        //moving the vaule form intro from to this form
        private void button1_Click(object sender, EventArgs e)
        {
            int totalbet = introGame21.totalbet;

            DealCard(ref this.picDealerCard1);
            DealCard(ref this.picPlayerCard1);
            DealCard(ref this.picPlayerCard2);
            btnStrat.Hide();
        }


        public void Game21_Load(object sender, EventArgs e)
        {
            //card image to the list

            listCardImages.Add(Properties.Resources.AC);
            listCardImages.Add(Properties.Resources.AD);
            listCardImages.Add(Properties.Resources.AH);
            listCardImages.Add(Properties.Resources.AS);

            listCardImages.Add(Properties.Resources._2C);
            listCardImages.Add(Properties.Resources._2D);
            listCardImages.Add(Properties.Resources._2H);
            listCardImages.Add(Properties.Resources._2S);

            listCardImages.Add(Properties.Resources._3C);
            listCardImages.Add(Properties.Resources._3D);
            listCardImages.Add(Properties.Resources._3H);
            listCardImages.Add(Properties.Resources._3S);

            listCardImages.Add(Properties.Resources._4C);
            listCardImages.Add(Properties.Resources._4D);
            listCardImages.Add(Properties.Resources._4H);
            listCardImages.Add(Properties.Resources._4S);

            listCardImages.Add(Properties.Resources._5C);
            listCardImages.Add(Properties.Resources._5D);
            listCardImages.Add(Properties.Resources._5H);
            listCardImages.Add(Properties.Resources._5S);

            listCardImages.Add(Properties.Resources._6C);
            listCardImages.Add(Properties.Resources._6D);
            listCardImages.Add(Properties.Resources._6H);
            listCardImages.Add(Properties.Resources._6S);

            listCardImages.Add(Properties.Resources._7C);
            listCardImages.Add(Properties.Resources._7D);
            listCardImages.Add(Properties.Resources._7H);
            listCardImages.Add(Properties.Resources._7S);

            listCardImages.Add(Properties.Resources._8C);
            listCardImages.Add(Properties.Resources._8D);
            listCardImages.Add(Properties.Resources._8H);
            listCardImages.Add(Properties.Resources._8S);

            listCardImages.Add(Properties.Resources._9C);
            listCardImages.Add(Properties.Resources._9D);
            listCardImages.Add(Properties.Resources._9H);
            listCardImages.Add(Properties.Resources._9S);

            listCardImages.Add(Properties.Resources._10C);
            listCardImages.Add(Properties.Resources._10D);
            listCardImages.Add(Properties.Resources._10H);
            listCardImages.Add(Properties.Resources._10S);

            listCardImages.Add(Properties.Resources.JC);
            listCardImages.Add(Properties.Resources.JD);
            listCardImages.Add(Properties.Resources.JH);
            listCardImages.Add(Properties.Resources.JH);

            listCardImages.Add(Properties.Resources.QC);
            listCardImages.Add(Properties.Resources.QD);
            listCardImages.Add(Properties.Resources.QH);
            listCardImages.Add(Properties.Resources.QS);

            listCardImages.Add(Properties.Resources.KC);
            listCardImages.Add(Properties.Resources.KD);
            listCardImages.Add(Properties.Resources.KH);
            listCardImages.Add(Properties.Resources.KS);

            //list of card values

            listCardValues.Add(1);
            listCardValues.Add(1);
            listCardValues.Add(1);
            listCardValues.Add(1);

            listCardValues.Add(2);
            listCardValues.Add(2);
            listCardValues.Add(2);
            listCardValues.Add(2);

            listCardValues.Add(3);
            listCardValues.Add(3);
            listCardValues.Add(3);
            listCardValues.Add(3);

            listCardValues.Add(4);
            listCardValues.Add(4);
            listCardValues.Add(4);
            listCardValues.Add(4);

            listCardValues.Add(5);
            listCardValues.Add(5);
            listCardValues.Add(5);
            listCardValues.Add(5);

            listCardValues.Add(6);
            listCardValues.Add(6);
            listCardValues.Add(6);
            listCardValues.Add(6);

            listCardValues.Add(7);
            listCardValues.Add(7);
            listCardValues.Add(7);
            listCardValues.Add(7);

            listCardValues.Add(8);
            listCardValues.Add(8);
            listCardValues.Add(8);
            listCardValues.Add(8);

            listCardValues.Add(9);
            listCardValues.Add(9);
            listCardValues.Add(9);
            listCardValues.Add(9);
           
            listCardValues.Add(10);
            listCardValues.Add(10);
            listCardValues.Add(10);
            listCardValues.Add(10);

            listCardValues.Add(10);
            listCardValues.Add(10);
            listCardValues.Add(10);
            listCardValues.Add(10);

            listCardValues.Add(10);
            listCardValues.Add(10);
            listCardValues.Add(10);
            listCardValues.Add(10);

            listCardValues.Add(10);
            listCardValues.Add(10);
            listCardValues.Add(10);
            listCardValues.Add(10);
        }

        private void btnhit_Click(object sender, EventArgs e)
        {
            hitCounter++;


            
            //hit = DealCards(hit);
        }

        private void picPlayerCard3_Click(object sender, EventArgs e)
        {

        }
    }
}