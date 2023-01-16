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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void button3x3_Click(object sender, EventArgs e)
        {
            game3x3 game3X3 = new game3x3(this);
            game3X3.Show();
        }

        private void button4x4_Click(object sender, EventArgs e)
        {
            Impossible impossible= new Impossible(this);
            impossible.Show();
        }

        private void buttonImpossible3x3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
