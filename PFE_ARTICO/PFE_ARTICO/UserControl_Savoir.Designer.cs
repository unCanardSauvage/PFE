
namespace PFE_ARTICO
{
    partial class UserControl_Savoir
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
            this.knowledges_button = new System.Windows.Forms.Button();
            this.rules_button = new System.Windows.Forms.Button();
            this.rules_panel = new System.Windows.Forms.Panel();
            this.knowledgePanel = new System.Windows.Forms.Panel();
            this.sideRight_panel.SuspendLayout();
            this.rules_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sideRight_panel
            // 
            this.sideRight_panel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.sideRight_panel.Controls.Add(this.knowledges_button);
            this.sideRight_panel.Controls.Add(this.rules_button);
            this.sideRight_panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.sideRight_panel.Location = new System.Drawing.Point(688, 0);
            this.sideRight_panel.Name = "sideRight_panel";
            this.sideRight_panel.Size = new System.Drawing.Size(130, 547);
            this.sideRight_panel.TabIndex = 4;
            // 
            // knowledges_button
            // 
            this.knowledges_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.knowledges_button.Location = new System.Drawing.Point(4, 174);
            this.knowledges_button.Name = "knowledges_button";
            this.knowledges_button.Size = new System.Drawing.Size(123, 46);
            this.knowledges_button.TabIndex = 1;
            this.knowledges_button.Text = "L\'Ordonnancement";
            this.knowledges_button.UseVisualStyleBackColor = true;
            this.knowledges_button.Click += new System.EventHandler(this.knowledges_button_Click);
            // 
            // rules_button
            // 
            this.rules_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rules_button.Location = new System.Drawing.Point(4, 122);
            this.rules_button.Name = "rules_button";
            this.rules_button.Size = new System.Drawing.Size(123, 46);
            this.rules_button.TabIndex = 0;
            this.rules_button.Text = "Règles";
            this.rules_button.UseVisualStyleBackColor = true;
            this.rules_button.Click += new System.EventHandler(this.rules_button_Click);
            // 
            // rules_panel
            // 
            this.rules_panel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rules_panel.BackgroundImage = global::PFE_ARTICO.Properties.Resources.regle;
            this.rules_panel.Controls.Add(this.knowledgePanel);
            this.rules_panel.Location = new System.Drawing.Point(0, 0);
            this.rules_panel.Name = "rules_panel";
            this.rules_panel.Size = new System.Drawing.Size(686, 547);
            this.rules_panel.TabIndex = 5;
            // 
            // knowledgePanel
            // 
            this.knowledgePanel.BackgroundImage = global::PFE_ARTICO.Properties.Resources.savoir;
            this.knowledgePanel.Location = new System.Drawing.Point(0, 0);
            this.knowledgePanel.Name = "knowledgePanel";
            this.knowledgePanel.Size = new System.Drawing.Size(686, 547);
            this.knowledgePanel.TabIndex = 0;
            // 
            // UserControl_Savoir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rules_panel);
            this.Controls.Add(this.sideRight_panel);
            this.Name = "UserControl_Savoir";
            this.Size = new System.Drawing.Size(818, 547);
            this.sideRight_panel.ResumeLayout(false);
            this.rules_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sideRight_panel;
        private System.Windows.Forms.Button knowledges_button;
        private System.Windows.Forms.Button rules_button;
        private System.Windows.Forms.Panel rules_panel;
        private System.Windows.Forms.Panel knowledgePanel;
    }
}
