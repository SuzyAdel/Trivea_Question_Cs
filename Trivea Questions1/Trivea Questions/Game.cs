using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trivea_Questions
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Create_a_player cr = new Create_a_player();
            Hide();
            cr.Show();

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
