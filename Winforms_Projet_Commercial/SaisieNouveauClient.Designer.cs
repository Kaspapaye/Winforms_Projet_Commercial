namespace WinForm_projet_Commerciale
{
    partial class frmAjoutNouveauClient
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
            this.lblNumeroClient = new System.Windows.Forms.Label();
            this.txtbNumeroClient = new System.Windows.Forms.TextBox();
            this.txtbTelephone = new System.Windows.Forms.TextBox();
            this.txtbVille = new System.Windows.Forms.TextBox();
            this.txtbCP = new System.Windows.Forms.TextBox();
            this.txtbAdresseSuite = new System.Windows.Forms.TextBox();
            this.txtbAdresse = new System.Windows.Forms.TextBox();
            this.txtbRaisonSociale = new System.Windows.Forms.TextBox();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.lblCP = new System.Windows.Forms.Label();
            this.lblAdresse = new System.Windows.Forms.Label();
            this.lblRaisonSociale = new System.Windows.Forms.Label();
            this.lblEt = new System.Windows.Forms.Label();
            this.lblVille = new System.Windows.Forms.Label();
            this.grpbIdentification = new System.Windows.Forms.GroupBox();
            this.chkbPrive = new System.Windows.Forms.CheckBox();
            this.lblEffectif = new System.Windows.Forms.Label();
            this.lblCA = new System.Windows.Forms.Label();
            this.lblNature = new System.Windows.Forms.Label();
            this.lblActivite = new System.Windows.Forms.Label();
            this.txtbEffectif = new System.Windows.Forms.TextBox();
            this.txtbCA = new System.Windows.Forms.TextBox();
            this.lstbActivite = new System.Windows.Forms.ListBox();
            this.lstbNature = new System.Windows.Forms.ListBox();
            this.grpbCaracteristiques = new System.Windows.Forms.GroupBox();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnContacts = new System.Windows.Forms.Button();
            this.grpbIdentification.SuspendLayout();
            this.grpbCaracteristiques.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNumeroClient
            // 
            this.lblNumeroClient.AutoSize = true;
            this.lblNumeroClient.Location = new System.Drawing.Point(12, 20);
            this.lblNumeroClient.Name = "lblNumeroClient";
            this.lblNumeroClient.Size = new System.Drawing.Size(79, 13);
            this.lblNumeroClient.TabIndex = 0;
            this.lblNumeroClient.Text = "Numéro Client :";
            // 
            // txtbNumeroClient
            // 
            this.txtbNumeroClient.Location = new System.Drawing.Point(97, 17);
            this.txtbNumeroClient.Name = "txtbNumeroClient";
            this.txtbNumeroClient.Size = new System.Drawing.Size(315, 20);
            this.txtbNumeroClient.TabIndex = 1;
            this.txtbNumeroClient.TextChanged += new System.EventHandler(this.txtbNumeroClient_TextChanged);
            // 
            // txtbTelephone
            // 
            this.txtbTelephone.Location = new System.Drawing.Point(97, 147);
            this.txtbTelephone.Name = "txtbTelephone";
            this.txtbTelephone.Size = new System.Drawing.Size(181, 20);
            this.txtbTelephone.TabIndex = 2;
            // 
            // txtbVille
            // 
            this.txtbVille.Location = new System.Drawing.Point(190, 121);
            this.txtbVille.Name = "txtbVille";
            this.txtbVille.Size = new System.Drawing.Size(222, 20);
            this.txtbVille.TabIndex = 3;
            // 
            // txtbCP
            // 
            this.txtbCP.Location = new System.Drawing.Point(97, 121);
            this.txtbCP.Name = "txtbCP";
            this.txtbCP.Size = new System.Drawing.Size(87, 20);
            this.txtbCP.TabIndex = 4;
            // 
            // txtbAdresseSuite
            // 
            this.txtbAdresseSuite.Location = new System.Drawing.Point(97, 95);
            this.txtbAdresseSuite.Name = "txtbAdresseSuite";
            this.txtbAdresseSuite.Size = new System.Drawing.Size(315, 20);
            this.txtbAdresseSuite.TabIndex = 5;
            // 
            // txtbAdresse
            // 
            this.txtbAdresse.Location = new System.Drawing.Point(97, 69);
            this.txtbAdresse.Name = "txtbAdresse";
            this.txtbAdresse.Size = new System.Drawing.Size(315, 20);
            this.txtbAdresse.TabIndex = 6;
            // 
            // txtbRaisonSociale
            // 
            this.txtbRaisonSociale.Location = new System.Drawing.Point(97, 43);
            this.txtbRaisonSociale.Name = "txtbRaisonSociale";
            this.txtbRaisonSociale.Size = new System.Drawing.Size(315, 20);
            this.txtbRaisonSociale.TabIndex = 7;
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Location = new System.Drawing.Point(12, 150);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(64, 13);
            this.lblTelephone.TabIndex = 8;
            this.lblTelephone.Text = "Téléphone :";
            // 
            // lblCP
            // 
            this.lblCP.AutoSize = true;
            this.lblCP.Location = new System.Drawing.Point(12, 124);
            this.lblCP.Name = "lblCP";
            this.lblCP.Size = new System.Drawing.Size(24, 13);
            this.lblCP.TabIndex = 9;
            this.lblCP.Text = "CP ";
            // 
            // lblAdresse
            // 
            this.lblAdresse.AutoSize = true;
            this.lblAdresse.Location = new System.Drawing.Point(12, 72);
            this.lblAdresse.Name = "lblAdresse";
            this.lblAdresse.Size = new System.Drawing.Size(51, 13);
            this.lblAdresse.TabIndex = 10;
            this.lblAdresse.Text = "Adresse :";
            // 
            // lblRaisonSociale
            // 
            this.lblRaisonSociale.AutoSize = true;
            this.lblRaisonSociale.Location = new System.Drawing.Point(12, 46);
            this.lblRaisonSociale.Name = "lblRaisonSociale";
            this.lblRaisonSociale.Size = new System.Drawing.Size(84, 13);
            this.lblRaisonSociale.TabIndex = 11;
            this.lblRaisonSociale.Text = "Raison Sociale :";
            // 
            // lblEt
            // 
            this.lblEt.AutoSize = true;
            this.lblEt.Location = new System.Drawing.Point(37, 124);
            this.lblEt.Name = "lblEt";
            this.lblEt.Size = new System.Drawing.Size(16, 13);
            this.lblEt.TabIndex = 12;
            this.lblEt.Text = "et";
            // 
            // lblVille
            // 
            this.lblVille.AutoSize = true;
            this.lblVille.Location = new System.Drawing.Point(59, 124);
            this.lblVille.Name = "lblVille";
            this.lblVille.Size = new System.Drawing.Size(32, 13);
            this.lblVille.TabIndex = 13;
            this.lblVille.Text = "Ville :";
            // 
            // grpbIdentification
            // 
            this.grpbIdentification.Controls.Add(this.lblVille);
            this.grpbIdentification.Controls.Add(this.lblEt);
            this.grpbIdentification.Controls.Add(this.lblRaisonSociale);
            this.grpbIdentification.Controls.Add(this.lblAdresse);
            this.grpbIdentification.Controls.Add(this.lblCP);
            this.grpbIdentification.Controls.Add(this.lblTelephone);
            this.grpbIdentification.Controls.Add(this.txtbRaisonSociale);
            this.grpbIdentification.Controls.Add(this.txtbAdresse);
            this.grpbIdentification.Controls.Add(this.txtbAdresseSuite);
            this.grpbIdentification.Controls.Add(this.txtbCP);
            this.grpbIdentification.Controls.Add(this.txtbVille);
            this.grpbIdentification.Controls.Add(this.txtbTelephone);
            this.grpbIdentification.Controls.Add(this.txtbNumeroClient);
            this.grpbIdentification.Controls.Add(this.lblNumeroClient);
            this.grpbIdentification.Location = new System.Drawing.Point(5, 21);
            this.grpbIdentification.Name = "grpbIdentification";
            this.grpbIdentification.Size = new System.Drawing.Size(430, 179);
            this.grpbIdentification.TabIndex = 14;
            this.grpbIdentification.TabStop = false;
            this.grpbIdentification.Text = "Identification";
            // 
            // chkbPrive
            // 
            this.chkbPrive.AutoSize = true;
            this.chkbPrive.Location = new System.Drawing.Point(7, 19);
            this.chkbPrive.Name = "chkbPrive";
            this.chkbPrive.Size = new System.Drawing.Size(50, 17);
            this.chkbPrive.TabIndex = 15;
            this.chkbPrive.Text = "Privé";
            this.chkbPrive.UseVisualStyleBackColor = true;
            // 
            // lblEffectif
            // 
            this.lblEffectif.AutoSize = true;
            this.lblEffectif.Location = new System.Drawing.Point(6, 44);
            this.lblEffectif.Name = "lblEffectif";
            this.lblEffectif.Size = new System.Drawing.Size(46, 13);
            this.lblEffectif.TabIndex = 16;
            this.lblEffectif.Text = "Effectif :";
            // 
            // lblCA
            // 
            this.lblCA.AutoSize = true;
            this.lblCA.Location = new System.Drawing.Point(192, 44);
            this.lblCA.Name = "lblCA";
            this.lblCA.Size = new System.Drawing.Size(27, 13);
            this.lblCA.TabIndex = 17;
            this.lblCA.Text = "CA :";
            // 
            // lblNature
            // 
            this.lblNature.AutoSize = true;
            this.lblNature.Location = new System.Drawing.Point(181, 87);
            this.lblNature.Name = "lblNature";
            this.lblNature.Size = new System.Drawing.Size(45, 13);
            this.lblNature.TabIndex = 18;
            this.lblNature.Text = "Nature :";
            // 
            // lblActivite
            // 
            this.lblActivite.AutoSize = true;
            this.lblActivite.Location = new System.Drawing.Point(4, 87);
            this.lblActivite.Name = "lblActivite";
            this.lblActivite.Size = new System.Drawing.Size(48, 13);
            this.lblActivite.TabIndex = 19;
            this.lblActivite.Text = "Activité :";
            // 
            // txtbEffectif
            // 
            this.txtbEffectif.Location = new System.Drawing.Point(58, 41);
            this.txtbEffectif.Name = "txtbEffectif";
            this.txtbEffectif.Size = new System.Drawing.Size(87, 20);
            this.txtbEffectif.TabIndex = 14;
            // 
            // txtbCA
            // 
            this.txtbCA.Location = new System.Drawing.Point(225, 41);
            this.txtbCA.Name = "txtbCA";
            this.txtbCA.Size = new System.Drawing.Size(87, 20);
            this.txtbCA.TabIndex = 20;
            // 
            // lstbActivite
            // 
            this.lstbActivite.FormattingEnabled = true;
            this.lstbActivite.Location = new System.Drawing.Point(56, 85);
            this.lstbActivite.Name = "lstbActivite";
            this.lstbActivite.Size = new System.Drawing.Size(118, 17);
            this.lstbActivite.TabIndex = 21;
            // 
            // lstbNature
            // 
            this.lstbNature.FormattingEnabled = true;
            this.lstbNature.Location = new System.Drawing.Point(232, 85);
            this.lstbNature.Name = "lstbNature";
            this.lstbNature.Size = new System.Drawing.Size(118, 17);
            this.lstbNature.TabIndex = 22;
            // 
            // grpbCaracteristiques
            // 
            this.grpbCaracteristiques.Controls.Add(this.lstbNature);
            this.grpbCaracteristiques.Controls.Add(this.lstbActivite);
            this.grpbCaracteristiques.Controls.Add(this.txtbCA);
            this.grpbCaracteristiques.Controls.Add(this.txtbEffectif);
            this.grpbCaracteristiques.Controls.Add(this.lblActivite);
            this.grpbCaracteristiques.Controls.Add(this.lblNature);
            this.grpbCaracteristiques.Controls.Add(this.lblCA);
            this.grpbCaracteristiques.Controls.Add(this.lblEffectif);
            this.grpbCaracteristiques.Controls.Add(this.chkbPrive);
            this.grpbCaracteristiques.Location = new System.Drawing.Point(12, 227);
            this.grpbCaracteristiques.Name = "grpbCaracteristiques";
            this.grpbCaracteristiques.Size = new System.Drawing.Size(423, 117);
            this.grpbCaracteristiques.TabIndex = 23;
            this.grpbCaracteristiques.TabStop = false;
            this.grpbCaracteristiques.Text = "Caracteristiques";
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(341, 368);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(93, 26);
            this.btnAnnuler.TabIndex = 24;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(145, 368);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(93, 26);
            this.btnOk.TabIndex = 25;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnContacts
            // 
            this.btnContacts.Location = new System.Drawing.Point(242, 368);
            this.btnContacts.Name = "btnContacts";
            this.btnContacts.Size = new System.Drawing.Size(93, 26);
            this.btnContacts.TabIndex = 26;
            this.btnContacts.Text = "Contacts";
            this.btnContacts.UseVisualStyleBackColor = true;
            // 
            // frmAjoutNouveauClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 434);
            this.Controls.Add(this.btnContacts);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.grpbCaracteristiques);
            this.Controls.Add(this.grpbIdentification);
            this.Name = "frmAjoutNouveauClient";
            this.Text = "Ajout nouveau client";
            this.grpbIdentification.ResumeLayout(false);
            this.grpbIdentification.PerformLayout();
            this.grpbCaracteristiques.ResumeLayout(false);
            this.grpbCaracteristiques.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNumeroClient;
        private System.Windows.Forms.TextBox txtbTelephone;
        private System.Windows.Forms.TextBox txtbVille;
        private System.Windows.Forms.TextBox txtbCP;
        private System.Windows.Forms.TextBox txtbAdresseSuite;
        private System.Windows.Forms.TextBox txtbAdresse;
        private System.Windows.Forms.TextBox txtbRaisonSociale;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.Label lblCP;
        private System.Windows.Forms.Label lblAdresse;
        private System.Windows.Forms.Label lblRaisonSociale;
        private System.Windows.Forms.Label lblEt;
        private System.Windows.Forms.Label lblVille;
        private System.Windows.Forms.GroupBox grpbIdentification;
        private System.Windows.Forms.CheckBox chkbPrive;
        private System.Windows.Forms.Label lblEffectif;
        private System.Windows.Forms.Label lblCA;
        private System.Windows.Forms.Label lblNature;
        private System.Windows.Forms.Label lblActivite;
        private System.Windows.Forms.TextBox txtbEffectif;
        private System.Windows.Forms.TextBox txtbCA;
        private System.Windows.Forms.ListBox lstbActivite;
        private System.Windows.Forms.ListBox lstbNature;
        private System.Windows.Forms.GroupBox grpbCaracteristiques;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnContacts;
        protected System.Windows.Forms.TextBox txtbNumeroClient;
    }
}