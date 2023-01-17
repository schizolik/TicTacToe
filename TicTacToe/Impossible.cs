using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Impossible : Form
    {
        public Impossible(menu menu)
        {
            InitializeComponent();
        }

        int XOcount = 0;
        int[,] array = new int[3, 3];



        private void onClick(int x, int y)
        {
            if(XOcount % 2 == 0)
            {

                array[x, y] = -1;

                if (x == 0)
                {
                    if (y == 0)
                    {
                        button1.Text = "O";
                        button1.Enabled = false;
                        button1.BackColor = Color.Tomato;
                    }

                    else if (y == 1)
                    {
                        button2.Text = "O";
                        button2.Enabled = false;
                        button2.BackColor = Color.Tomato;

                    }
                    else if (y == 2)
                    {
                        button3.Text = "O";
                        button3.Enabled = false;
                        button3.BackColor = Color.Tomato;
                    }
                }

                else if(x == 1)
                {
                    if (y == 0)
                    {
                        button4.Text = "O";
                        button4.Enabled = false;
                        button5.BackColor = Color.Tomato;
                    }

                    else if (y == 1)
                    {
                        button5.Text = "O";
                        button5.Enabled = false;
                        button5.BackColor = Color.Tomato;

                    }
                    else if (y == 2)
                    {
                        button5.Text = "O";
                        button5.Enabled = false;
                        button5.BackColor = Color.Tomato;
                    }
                }
            }
            XOcount++;
        }








        //tworze tablice, ruchy sa przekazywane parametrem z inputa, z przycisku. 
        //tworze prostego if sprawdzajacego ruch i wydajacy kontraruch od zadany aktualny,
        //teraz opcja ze zawsze wygra 
        //w przyszlosci potencjalnie drugi tryb gdzie zaczyna osoba
        //tbalica losuje liczby ruchu i sprawdza czy pole jest zajete czy nie poprzes sprawnienie parametry button.enabled = false.
        //im trudniejszy poziom tym wiecje prob losowania ma bot wedlug perfekcyjnego alrotmu
    }
}
