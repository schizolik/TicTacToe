using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class game3x3 : Form
    {
        int XOcount = 0;
        bool[,] array= new bool[3, 3];
        public game3x3(menu menu)
        {
            InitializeComponent();
        }

        private void button1a_Click(object sender, EventArgs e)
        {
            if(XOcount%2 == 0)
            {
                array[0, 0] = true;
                button1a.Text = "X";
                check();
                XOcount++;

            }
            else
            {
                array[0, 0] = false;
                button1a.Text = "O";
                check();
                XOcount++;
            }
        }

        private void button1b_Click(object sender, EventArgs e)
        {
            if (XOcount % 2 == 0)
            {
                array[0, 1] = true;
                button1b.Text = "X";
                check();
                XOcount++;

            }
            else
            {
                array[0, 1] = false;
                button1b.Text = "O";
                check();
                XOcount++;
            }
        }

        private void button1c_Click(object sender, EventArgs e)
        {
            if (XOcount % 2 == 0)
            {
                array[0, 2] = true;
                button1c.Text = "X";
                check();
                XOcount++;

            }
            else
            {
                array[0, 2] = false;
                button1c.Text = "O";
                check();
                XOcount++;

            }
        }

        private void button2a_Click(object sender, EventArgs e)
        {
            if (XOcount % 2 == 0)
            {
                array[1, 0] = true;
                button2a.Text = "X";
                check();
                XOcount++;


            }
            else
            {
                array[1, 0] = false;
                button2a.Text = "O";
                check();
                XOcount++;

            }
        }

        private void button2b_Click(object sender, EventArgs e)
        {
            if (XOcount % 2 == 0)
            {
                array[1, 1] = true;
                button2b.Text = "X";
                check();
                XOcount++;


            }
            else
            {
                array[1, 1] = false;
                button2b.Text = "O";
                check();
                XOcount++;

            }
        }

        private void button2c_Click(object sender, EventArgs e)
        {
            if (XOcount % 2 == 0)
            {
                array[1, 2] = true;
                button2c.Text = "X";
                check();
                XOcount++;


            }
            else
            {
                array[1, 2] = false;
                button2c.Text = "O";
                check();
                XOcount++;

            }
        }

        private void button3a_Click(object sender, EventArgs e)
        {
            if (XOcount % 2 == 0)
            {
                array[2, 0] = true;
                button3a.Text = "X";
                check();
                XOcount++;


            }
            else
            {
                array[2, 0] = false;
                button3a.Text = "O";
                check();
                XOcount++;

            }
        }

        private void button3b_Click(object sender, EventArgs e)
        {
            if (XOcount % 2 == 0)
            {
                array[2, 1] = true;
                button3b.Text = "X";
                check();
                XOcount++;


            }
            else
            {
                array[2, 1] = false;
                button3b.Text = "O";
                check();
                XOcount++;

            }
        }

        private void button3c_Click(object sender, EventArgs e)
        {
            if (XOcount % 2 == 0)
            {
                array[2, 2] = true;
                button3c.Text = "X";
                check();
                XOcount++;


            }
            else
            {
                array[2, 2] = false;
                button3c.Text = "O";
                check();
                XOcount++;

            }
        }
        private void check()
        {
            bool ifThereIsWinnerX = false;
            bool ifThereIsWinnerO = false;

            //horizontal check X
            if (array[0, 0] == true && array[0, 1] == true && array[0, 2] == true)
            {
                ifThereIsWinnerX |= true;
            }

            else if (array[1, 0] == true && array[1, 1] == true && array[1, 2] == true)
            {
                ifThereIsWinnerX |= true;
            }

            else if (array[2, 0] == true && array[2, 1] == true && array[2, 2] == true)
            {
                ifThereIsWinnerX |= true;
            }

            //vertical check X
            if (array[0, 0] == true && array[1, 0] == true && array[2, 0] == true)
            {
                ifThereIsWinnerX = true;
            }

            else if (array[0, 1] == true && array[1, 1] == true && array[2, 1] == true)
            {
                ifThereIsWinnerX = true;
            }
            else if (array[0, 2] == true && array[1, 2] == true && array[2, 2] == true)
            {
                ifThereIsWinnerX = true;
            }

            //diagonal check X
            if (array[0, 0] == true && array[1, 1] == true && array[2, 2] == true)
            {
                ifThereIsWinnerX = true;
            }
            else if (array[2, 0] == true && array[1, 1] == true && array[0, 2] == true)
            {
                ifThereIsWinnerX |= true;
            }


            //horizontal check O
            if (array[0, 0] == true && array[0, 1] == true && array[0, 2] == true)
            {
                ifThereIsWinnerO |= true;
            }

            else if (array[1, 0] == true && array[1, 1] == true && array[1, 2] == true)
            {
                ifThereIsWinnerO |= true;
            }

            else if (array[2, 0] == true && array[2, 1] == true && array[2, 2] == true)
            {
                ifThereIsWinnerO |= true;
            }

            //vertical check O
            if (array[0, 0] == true && array[1, 0] == true && array[2, 0] == true)
            {
                ifThereIsWinnerO = true;
            }

            else if (array[0, 1] == true && array[1, 1] == true && array[2, 1] == true)
            {
                ifThereIsWinnerO = true;
            }
            else if (array[0, 2] == true && array[1, 2] == true && array[2, 2] == true)
            {
                ifThereIsWinnerO = true;
            }

            //diagonal check O
            if (array[0, 0] == true && array[1, 1] == true && array[2, 2] == true)
            {
                ifThereIsWinnerO = true;
            }
            else if (array[2, 0] == true && array[1, 1] == true && array[0, 2] == true)
            {
                ifThereIsWinnerO |= true;
            }


            // X win prompt
            if (ifThereIsWinnerX == true)
            {
                MessageBox.Show("Winner is X");
            }
            else if(ifThereIsWinnerO == true)
            {
                MessageBox.Show("Winner is O");
            }
            else if (XOcount == 8)
            {
                MessageBox.Show("It is draw");
            }
            

        }
    }
}
