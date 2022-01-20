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
    public partial class Settings_Form : Form
    {
        UserControl_Jouer user;

        public Settings_Form(UserControl_Jouer userCtrl)
        {

            InitializeComponent();
            
        }

        private void selectRadioButton(UserControl_Jouer user)
        {
            switch (user.nbTask)
            {
                case 2:
                    radioButton1.Checked = true;
                    break;
                case 3:
                    radioButton2.Checked = true;
                    break;
                case 4:
                    radioButton3.Checked = true;
                    break;
                case 5:
                    radioButton4.Checked = true;
                    break;

            }
        }

        private int chooseNbr()
        {
            int nbr = 0;

            if (radioButton1.Checked)
            {
                nbr = 2;
            }
            if (radioButton2.Checked)
            {
                nbr = 3;
            }
            if (radioButton3.Checked)
            {
                nbr = 4;
            }
            if (radioButton4.Checked)
            {
                nbr = 5;
            }

            return nbr;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            user.nbTask = chooseNbr();
            this.Close();            
        }
    }
}
