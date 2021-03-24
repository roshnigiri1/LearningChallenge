using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearningChallenge
{
    public partial class Form1 : Form
    {
        int gameCount = 0;
        int winCount = 0;
        int lostCount = 0;
        int drawCount = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRock_Click(object sender, EventArgs e)
        {
            playRps(OptionsEnum.Rock);
            gameCount += 1;
            lblTotal.Text = "Total: " + gameCount.ToString();
        }

        public void   btnPaper_Click(object sender, EventArgs e)
        {
            playRps(OptionsEnum.Paper);
            gameCount += 1;
            lblTotal.Text = "Total: " + gameCount.ToString();
        }

        private void btnScissor_Click(object sender, EventArgs e)
        {
            playRps(OptionsEnum.Scissor);
            gameCount += 1;
            lblTotal.Text = "Total: " + gameCount.ToString();
        }

        private void playRps(OptionsEnum userChoice)
        {
            OptionsEnum compChose = GameController.ComputerChoice();
            String result = GameController.Result(userChoice, compChose).ToString();
            lblResult.Text = "Result: "+ result;
            lblComputerChoice.Text = "Computer chose: " + compChose.ToString();
            switch (result)
            {
                case "Win":
                    winCount += 1;
                    break;
                case "Lose":
                    lostCount += 1;
                    break;
                default:
                    drawCount += 1;
                    break;
            }
            lblWon.Text = "Won: " + winCount.ToString();
            lblLost.Text = "Lost: " + lostCount.ToString();
            lblDraw.Text = "Draw: " + drawCount.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
