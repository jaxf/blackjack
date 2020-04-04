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

        int total;
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
                int total = 0;
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
            }
            if (click == 3)
            {
                card2num = r.Next(1, 10);
                Card2.Text = card2num.ToString();
                total2 = card1num + card2num;
                TotalText.Text = total2.ToString();             
            }
            if (click == 4)
            {
                card3num = r.Next(1, 10);
                Card3.Text = card3num.ToString();
                total3 = card1num + card2num + card3num;
                TotalText.Text = total3.ToString();               
            }
            if (click == 5)
            {
                card4num = r.Next(1, 10);
                Card4.Text = card4num.ToString();
                total4 = card1num + card2num + card3num + card4num;
                TotalText.Text = total4.ToString();
            }
            if (click == 6)
            {
                card5num = r.Next(1, 10);
                Card5.Text = card5num.ToString();
                total5 = card1num + card2num + card3num + card4num + card5num;
                TotalText.Text = total5.ToString();
            }
            if (click == 7)
            {
                card6num = r.Next(1, 10);
                Card6.Text = card6num.ToString();
                total6 = card1num + card2num + card3num + card4num + card5num + card6num;
                TotalText.Text = total6.ToString();
            }
        }
    }
}
