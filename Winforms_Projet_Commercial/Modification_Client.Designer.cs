namespace Winforms_Projet_Commercial
{
    partial class frmModificationClient
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
            this.gbxIdentification = new System.Windows.Forms.GroupBox();
            this.txbVille = new System.Windows.Forms.TextBox();
            this.txbTelephone = new System.Windows.Forms.TextBox();
            this.txbCP = new System.Windows.Forms.TextBox();
            this.txbAdresse2 = new System.Windows.Forms.TextBox();
            this.txbAdresse = new System.Windows.Forms.TextBox();
            this.txbRaisonSociale = new System.Windows.Forms.TextBox();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.lblCpVille = new System.Windows.Forms.Label();
            this.lblAdresse = new System.Windows.Forms.Label();
            this.lblRaisonSociale = new System.Windows.Forms.Label();
            this.lblNumClientData = new System.Windows.Forms.Label();
            this.lblNumClient = new System.Windows.Forms.Label();
            this.gbxCaracteristiques = new System.Windows.Forms.GroupBox();
            this.cmbNature = new System.Windows.Forms.ComboBox();
            this.cmbActivite = new System.Windows.Forms.ComboBox();
            this.txbCA = new System.Windows.Forms.TextBox();
            this.txbEffectif = new System.Windows.Forms.TextBox();
            this.lblNature = new System.Windows.Forms.Label();
            this.lblCA = new System.Windows.Forms.Label();
            this.lblActivite = new System.Windows.Forms.Label();
            this.lblEffectif = new System.Windows.Forms.Label();
            this.chkbPrive = new System.Windows.Forms.CheckBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.gbxIdentification.SuspendLayout();
            this.gbxCaracteristiques.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxIdentification
            // 
            this.gbxIdentification.Controls.Add(this.txbVille);
            this.gbxIdentification.Controls.Add(this.txbTelephone);
            this.gbxIdentification.Controls.Add(this.txbCP);
            this.gbxIdentification.Controls.Add(this.txbAdresse2);
            this.gbxIdentification.Controls.Add(this.txbAdresse);
            this.gbxIdentification.Controls.Add(this.txbRaisonSociale);
            this.gbxIdentification.Controls.Add(this.lblTelephone);
            this.gbxIdentification.Controls.Add(this.lblCpVille);
            this.gbxIdentification.Controls.Add(this.lblAdresse);
            this.gbxIdentification.Controls.Add(this.lblRaisonSociale);
            this.gbxIdentification.Controls.Add(this.lblNumClientData);
            this.gbxIdentification.Controls.Add(this.lblNumClient);
            this.gbxIdentification.Location = new System.Drawing.Point(13, 13);
            this.gbxIdentification.Name = "gbxIdentification";
            this.gbxIdentification.Size = new System.Drawing.Size(398, 195);
            this.gbxIdentification.TabIndex = 0;
            this.gbxIdentification.TabStop = false;
            this.gbxIdentification.Text = "Identification";
            // 
            // txbVille
            // 
            this.txbVille.Location = new System.Drawing.Point(185, 138);
            this.txbVille.Name = "txbVille";
            this.txbVille.Size = new System.Drawing.Size(187, 20);
            this.txbVille.TabIndex = 11;
            // 
            // txbTelephone
            // 
            this.txbTelephone.Location = new System.Drawing.Point(100, 168);
            this.txbTelephone.Name = "txbTelephone";
            this.txbTelephone.Size = new System.Drawing.Size(148, 20);
            this.txbTelephone.TabIndex = 10;
            // 
            // txbCP
            // 
            this.txbCP.Location = new System.Drawing.Point(100, 138);
            this.txbCP.Name = "txbCP";
            this.txbCP.Size = new System.Drawing.Size(79, 20);
            this.txbCP.TabIndex = 9;
            // 
            // txbAdresse2
            // 
            this.txbAdresse2.Location = new System.Drawing.Point(100, 109);
            this.txbAdresse2.Name = "txbAdresse2";
            this.txbAdresse2.Size = new System.Drawing.Size(272, 20);
            this.txbAdresse2.TabIndex = 8;
            // 
            // txbAdresse
            // 
            this.txbAdresse.Location = new System.Drawing.Point(100, 80);
            this.txbAdresse.Name = "txbAdresse";
            this.txbAdresse.Size = new System.Drawing.Size(272, 20);
            this.txbAdresse.TabIndex = 7;
            // 
            // txbRaisonSociale
            // 
            this.txbRaisonSociale.Location = new System.Drawing.Point(100, 49);
            this.txbRaisonSociale.Name = "txbRaisonSociale";
            this.txbRaisonSociale.Size = new System.Drawing.Size(272, 20);
            this.txbRaisonSociale.TabIndex = 6;
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Location = new System.Drawing.Point(30, 168);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(64, 13);
            this.lblTelephone.TabIndex = 5;
            this.lblTelephone.Text = "Téléphone :";
            // 
            // lblCpVille
            // 
            this.lblCpVille.AutoSize = true;
            this.lblCpVille.Location = new System.Drawing.Point(33, 141);
            this.lblCpVille.Name = "lblCpVille";
            this.lblCpVille.Size = new System.Drawing.Size(61, 13);
            this.lblCpVille.TabIndex = 4;
            this.lblCpVille.Text = "CP et Ville :";
            // 
            // lblAdresse
            // 
            this.lblAdresse.AutoSize = true;
            this.lblAdresse.Location = new System.Drawing.Point(43, 83);
            this.lblAdresse.Name = "lblAdresse";
            this.lblAdresse.Size = new System.Drawing.Size(51, 13);
            this.lblAdresse.TabIndex = 3;
            this.lblAdresse.Text = "Adresse :";
            // 
            // lblRaisonSociale
            // 
            this.lblRaisonSociale.AutoSize = true;
            this.lblRaisonSociale.Location = new System.Drawing.Point(10, 49);
            this.lblRaisonSociale.Name = "lblRaisonSociale";
            this.lblRaisonSociale.Size = new System.Drawing.Size(84, 13);
            this.lblRaisonSociale.TabIndex = 2;
            this.lblRaisonSociale.Text = "Raison Sociale :";
            // 
            // lblNumClientData
            // 
            this.lblNumClientData.AutoSize = true;
            this.lblNumClientData.Location = new System.Drawing.Point(94, 20);
            this.lblNumClientData.Name = "lblNumClientData";
            this.lblNumClientData.Size = new System.Drawing.Size(47, 13);
            this.lblNumClientData.TabIndex = 1;
            this.lblNumClientData.Text = "Exemple";
            // 
            // lblNumClient
            // 
            this.lblNumClient.AutoSize = true;
            this.lblNumClient.Location = new System.Drawing.Point(10, 20);
            this.lblNumClient.Name = "lblNumClient";
            this.lblNumClient.Size = new System.Drawing.Size(78, 13);
            this.lblNumClient.TabIndex = 0;
            this.lblNumClient.Text = "Numéro client :";
            // 
            // gbxCaracteristiques
            // 
            this.gbxCaracteristiques.Controls.Add(this.cmbNature);
            this.gbxCaracteristiques.Controls.Add(this.cmbActivite);
            this.gbxCaracteristiques.Controls.Add(this.txbCA);
            this.gbxCaracteristiques.Controls.Add(this.txbEffectif);
            this.gbxCaracteristiques.Controls.Add(this.lblNature);
            this.gbxCaracteristiques.Controls.Add(this.lblCA);
            this.gbxCaracteristiques.Controls.Add(this.lblActivite);
            this.gbxCaracteristiques.Controls.Add(this.lblEffectif);
            this.gbxCaracteristiques.Controls.Add(this.chkbPrive);
            this.gbxCaracteristiques.Location = new System.Drawing.Point(13, 215);
            this.gbxCaracteristiques.Name = "gbxCaracteristiques";
            this.gbxCaracteristiques.Size = new System.Drawing.Size(398, 130);
            this.gbxCaracteristiques.TabIndex = 1;
            this.gbxCaracteristiques.TabStop = false;
            this.gbxCaracteristiques.Text = "Caractéristiques";
            // 
            // cmbNature
            // 
            this.cmbNature.FormattingEnabled = true;
            this.cmbNature.Location = new System.Drawing.Point(233, 82);
            this.cmbNature.Name = "cmbNature";
            this.cmbNature.Size = new System.Drawing.Size(121, 21);
            this.cmbNature.TabIndex = 8;
            // 
            // cmbActivite
            // 
            this.cmbActivite.FormattingEnabled = true;
            this.cmbActivite.Location = new System.Drawing.Point(59, 79);
            this.cmbActivite.Name = "cmbActivite";
            this.cmbActivite.Size = new System.Drawing.Size(100, 21);
            this.cmbActivite.TabIndex = 7;
            // 
            // txbCA
            // 
            this.txbCA.Location = new System.Drawing.Point(215, 40);
            this.txbCA.Name = "txbCA";
            this.txbCA.Size = new System.Drawing.Size(139, 20);
            this.txbCA.TabIndex = 6;
            // 
            // txbEffectif
            // 
            this.txbEffectif.Location = new System.Drawing.Point(59, 40);
            this.txbEffectif.Name = "txbEffectif";
            this.txbEffectif.Size = new System.Drawing.Size(100, 20);
            this.txbEffectif.TabIndex = 5;
            // 
            // lblNature
            // 
            this.lblNature.AutoSize = true;
            this.lblNature.Location = new System.Drawing.Point(182, 85);
            this.lblNature.Name = "lblNature";
            this.lblNature.Size = new System.Drawing.Size(45, 13);
            this.lblNature.TabIndex = 4;
            this.lblNature.Text = "Nature :";
            // 
            // lblCA
            // 
            this.lblCA.AutoSize = true;
            this.lblCA.Location = new System.Drawing.Point(182, 44);
            this.lblCA.Name = "lblCA";
            this.lblCA.Size = new System.Drawing.Size(27, 13);
            this.lblCA.TabIndex = 3;
            this.lblCA.Text = "CA :";
            // 
            // lblActivite
            // 
            this.lblActivite.AutoSize = true;
            this.lblActivite.Location = new System.Drawing.Point(10, 82);
            this.lblActivite.Name = "lblActivite";
            this.lblActivite.Size = new System.Drawing.Size(48, 13);
            this.lblActivite.TabIndex = 2;
            this.lblActivite.Text = "Activité :";
            // 
            // lblEffectif
            // 
            this.lblEffectif.AutoSize = true;
            this.lblEffectif.Location = new System.Drawing.Point(10, 47);
            this.lblEffectif.Name = "lblEffectif";
            this.lblEffectif.Size = new System.Drawing.Size(46, 13);
            this.lblEffectif.TabIndex = 1;
            this.lblEffectif.Text = "Effectif :";
            // 
            // chkbPrive
            // 
            this.chkbPrive.AutoSize = true;
            this.chkbPrive.Location = new System.Drawing.Point(7, 20);
            this.chkbPrive.Name = "chkbPrive";
            this.chkbPrive.Size = new System.Drawing.Size(50, 17);
            this.chkbPrive.TabIndex = 0;
            this.chkbPrive.Text = "Privé";
            this.chkbPrive.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(255, 351);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(336, 351);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 3;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // frmModificationClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 385);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.gbxCaracteristiques);
            this.Controls.Add(this.gbxIdentification);
            this.Name = "frmModificationClient";
            this.Text = "Modification Client";
            this.gbxIdentification.ResumeLayout(false);
            this.gbxIdentification.PerformLayout();
            this.gbxCaracteristiques.ResumeLayout(false);
            this.gbxCaracteristiques.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxIdentification;
        private System.Windows.Forms.TextBox txbVille;
        private System.Windows.Forms.TextBox txbTelephone;
        private System.Windows.Forms.TextBox txbCP;
        private System.Windows.Forms.TextBox txbAdresse2;
        private System.Windows.Forms.TextBox txbAdresse;
        private System.Windows.Forms.TextBox txbRaisonSociale;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.Label lblCpVille;
        private System.Windows.Forms.Label lblAdresse;
        private System.Windows.Forms.Label lblRaisonSociale;
        private System.Windows.Forms.Label lblNumClientData;
        private System.Windows.Forms.Label lblNumClient;
        private System.Windows.Forms.GroupBox gbxCaracteristiques;
        private System.Windows.Forms.ComboBox cmbNature;
        private System.Windows.Forms.ComboBox cmbActivite;
        private System.Windows.Forms.TextBox txbCA;
        private System.Windows.Forms.TextBox txbEffectif;
        private System.Windows.Forms.Label lblNature;
        private System.Windows.Forms.Label lblCA;
        private System.Windows.Forms.Label lblActivite;
        private System.Windows.Forms.Label lblEffectif;
        private System.Windows.Forms.CheckBox chkbPrive;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnAnnuler;
    }
}