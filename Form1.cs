using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blackjack
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int total = 0;
        int total2;
        int total3;
        int total4;
        int total5;
        int total6;
        int click;
        int card1num;
        int card2num;
        int card3num;
        int card4num;
        int card5num;
        int card6num;

        Random r = new Random();


        private void DrawButton_Click(object sender, EventArgs e)
        {
            click++;
            if (TotalText.Text == "X")
            {
                TotalText.Text = "0";
            }
            if (DrawButton.Text == "Begin")
            {
                DrawButton.Text = "Draw card";
            }
            if (click == 2)
            {
                card1num = r.Next(1, 10); //for ints
                Card1.Text = card1num.ToString();
                total = card1num;
                TotalText.Text = total.ToString();
                    if (total > 21)
                        {
                    System.Windows.Forms.MessageBox.Show("You lost");
                    DrawButton.Enabled = false;
                        }

            }



            if (click == 3)
            {
                card2num = r.Next(1, 10);
                Card2.Text = card2num.ToString();
                total2 = card1num + card2num;
                TotalText.Text = total2.ToString();
                    if (total2 > 21)
                        {
                    System.Windows.Forms.MessageBox.Show("You lost");
                    DrawButton.Enabled = false;
                        }
            }



            if (click == 4)
            {
                card3num = r.Next(1, 10);
                Card3.Text = card3num.ToString();
                total3 = card1num + card2num + card3num;
                TotalText.Text = total3.ToString();
                    if (total3 > 21)
                        {
                    System.Windows.Forms.MessageBox.Show("You lost");
                    DrawButton.Enabled = false;
                        }
            }



            if (click == 5)
            {
                card4num = r.Next(1, 10);
                Card4.Text = card4num.ToString();
                total4 = card1num + card2num + card3num + card4num;
                TotalText.Text = total4.ToString();
                    if (total4 > 21)
                        {
                    System.Windows.Forms.MessageBox.Show("You lost");
                    DrawButton.Enabled = false;
                        }



            }
            if (click == 6)
            {
                card5num = r.Next(1, 10);
                Card5.Text = card5num.ToString();
                total5 = card1num + card2num + card3num + card4num + card5num;
                TotalText.Text = total5.ToString();
                    if (total5 > 21)
                        {
                    System.Windows.Forms.MessageBox.Show("You lost");
                    DrawButton.Enabled = false;
                        }



            }
            if (click == 7)
            {
                card6num = r.Next(1, 10);
                Card6.Text = card6num.ToString();
                total6 = card1num + card2num + card3num + card4num + card5num + card6num;
                TotalText.Text = total6.ToString();
                    if (total6 > 21)
                        {
                    System.Windows.Forms.MessageBox.Show("You lost");
                    DrawButton.Enabled = false;
                        }
                    if (total6 < 21)
                        {
                    System.Windows.Forms.MessageBox.Show("You won");
                    DrawButton.Enabled = false;
                        }
            }
        }

        private void EndButton_Click(object sender, EventArgs e)
        {
            if (card1num + card2num + card3num + card4num + card5num + card6num < 21 || card1num + card2num + card3num + card4num + card5num + card6num > 17)
            {
                System.Windows.Forms.MessageBox.Show("You won, and ended game with a score of " + (card1num + card2num + card3num + card4num + card5num + card6num));
                DrawButton.Enabled = false;
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            card1num = 0;
            card2num = 0;
            card3num = 0;
            card4num = 0;
            card5num = 0;
            card6num = 0;
            total = 0;
            total2 = 0;
            total3 = 0;
            total4 = 0;
            total5 = 0;
            total6 = 0;
            TotalText.Text = "X";
            Card1.Text = "X";
            Card2.Text = "X";
            Card3.Text = "X";
            Card4.Text = "X";
            Card5.Text = "X";
            Card6.Text = "X";
            DrawButton.Enabled = true;
        }
    }
}
