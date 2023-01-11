using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class game3x3 : Form
    {
        int XOcount = 0;
        int[,] array= new int[3, 3];
        
        public game3x3(menu menu)
        {
            InitializeComponent();
        }

        private void button1a_Click(object sender, EventArgs e)
        {
            onClick(0, 0);
        }

        private void button1b_Click(object sender, EventArgs e)
        {
            onClick(0, 1);        
        }

        private void button1c_Click(object sender, EventArgs e)
        {
            onClick(0, 2);        
        }

        private void button2a_Click(object sender, EventArgs e)
        {
            onClick(1, 0);        
        }

        private void button2b_Click(object sender, EventArgs e)
        {
            onClick(1, 1);
        }

        private void button2c_Click(object sender, EventArgs e)
        {
            onClick(1, 2);
        }

        private void button3a_Click(object sender, EventArgs e)
        {
            onClick(2, 0);        
        }

        private void button3b_Click(object sender, EventArgs e)
        {
            onClick(2, 1);
        }

        private void button3c_Click(object sender, EventArgs e)
        {
            onClick(2, 2);
        }

        private void onClick(int x, int y)
        {
            if (XOcount % 2 == 0)
            {
                buttonwhichturnXO.BackColor= Color.DarkSeaGreen;
                buttonwhichturnXO.Text = "O";

                array[x, y] = 1;
                if (x == 0)
                {
                    if (y == 0)
                    {
                        button1a.Text = "X";
                        button1a.Enabled = false;
                        button1a.BackColor = Color.Tomato;
                    }
                    else if (y == 1)
                    {
                        button1b.Text = "X";
                        button1b.Enabled = false;
                        button1b.BackColor = Color.Tomato;
                    }
                    else if (y == 2)
                    {
                        button1c.Text = "X";
                        button1c.Enabled = false;
                        button1c.BackColor = Color.Tomato;
                    }
                }
                else if (x == 1)
                {
                    if (y == 0)
                    {
                        button2a.Text = "X";
                        button2a.Enabled = false;
                        button2a.BackColor = Color.Tomato;
                    }
                    else if (y == 1)
                    {
                        button2b.Text = "X";
                        button2b.Enabled = false;
                        button2b.BackColor = Color.Tomato;
                    }
                    else if (y == 2)
                    {
                        button2c.Text = "X";
                        button2c.Enabled = false;
                        button2c.BackColor = Color.Tomato; 
                    }
                }
                else if (x == 2)
                {
                    if (y == 0)
                    {
                        button3a.Text = "X";
                        button3a.Enabled = false;
                        button3a.BackColor = Color.Tomato;
                    }
                    else if (y == 1)
                    {
                        button3b.Text = "X";
                        button3b.Enabled = false;
                        button3b.BackColor = Color.Tomato;
                    }
                    else if (y == 2)
                    {
                        button3c.Text = "X";
                        button3c.Enabled = false;
                        button3c.BackColor = Color.Tomato;
                    }

                }

            }
            else
            {
                buttonwhichturnXO.BackColor = Color.Tomato;
                buttonwhichturnXO.Text = "X";

                array[x, y] = -1;
                if (x == 0)
                {
                    if (y == 0)
                    {
                        button1a.Text = "O";
                        button1a.Enabled = false;
                        button1a.BackColor = Color.DarkSeaGreen;
                    }
                    else if (y == 1)
                    {
                        button1b.Text = "O";
                        button1b.Enabled = false;
                        button1b.BackColor = Color.DarkSeaGreen;
                    }
                    else if (y == 2)
                    {
                        button1c.Text = "O";
                        button1c.Enabled = false;
                        button1c.BackColor = Color.DarkSeaGreen;
                    }
                }
                else if (x == 1)
                {
                    if (y == 0)
                    {
                        button2a.Text = "O";
                        button2a.Enabled = false;
                        button2a.BackColor = Color.DarkSeaGreen;
                    }
                    else if (y == 1)
                    {
                        button2b.Text = "O";
                        button2b.Enabled = false;
                        button2b.BackColor= Color.DarkSeaGreen;
                    }
                    else if (y == 2)
                    {
                        button2c.Text = "O";
                        button2c.Enabled = false;
                        button2c.BackColor= Color.DarkSeaGreen;
                    }
                }
                else if (x == 2)
                {
                    if (y == 0)
                    {
                        button3a.Text = "O";
                        button3a.Enabled = false;
                        button3a.BackColor = Color.DarkSeaGreen;
                    }
                    else if (y == 1)
                    {
                        button3b.Text = "O";
                        button3b.Enabled = false;
                        button3b.BackColor = Color.DarkSeaGreen;
                    }
                    else if (y == 2)
                    {
                        button3c.Text = "O";
                        button3c.Enabled = false;
                        button3c.BackColor = Color.DarkSeaGreen;
                    }
                }
            }
            check();
            XOcount++;
        }
        private void reset()
        {
            array = new int[3,3];

            button1a.Text = "";
            button1a.Enabled = true;
            button1a.BackColor= Color.White;

            button1b.Text = "";
            button1b.Enabled = true;
            button1b.BackColor = Color.White;

            button1c.Text = "";
            button1c.Enabled = true;
            button1c.BackColor = Color.White;

            button2a.Text = "";
            button2a.Enabled = true;
            button2a.BackColor = Color.White;

            button2b.Text = "";
            button2b.Enabled = true;
            button2b.BackColor = Color.White;

            button2c.Text = "";
            button2c.Enabled = true;
            button2c.BackColor = Color.White;

            button3a.Text = "";
            button3a.Enabled = true;
            button3a.BackColor = Color.White;

            button3b.Text = "";
            button3b.Enabled = true;
            button3b.BackColor = Color.White;

            button3c.Text = "";
            button3c.Enabled = true;
            button3c.BackColor = Color.White;

            XOcount = 0;
            buttonwhichturnXO.BackColor= Color.White;
            buttonwhichturnXO.Text = "";


        }

        private void check()
        {
            bool ifThereIsWinnerX = false;
            bool ifThereIsWinnerO = false;

            //horizontal check X
            if (array[0, 0] == 1 && array[0, 1] == 1 && array[0, 2] == 1)
            {
                ifThereIsWinnerX = true;
            }

            else if (array[1, 0] == 1 && array[1, 1] == 1 && array[1, 2] == 1)
            {
                ifThereIsWinnerX = true;
            }

            else if (array[2, 0] == 1 && array[2, 1] == 1 && array[2, 2] == 1)
            {
                ifThereIsWinnerX = true;
            }

            //vertical check X
            if (array[0, 0] == 1 && array[1, 0] == 1 && array[2, 0] == 1)
            {
                ifThereIsWinnerX = true;
            }

            else if (array[0, 1] == 1 && array[1, 1] == 1 && array[2, 1] == 1)
            {
                ifThereIsWinnerX = true;
            }
            else if (array[0, 2] == 1 && array[1, 2] == 1 && array[2, 2] == 1)
            {
                ifThereIsWinnerX = true;
            }

            //diagonal check X
            if (array[0, 0] == 1 && array[1, 1] == 1 && array[2, 2] == 1)
            {
                ifThereIsWinnerX = true;
            }
            else if (array[2, 0] == 1 && array[1, 1] == 1 && array[0, 2] == 1)
            {
                ifThereIsWinnerX = true;
            }


            //horizontal check O
            if (array[0, 0] == -1 && array[0, 1] == -1 && array[0, 2] == -1)
            {
                ifThereIsWinnerO = true;
            }

            else if (array[1, 0] == -1 && array[1, 1] == -1 && array[1, 2] == -1)
            {
                ifThereIsWinnerO = true;
            }

            else if (array[2, 0] == -1 && array[2, 1] == -1 && array[2, 2] == -1)
            {
                ifThereIsWinnerO = true;
            }

            //vertical check O
            if (array[0, 0] == -1 && array[1, 0] == -1 && array[2, 0] == -1)
            {
                ifThereIsWinnerO = true;
            }

            else if (array[0, 1] == -1 && array[1, 1] == -1 && array[2, 1] == -1)
            {
                ifThereIsWinnerO = true;
            }
            else if (array[0, 2] == -1 && array[1, 2] == -1 && array[2, 2] == -1)
            {
                ifThereIsWinnerO = true;
            }

            //diagonal check O
            if (array[0, 0] == -1 && array[1, 1] == -1 && array[2, 2] == -1)
            {
                ifThereIsWinnerO = true;
            }
           else if (array[2, 0] == -1 && array[1, 1] == -1 && array[0, 2] == -1)
            {
                ifThereIsWinnerO = true;
            }


            // X win prompt
            if (ifThereIsWinnerX == true)
            {
                MessageBox.Show("Winner is X");
                reset();
            }
            else if(ifThereIsWinnerO == true)
            {
                MessageBox.Show("Winner is O");
                reset();
            }
            else if (XOcount == 9)
            {
                MessageBox.Show("It is draw");
                reset();
            }
            

        }

        private void game3x3_Load(object sender, EventArgs e)
        {

        }
    }
}
