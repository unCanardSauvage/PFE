using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PFE_ARTICO
{
    class Grid
    {
        public int Groupe { get; set; }

        // S'il y a une tache du même groupe, passe à true
        public bool isHaveATask { get; set; }

        // Où commence la partie de grille
        public int Location { get; set; }

        public Grid(Panel panel, int size, int groupe, int x)
            : base()
        {
            Groupe = groupe;
            for (int i = 0; i < size; i++)
            {
                if (i == size - 1)
                {
                    var myPanel = new Panel
                    {
                        Size = new System.Drawing.Size(20, 30),
                        Location = new System.Drawing.Point(15 + 20 * i + x * 20, 30 + Groupe * 45),
                        BackColor = Color.LightGray,
                        BorderStyle = BorderStyle.FixedSingle,
                        Visible = true,
                        Enabled = true
                    };
                    myPanel.SendToBack();
                    panel.Controls.Add(myPanel);
                }
                else
                {
                    var myPanel = new Panel
                    {
                        Size = new System.Drawing.Size(20, 30),
                        Location = new System.Drawing.Point(15 + 20 * i + x * 20, 30 + Groupe * 45),
                        BackColor = chooseColor(groupe),
                        BorderStyle = BorderStyle.FixedSingle,
                        Visible = true,
                        Enabled = true,
                    };
                    myPanel.SendToBack();
                    panel.Controls.Add(myPanel);
                }
            }
        }

        private Color chooseColor(int nbr)
        {
            Color color;

            switch (nbr)
            {
                case 0:
                    color = Color.LightPink;
                    break;
                case 1:
                    color = Color.LightBlue;
                    break;
                case 2:
                    color = Color.MediumPurple;
                    break;
                case 3:
                    color = Color.LightGreen;
                    break;
                case 4:
                    color = Color.LightGoldenrodYellow;
                    break;
                case 5:
                    color = Color.Transparent;
                    break;
                case 6:
                    color = Color.LightSlateGray;
                    break;
                default:
                    color = Color.LightCoral;
                    break;
            }

            return color;
        }


    }
}
