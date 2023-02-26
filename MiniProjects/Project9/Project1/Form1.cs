using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class Form1 : Form
    {

        public int[] computerCards = new int[4];
        public int[] playerCards = new int[4];
        public int count = 0;
        public double computerScore = 0;
        public double playerScore = 0;
        public int playerBlast = 0;
        public int computerBlast = 0;
        public int noOfBetButtonClicks = 0;
        public int doneButton = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Random rndGen = new Random();
            if (noOfBetButtonClicks < 4)
            {
                count++;
                int computerTurn = rndGen.Next(1, 13);
                int playerTurn = rndGen.Next(1, 13);
                CalculateScore(count, computerTurn, "C");
                CalculateScore(count, playerTurn, "P");
            }
            else
            {
                MessageBox.Show("Please click Done button");
            }
            
            noOfBetButtonClicks++;


        }
        public void CalculateScore(int count,int number,string val)
        {
            if (number <= 10)
            {

                if (val == "C")
                {
                    computerCards[count - 1] = number;
                    if (count == 1)
                    {
                        label2.Text = number.ToString();
                    }
                    else if (count == 2)
                    {
                        label3.Text = number.ToString();
                    }
                    else if (count == 3)
                    {
                        label4.Text = number.ToString();
                    }
                    else
                    {
                        label5.Text = number.ToString();
                    }
                   
                }
                else
                {
                    playerCards[count - 1] = number;
                    if (count == 1)
                    {
                        label7.Text = number.ToString();
                    }
                    else if (count == 2)
                    {
                        label8.Text = number.ToString();
                    }
                    else if (count == 3)
                    {
                        label9.Text = number.ToString();
                    }
                    else
                    {
                        label10.Text = number.ToString();
                    }
                }
            }
            else if (number == 11)
            {
                if (val == "C")
                {
                    computerCards[count - 1] = number;
                    if (count == 1)
                    {
                        label2.Text = "J";
                    }
                    else if (count == 2)
                    {
                        label3.Text = "J";
                    }
                    else if (count == 3)
                    {
                        label4.Text = "J";
                    }
                    else
                    {
                        label5.Text = "J";
                    }
                }
                else
                {
                    playerCards[count - 1] = number;
                    if (count == 1)
                    {
                        label7.Text = "J";
                    }
                    else if (count == 2)
                    {
                        label8.Text = "J";
                    }
                    else if (count == 3)
                    {
                        label9.Text = "J";
                    }
                    else
                    {
                        label10.Text = "J";
                    }
                }
            }
            else if (number == 12)
            {

                if (val == "C")
                {
                    computerCards[count - 1] = number;
                    if (count == 1)
                    {
                        label2.Text = "Q";
                    }
                    else if (count == 2)
                    {
                        label3.Text = "Q";
                    }
                    else if (count == 3)
                    {
                        label4.Text = "Q";
                    }
                    else
                    {
                        label5.Text = "Q";
                    }
                }
                else
                {
                    playerCards[count - 1] = number;
                    if (count == 1)
                    {
                        label7.Text = "Q";
                    }
                    else if (count == 2)
                    {
                        label8.Text = "Q";
                    }
                    else if (count == 3)
                    {
                        label9.Text = "Q";
                    }
                    else
                    {
                        label10.Text = "Q";
                    }
                }


            }
            else
            {
                if (val == "C")
                {
                    computerCards[count - 1] = number;
                    if (count == 1)
                    {
                        label2.Text = "K";
                    }
                    else if (count == 2)
                    {
                        label3.Text = "K";
                    }
                    else if (count == 3)
                    {
                        label4.Text = "K";
                    }
                    else
                    {
                        label5.Text = "K";
                    }
                }
                else
                {
                    playerCards[count - 1] = number;
                    if (count == 1)
                    {
                        label7.Text = "K";
                    }
                    else if (count == 2)
                    {
                        label8.Text = "K";
                    }
                    else if (count == 3)
                    {
                        label9.Text = "K";
                    }
                    else
                    {
                        label10.Text = "K";
                    }
                }
            }
                
            }

        private void button2_Click(object sender, EventArgs e)
        {
            doneButton++;

            if (doneButton == 1)
            {
                for (int i = 0; i < computerCards.Length; i++)
                {
                    if (computerCards[i] == 11 | computerCards[i] == 12 | computerCards[i] == 13)
                    {
                        computerScore += 0.5;
                    }
                    else
                    {
                        computerScore += computerCards[i];
                    }

                }
                for (int i = 0; i < playerCards.Length; i++)
                {
                    if (playerCards[i] == 11 | playerCards[i] == 12 | playerCards[i] == 13)
                    {
                        playerScore += 0.5;
                    }
                    else
                    {
                        playerScore += playerCards[i];
                    }

                }

                if (computerScore >= 10)
                {
                    
                    computerBlast = 1;

                }

                if (playerScore >= 10)
                {
                   

                    playerBlast = 1;
                }

                if ((computerBlast + playerBlast) == 2)
                {
                   
                    MessageBox.Show("You Blast! Computer Wins!!!");




                }
                else if ((computerScore == playerScore) && ((computerBlast + playerBlast) == 0))
                {
                    
                    MessageBox.Show("Computer Blast! You Win!!!");


                }

                else if ((computerScore < playerScore) && (playerBlast == 0))
                {
                    
                    MessageBox.Show("Computer Blast! You Win!!!");

                }
                else
                {
                    
                    MessageBox.Show("You Blast! Computer Wins!!!");
                }
            }

            
        }

        public void ResetGame()
        {
            computerBlast = 0;
            playerBlast = 0;
            count = 0;
            noOfBetButtonClicks = 0;
            doneButton = 0;
            computerScore = 0;
            playerScore = 0;
            computerCards = new int[4];
            playerCards = new int[4];
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label10.Text = "";
            label7.Text = "";
            label8.Text = "";
            label9.Text = "";
            MessageBox.Show("New Game");

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ResetGame();
        }
    }


    }

