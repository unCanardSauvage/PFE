
namespace PFE_ARTICO
{
    partial class UserControl_Jouer
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.sideRight_panel = new System.Windows.Forms.Panel();
            this.settings_button = new System.Windows.Forms.Button();
            this.restart_button = new System.Windows.Forms.Button();
            this.main_panel = new System.Windows.Forms.Panel();
            this.sideRight_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sideRight_panel
            // 
            this.sideRight_panel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.sideRight_panel.Controls.Add(this.settings_button);
            this.sideRight_panel.Controls.Add(this.restart_button);
            this.sideRight_panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.sideRight_panel.Location = new System.Drawing.Point(688, 0);
            this.sideRight_panel.Name = "sideRight_panel";
            this.sideRight_panel.Size = new System.Drawing.Size(130, 547);
            this.sideRight_panel.TabIndex = 3;
            // 
            // settings_button
            // 
            this.settings_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settings_button.Location = new System.Drawing.Point(4, 174);
            this.settings_button.Name = "settings_button";
            this.settings_button.Size = new System.Drawing.Size(123, 46);
            this.settings_button.TabIndex = 1;
            this.settings_button.Text = "Options";
            this.settings_button.UseVisualStyleBackColor = true;
            this.settings_button.Click += new System.EventHandler(this.settings_button_Click);
            // 
            // restart_button
            // 
            this.restart_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.restart_button.Location = new System.Drawing.Point(4, 122);
            this.restart_button.Name = "restart_button";
            this.restart_button.Size = new System.Drawing.Size(123, 46);
            this.restart_button.TabIndex = 0;
            this.restart_button.Text = "Recommencer";
            this.restart_button.UseVisualStyleBackColor = true;
            this.restart_button.Click += new System.EventHandler(this.restart_button_Click);
            // 
            // main_panel
            // 
            this.main_panel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.main_panel.BackgroundImage = global::PFE_ARTICO.Properties.Resources.Jeu_bg;
            this.main_panel.Location = new System.Drawing.Point(0, 0);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(686, 547);
            this.main_panel.TabIndex = 2;
            // 
            // UserControl_Jouer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sideRight_panel);
            this.Controls.Add(this.main_panel);
            this.Name = "UserControl_Jouer";
            this.Size = new System.Drawing.Size(818, 547);
            this.Load += new System.EventHandler(this.UserControl_Jouer_Load);
            this.sideRight_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel main_panel;
        private System.Windows.Forms.Panel sideRight_panel;
        private System.Windows.Forms.Button settings_button;
        private System.Windows.Forms.Button restart_button;
    }
}
