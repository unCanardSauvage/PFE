using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace PFE_ARTICO
{
    public partial class UserControl_Jouer : UserControl
    {

        List<List<Tache>> tasksList = new List<List<Tache>>();
        public int nbTask { get; set; }
        List<int> capacityList = new List<int>();
        List<int> periodicityList = new List<int>();


        public UserControl_Jouer()
        {
            InitializeComponent();
            nbTask = 5;
            initGame();

        }

        private void restart_button_Click(object sender, EventArgs e)
        {
            resetGame();
        }

        public void resetGame()
        {
            main_panel.Controls.Clear();
            initGame();
        }

        private void settings_button_Click(object sender, EventArgs e)
        {
            var form = new Settings_Form(this);
            form.Show();
        }


        public void movePanel(Panel myPanel)
        {
            Point firstPoint = new Point();

            myPanel.MouseDown += (ss, ee) =>
            {
                if (ee.Button == MouseButtons.Left) { firstPoint = Control.MousePosition; }
            };

            myPanel.MouseMove += (ss, ee) =>
            {
                if (ee.Button == MouseButtons.Left)
                {
                    // Création d'un point temporaire
                    Point temp = Control.MousePosition;
                    Point res = new Point(firstPoint.X - temp.X, firstPoint.Y - temp.Y);

                    // Assignation des nouvelles valeures au panel
                    int x = myPanel.Location.X - res.X;
                    int y = myPanel.Location.Y - res.Y;

                    myPanel.Location = new Point(x, y);

                    // Actualisation du point de départ
                    firstPoint = temp;
                }
                else
                {
                    int x = myPanel.Location.X;
                    int y = myPanel.Location.Y;

                    // Permet de bien positionner la tâche dans la grille
                    if (y < 250)
                    {
                        x = adaptXPoint(x);
                        y = adaptYPoint(y);
                        myPanel.Location = new Point(x, y);
                    }
                    
                }

            };
        }

        private int adaptXPoint(int x)
        {
            int borneA = 0;
            int borneB = 0;
            for (int i = 0; i < 33; i++)
            {
                borneA = i * 20 + 5;
                borneB = i * 20 + 25;

                if (x > borneA && x <= borneB)
                    x = i * 20 + 15;

            }

            return x;
        }

        private int adaptYPoint(int y)
        {
            int borneA = 0;
            int borneB = 0;
            for (int i = 0; i < 5; i++)
            {
                borneA = 8 + i * 45;
                borneB = 53 + i * 45;

                if (y > borneA && y <= borneB)
                    y = 30 + i * 45;

            }
            return y;
        }

        private void initGame()
        {
            bool isPossible;
            Random rnd = new Random();
            double u; // Somme permettant de définir l'ordonnançabilité du jeu de tâches


            int capacity; // Taille de la tâche dans le temps
            int periodicity; // Fréquence de répétition de la tâche          

            do
            {
                capacityList.Clear();
                periodicityList.Clear();

                List<double> utest = new List<double>();
                u = 0.0;

                // Création des tâches
                int nbCreated = 0;
                while (nbCreated < nbTask)
                {
                    // On génère aléatoirement la taille (capacité) de la tâche
                    capacity = rnd.Next(1, 5);
                    // On ajoute à la liste correspondante
                    capacityList.Add(capacity);

                    // On génère aléatoirement la période (répétition) de la tâche
                    periodicity = rnd.Next(1, 10);
                    // On ajoute à la liste correspondante
                    periodicityList.Add(periodicity);

                    nbCreated++;
                }

                // Vérification de la possibilité d'ordonnancement
                for (int i = 0; i < nbTask; i++)
                {
                    u += (double)capacityList[i] / (double)periodicityList[i];
                    utest.Add(u);
                }

                if (u <= 1.0)
                    isPossible = true;
                else
                    isPossible = false;

            } while (!isPossible);

            int name = 0;
            for (int i = 0; i < nbTask; i++)
            {
                List<Tache> taskList = new List<Tache>();
                for (int j = 0; j < 33 / periodicityList[i]; j++)
                {
                    var myTask = new Tache
                    {
                        Groupe = i,
                        Size = new System.Drawing.Size(capacityList[i] * 20, 30),
                        Location = new System.Drawing.Point(15 + capacityList[i] * 20 * (j) + (10 * j), 275 + 50 * i),
                        BackColor = chooseColor(i),
                        Visible = true,
                        Enabled = true,
                        Name = name.ToString()
                    };
                    taskList.Add(myTask);
                    main_panel.Controls.Add(myTask);
                    movePanel(myTask);

                    name++;
                }
                tasksList.Add(taskList);
            }

            // Creation de la grille
            for (int i = 0; i < nbTask; i++)
            {
                for (int j = 0; j < 33 / periodicityList[i]; j++)
                {
                    var myGrid = new Grid(main_panel, periodicityList[i], i, periodicityList[i] * j)
                    {
                        Groupe = i,
                        isHaveATask = false
                    };
                    

                }
            }


            // Creation d'une grille factice
            drawingGridBG(nbTask, main_panel);
        }

        private void drawingGridBG(int nbrTaches, Panel panel)
        {
            for (int i = 0; i < nbrTaches; i++)
            {
                for (int j = 0; j < 33; j++)
                {
                    var myPanel = new Panel
                    {
                        Size = new System.Drawing.Size(20, 30),
                        Location = new System.Drawing.Point(15 + 20 * j, 30 + i * 45),
                        BackColor = Color.Transparent,
                        BorderStyle = BorderStyle.FixedSingle,
                        Visible = true,
                        Enabled = true
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
                    color = Color.Red;
                    break;
                case 1:
                    color = Color.LightSkyBlue;
                    break;
                case 2:
                    color = Color.BlueViolet;
                    break;
                case 3:
                    color = Color.ForestGreen;
                    break;
                case 4:
                    color = Color.Orange;
                    break;
                case 5:
                    color = Color.Purple;
                    break;
                case 6:
                    color = Color.Gray;
                    break;
                default:
                    color = Color.LightCoral;
                    break;
            }

            return color;
        }

        private void UserControl_Jouer_Load(object sender, EventArgs e)
        {
            
        }

        
    }
}
