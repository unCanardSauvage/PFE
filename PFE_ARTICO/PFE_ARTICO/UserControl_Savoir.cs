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
    public partial class UserControl_Savoir : UserControl
    {
        public UserControl_Savoir()
        {
            InitializeComponent();
        }

        private void rules_button_Click(object sender, EventArgs e)
        {
            knowledgePanel.Visible = false;
            rules_panel.Visible = true;
        }

        private void knowledges_button_Click(object sender, EventArgs e)
        {
            knowledgePanel.Visible = true;
            //rules_panel.Visible = false;
        }
    }
}
