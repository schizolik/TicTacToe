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

        //tworze tablice, ruchy sa przekazywane parametrem z inputa, z przycisku. 
        //tworze prostego if sprawdzajacego ruch i wydajacy kontraruch od zadany aktualny,
        //teraz opcja ze zawsze wygra 
        //w przyszlosci potencjalnie drugi tryb gdzie zaczyna osoba
        //tbalica losuje liczby ruchu i sprawdza czy pole jest zajete czy nie poprzes sprawnienie parametry button.enabled = false.
        //im trudniejszy poziom tym wiecje prob losowania ma bot wedlug perfekcyjnego alrotmu
    }
}
