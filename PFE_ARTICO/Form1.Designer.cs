
namespace PFE_ARTICO
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.side_panel = new System.Windows.Forms.Panel();
            this.play_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.userCtrl_panel = new System.Windows.Forms.Panel();
            this.userControl_Jouer1 = new PFE_ARTICO.UserControl_Jouer(this);
            this.userControl_Savoir1 = new PFE_ARTICO.UserControl_Savoir();
            this.side_panel.SuspendLayout();
            this.userCtrl_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // side_panel
            // 
            this.side_panel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.side_panel.Controls.Add(this.play_button);
            this.side_panel.Controls.Add(this.button1);
            this.side_panel.Controls.Add(this.exit_button);
            this.side_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.side_panel.Location = new System.Drawing.Point(0, 0);
            this.side_panel.Name = "side_panel";
            this.side_panel.Size = new System.Drawing.Size(130, 547);
            this.side_panel.TabIndex = 0;
            // 
            // play_button
            // 
            this.play_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.play_button.Location = new System.Drawing.Point(4, 122);
            this.play_button.Name = "play_button";
            this.play_button.Size = new System.Drawing.Size(123, 46);
            this.play_button.TabIndex = 3;
            this.play_button.Text = "Jouer";
            this.play_button.UseVisualStyleBackColor = true;
            this.play_button.Click += new System.EventHandler(this.play_button_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(4, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 46);
            this.button1.TabIndex = 2;
            this.button1.Text = "En savoir plus";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // exit_button
            // 
            this.exit_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit_button.Location = new System.Drawing.Point(4, 226);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(123, 46);
            this.exit_button.TabIndex = 1;
            this.exit_button.Text = "Quitter";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // userCtrl_panel
            // 
            this.userCtrl_panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userCtrl_panel.Controls.Add(this.userControl_Savoir1);
            this.userCtrl_panel.Controls.Add(this.userControl_Jouer1);
            this.userCtrl_panel.Location = new System.Drawing.Point(129, 0);
            this.userCtrl_panel.Name = "userCtrl_panel";
            this.userCtrl_panel.Size = new System.Drawing.Size(818, 547);
            this.userCtrl_panel.TabIndex = 1;
            // 
            // userControl_Jouer1
            // 
            this.userControl_Jouer1.Location = new System.Drawing.Point(0, 0);
            this.userControl_Jouer1.Name = "userControl_Jouer1";
            this.userControl_Jouer1.Size = new System.Drawing.Size(818, 547);
            this.userControl_Jouer1.TabIndex = 0;
            // 
            // userControl_Savoir1
            // 
            this.userControl_Savoir1.Location = new System.Drawing.Point(0, 0);
            this.userControl_Savoir1.Name = "userControl_Savoir1";
            this.userControl_Savoir1.Size = new System.Drawing.Size(818, 547);
            this.userControl_Savoir1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 547);
            this.Controls.Add(this.userCtrl_panel);
            this.Controls.Add(this.side_panel);
            this.Name = "Form1";
            this.side_panel.ResumeLayout(false);
            this.userCtrl_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel side_panel;
        private System.Windows.Forms.Panel userCtrl_panel;
        private System.Windows.Forms.Button play_button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button exit_button;
        private UserControl_Jouer userControl_Jouer1;
        private UserControl_Savoir userControl_Savoir1;
    }
}

