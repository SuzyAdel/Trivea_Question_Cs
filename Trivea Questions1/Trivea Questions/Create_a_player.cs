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
    public partial class Create_a_player : Form
    {
        public Create_a_player()
        {
            InitializeComponent();
        }
        int adding = 1;
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (adding == 1)
            {
                textBox1.Visible = true;
                adding++;
            }
            else 
            {
                string newText = textBox1.Text.Trim();

                // Add the text to the ComboBox if it is not empty
                if (!string.IsNullOrEmpty(newText))
                {
                    comboBox1.Items.Add(newText);
                    textBox1.Clear(); // clear the TextBox after adding
                }
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null && !string.IsNullOrEmpty(comboBox1.SelectedItem.ToString()))
            {
                // Call your method to start the game
                Que y = new Que();
                Hide();
                y.Show();
            }
            else
            {
                // Display a message or take other actions if an item is not selected
                MessageBox.Show("Please select a player before starting the game.");
            }
        }
    }
}
