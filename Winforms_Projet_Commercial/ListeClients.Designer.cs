namespace WinForm_projet_Commerciale
{
    partial class frmListeClients
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnRaisonSociale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnVille = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCodePostal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColumnActivite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNature = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblRechercher = new System.Windows.Forms.Label();
            this.textbRechercher = new System.Windows.Forms.TextBox();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.btnTous = new System.Windows.Forms.Button();
            this.btnNouveauClient = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            this.lblInfoDoubleClick = new System.Windows.Forms.Label();
            this.grpbRecherche = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpbRecherche.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnRaisonSociale,
            this.ColumnVille,
            this.ColumnCodePostal,
            this.ColumnPrive,
            this.ColumnActivite,
            this.ColumnNature});
            this.dataGridView1.Location = new System.Drawing.Point(12, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 371);
            this.dataGridView1.TabIndex = 0;
            // 
            // ColumnRaisonSociale
            // 
            this.ColumnRaisonSociale.HeaderText = "Raison Sociale";
            this.ColumnRaisonSociale.Name = "ColumnRaisonSociale";
            this.ColumnRaisonSociale.Width = 125;
            // 
            // ColumnVille
            // 
            this.ColumnVille.HeaderText = "Ville";
            this.ColumnVille.Name = "ColumnVille";
            this.ColumnVille.Width = 125;
            // 
            // ColumnCodePostal
            // 
            this.ColumnCodePostal.HeaderText = "Code Postal";
            this.ColumnCodePostal.Name = "ColumnCodePostal";
            this.ColumnCodePostal.Width = 115;
            // 
            // ColumnPrive
            // 
            this.ColumnPrive.HeaderText = "Privé ?";
            this.ColumnPrive.Name = "ColumnPrive";
            this.ColumnPrive.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnPrive.Width = 115;
            // 
            // ColumnActivite
            // 
            this.ColumnActivite.HeaderText = "Activité";
            this.ColumnActivite.Name = "ColumnActivite";
            this.ColumnActivite.Width = 125;
            // 
            // ColumnNature
            // 
            this.ColumnNature.HeaderText = "Nature";
            this.ColumnNature.Name = "ColumnNature";
            this.ColumnNature.Width = 125;
            // 
            // lblRechercher
            // 
            this.lblRechercher.AutoSize = true;
            this.lblRechercher.Location = new System.Drawing.Point(13, 20);
            this.lblRechercher.Name = "lblRechercher";
            this.lblRechercher.Size = new System.Drawing.Size(69, 13);
            this.lblRechercher.TabIndex = 1;
            this.lblRechercher.Text = "Rechercher :";
            // 
            // textbRechercher
            // 
            this.textbRechercher.Location = new System.Drawing.Point(88, 17);
            this.textbRechercher.Name = "textbRechercher";
            this.textbRechercher.Size = new System.Drawing.Size(318, 20);
            this.textbRechercher.TabIndex = 2;
            // 
            // btnRechercher
            // 
            this.btnRechercher.Location = new System.Drawing.Point(531, 17);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(122, 25);
            this.btnRechercher.TabIndex = 3;
            this.btnRechercher.Text = "Rechercher";
            this.btnRechercher.UseVisualStyleBackColor = true;
            // 
            // btnTous
            // 
            this.btnTous.Location = new System.Drawing.Point(659, 17);
            this.btnTous.Name = "btnTous";
            this.btnTous.Size = new System.Drawing.Size(122, 25);
            this.btnTous.TabIndex = 4;
            this.btnTous.Text = "Tous";
            this.btnTous.UseVisualStyleBackColor = true;
            // 
            // btnNouveauClient
            // 
            this.btnNouveauClient.Location = new System.Drawing.Point(410, 444);
            this.btnNouveauClient.Name = "btnNouveauClient";
            this.btnNouveauClient.Size = new System.Drawing.Size(122, 25);
            this.btnNouveauClient.TabIndex = 5;
            this.btnNouveauClient.Text = "Nouveau Client";
            this.btnNouveauClient.UseVisualStyleBackColor = true;
            this.btnNouveauClient.Click += new System.EventHandler(this.btnNouveauClient_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(538, 444);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(122, 25);
            this.btnSupprimer.TabIndex = 6;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(666, 444);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(122, 25);
            this.btnFermer.TabIndex = 7;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            // 
            // lblInfoDoubleClick
            // 
            this.lblInfoDoubleClick.AutoSize = true;
            this.lblInfoDoubleClick.Location = new System.Drawing.Point(19, 452);
            this.lblInfoDoubleClick.Name = "lblInfoDoubleClick";
            this.lblInfoDoubleClick.Size = new System.Drawing.Size(177, 13);
            this.lblInfoDoubleClick.TabIndex = 8;
            this.lblInfoDoubleClick.Text = "Double click pour consulter/modifier";
            // 
            // grpbRecherche
            // 
            this.grpbRecherche.Controls.Add(this.btnTous);
            this.grpbRecherche.Controls.Add(this.btnRechercher);
            this.grpbRecherche.Controls.Add(this.textbRechercher);
            this.grpbRecherche.Controls.Add(this.lblRechercher);
            this.grpbRecherche.Location = new System.Drawing.Point(7, 8);
            this.grpbRecherche.Name = "grpbRecherche";
            this.grpbRecherche.Size = new System.Drawing.Size(789, 53);
            this.grpbRecherche.TabIndex = 9;
            this.grpbRecherche.TabStop = false;
            this.grpbRecherche.Text = "Recherche";
            // 
            // frmListeClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.grpbRecherche);
            this.Controls.Add(this.lblInfoDoubleClick);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnNouveauClient);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmListeClients";
            this.Text = "Liste des clients";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpbRecherche.ResumeLayout(false);
            this.grpbRecherche.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRaisonSociale;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnVille;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCodePostal;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnPrive;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnActivite;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNature;
        private System.Windows.Forms.Label lblRechercher;
        private System.Windows.Forms.TextBox textbRechercher;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.Button btnTous;
        private System.Windows.Forms.Button btnNouveauClient;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Label lblInfoDoubleClick;
        private System.Windows.Forms.GroupBox grpbRecherche;
    }
}