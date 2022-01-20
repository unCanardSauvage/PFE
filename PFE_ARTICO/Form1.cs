using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PFE_ARTICO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            userControl_Jouer1.Show();
            userControl_Savoir1.SendToBack();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void play_button_Click(object sender, EventArgs e)
        {
            userControl_Jouer1.Show();
            userControl_Savoir1.SendToBack();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userControl_Savoir1.Show();
            userControl_Jouer1.SendToBack();
        }

        public void restartGame()
        {
            UserControl_Jouer userControl_JouerRestarted = new PFE_ARTICO.UserControl_Jouer(this);
        }
    }
}
