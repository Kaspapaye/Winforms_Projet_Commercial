namespace Winforms_Projet_Commercial
{
    partial class frmConsultation_Client
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
            this.lblTelephoneData = new System.Windows.Forms.Label();
            this.lblCpVilleData = new System.Windows.Forms.Label();
            this.lblAdresseData = new System.Windows.Forms.Label();
            this.lblRaisonSocialeData = new System.Windows.Forms.Label();
            this.lblNumClientData = new System.Windows.Forms.Label();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.lblCpVille = new System.Windows.Forms.Label();
            this.lblAdresse = new System.Windows.Forms.Label();
            this.lblRaisonSociale = new System.Windows.Forms.Label();
            this.lblNumClient = new System.Windows.Forms.Label();
            this.gbxCaracteristiques = new System.Windows.Forms.GroupBox();
            this.lblNatureData = new System.Windows.Forms.Label();
            this.lblCAData = new System.Windows.Forms.Label();
            this.lblNature = new System.Windows.Forms.Label();
            this.lblCA = new System.Windows.Forms.Label();
            this.lblActiviteData = new System.Windows.Forms.Label();
            this.lblEffectifData = new System.Windows.Forms.Label();
            this.lblActivite = new System.Windows.Forms.Label();
            this.lblEffectif = new System.Windows.Forms.Label();
            this.chkbPrive = new System.Windows.Forms.CheckBox();
            this.lblContacts = new System.Windows.Forms.Label();
            this.btnModifierClient = new System.Windows.Forms.Button();
            this.btnNouveauContact = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prénom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Fonction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxIdentification.SuspendLayout();
            this.gbxCaracteristiques.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxIdentification
            // 
            this.gbxIdentification.Controls.Add(this.lblTelephoneData);
            this.gbxIdentification.Controls.Add(this.lblCpVilleData);
            this.gbxIdentification.Controls.Add(this.lblAdresseData);
            this.gbxIdentification.Controls.Add(this.lblRaisonSocialeData);
            this.gbxIdentification.Controls.Add(this.lblNumClientData);
            this.gbxIdentification.Controls.Add(this.lblTelephone);
            this.gbxIdentification.Controls.Add(this.lblCpVille);
            this.gbxIdentification.Controls.Add(this.lblAdresse);
            this.gbxIdentification.Controls.Add(this.lblRaisonSociale);
            this.gbxIdentification.Controls.Add(this.lblNumClient);
            this.gbxIdentification.Location = new System.Drawing.Point(13, 13);
            this.gbxIdentification.Name = "gbxIdentification";
            this.gbxIdentification.Size = new System.Drawing.Size(386, 212);
            this.gbxIdentification.TabIndex = 0;
            this.gbxIdentification.TabStop = false;
            this.gbxIdentification.Text = "Identification";
            // 
            // lblTelephoneData
            // 
            this.lblTelephoneData.AutoSize = true;
            this.lblTelephoneData.Location = new System.Drawing.Point(92, 157);
            this.lblTelephoneData.Name = "lblTelephoneData";
            this.lblTelephoneData.Size = new System.Drawing.Size(47, 13);
            this.lblTelephoneData.TabIndex = 9;
            this.lblTelephoneData.Text = "Exemple";
            // 
            // lblCpVilleData
            // 
            this.lblCpVilleData.AutoSize = true;
            this.lblCpVilleData.Location = new System.Drawing.Point(92, 123);
            this.lblCpVilleData.Name = "lblCpVilleData";
            this.lblCpVilleData.Size = new System.Drawing.Size(47, 13);
            this.lblCpVilleData.TabIndex = 8;
            this.lblCpVilleData.Text = "Exemple";
            this.lblCpVilleData.Click += new System.EventHandler(this.lblCpVilleData_Click);
            // 
            // lblAdresseData
            // 
            this.lblAdresseData.AutoSize = true;
            this.lblAdresseData.Location = new System.Drawing.Point(92, 76);
            this.lblAdresseData.Name = "lblAdresseData";
            this.lblAdresseData.Size = new System.Drawing.Size(47, 13);
            this.lblAdresseData.TabIndex = 7;
            this.lblAdresseData.Text = "Exemple";
            // 
            // lblRaisonSocialeData
            // 
            this.lblRaisonSocialeData.AutoSize = true;
            this.lblRaisonSocialeData.Location = new System.Drawing.Point(92, 47);
            this.lblRaisonSocialeData.Name = "lblRaisonSocialeData";
            this.lblRaisonSocialeData.Size = new System.Drawing.Size(47, 13);
            this.lblRaisonSocialeData.TabIndex = 6;
            this.lblRaisonSocialeData.Text = "Exemple";
            // 
            // lblNumClientData
            // 
            this.lblNumClientData.AutoSize = true;
            this.lblNumClientData.Location = new System.Drawing.Point(92, 20);
            this.lblNumClientData.Name = "lblNumClientData";
            this.lblNumClientData.Size = new System.Drawing.Size(47, 13);
            this.lblNumClientData.TabIndex = 5;
            this.lblNumClientData.Text = "Exemple";
            this.lblNumClientData.Click += new System.EventHandler(this.label7_Click);
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Location = new System.Drawing.Point(27, 157);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(64, 13);
            this.lblTelephone.TabIndex = 4;
            this.lblTelephone.Text = "Téléphone :";
            // 
            // lblCpVille
            // 
            this.lblCpVille.AutoSize = true;
            this.lblCpVille.Location = new System.Drawing.Point(30, 123);
            this.lblCpVille.Name = "lblCpVille";
            this.lblCpVille.Size = new System.Drawing.Size(61, 13);
            this.lblCpVille.TabIndex = 3;
            this.lblCpVille.Text = "CP et Ville :";
            // 
            // lblAdresse
            // 
            this.lblAdresse.AutoSize = true;
            this.lblAdresse.Location = new System.Drawing.Point(40, 76);
            this.lblAdresse.Name = "lblAdresse";
            this.lblAdresse.Size = new System.Drawing.Size(51, 13);
            this.lblAdresse.TabIndex = 2;
            this.lblAdresse.Text = "Adresse :";
            // 
            // lblRaisonSociale
            // 
            this.lblRaisonSociale.AutoSize = true;
            this.lblRaisonSociale.Location = new System.Drawing.Point(7, 47);
            this.lblRaisonSociale.Name = "lblRaisonSociale";
            this.lblRaisonSociale.Size = new System.Drawing.Size(84, 13);
            this.lblRaisonSociale.TabIndex = 1;
            this.lblRaisonSociale.Text = "Raison Sociale :";
            // 
            // lblNumClient
            // 
            this.lblNumClient.AutoSize = true;
            this.lblNumClient.Location = new System.Drawing.Point(12, 20);
            this.lblNumClient.Name = "lblNumClient";
            this.lblNumClient.Size = new System.Drawing.Size(79, 13);
            this.lblNumClient.TabIndex = 0;
            this.lblNumClient.Text = "Numéro Client :";
            // 
            // gbxCaracteristiques
            // 
            this.gbxCaracteristiques.Controls.Add(this.lblNatureData);
            this.gbxCaracteristiques.Controls.Add(this.lblCAData);
            this.gbxCaracteristiques.Controls.Add(this.lblNature);
            this.gbxCaracteristiques.Controls.Add(this.lblCA);
            this.gbxCaracteristiques.Controls.Add(this.lblActiviteData);
            this.gbxCaracteristiques.Controls.Add(this.lblEffectifData);
            this.gbxCaracteristiques.Controls.Add(this.lblActivite);
            this.gbxCaracteristiques.Controls.Add(this.lblEffectif);
            this.gbxCaracteristiques.Controls.Add(this.chkbPrive);
            this.gbxCaracteristiques.Location = new System.Drawing.Point(12, 231);
            this.gbxCaracteristiques.Name = "gbxCaracteristiques";
            this.gbxCaracteristiques.Size = new System.Drawing.Size(387, 100);
            this.gbxCaracteristiques.TabIndex = 1;
            this.gbxCaracteristiques.TabStop = false;
            this.gbxCaracteristiques.Text = "Caractéristiques";
            // 
            // lblNatureData
            // 
            this.lblNatureData.AutoSize = true;
            this.lblNatureData.Location = new System.Drawing.Point(212, 69);
            this.lblNatureData.Name = "lblNatureData";
            this.lblNatureData.Size = new System.Drawing.Size(47, 13);
            this.lblNatureData.TabIndex = 8;
            this.lblNatureData.Text = "Exemple";
            // 
            // lblCAData
            // 
            this.lblCAData.AutoSize = true;
            this.lblCAData.Location = new System.Drawing.Point(192, 39);
            this.lblCAData.Name = "lblCAData";
            this.lblCAData.Size = new System.Drawing.Size(47, 13);
            this.lblCAData.TabIndex = 7;
            this.lblCAData.Text = "Exemple";
            // 
            // lblNature
            // 
            this.lblNature.AutoSize = true;
            this.lblNature.Location = new System.Drawing.Point(161, 69);
            this.lblNature.Name = "lblNature";
            this.lblNature.Size = new System.Drawing.Size(45, 13);
            this.lblNature.TabIndex = 6;
            this.lblNature.Text = "Nature :";
            // 
            // lblCA
            // 
            this.lblCA.AutoSize = true;
            this.lblCA.Location = new System.Drawing.Point(161, 39);
            this.lblCA.Name = "lblCA";
            this.lblCA.Size = new System.Drawing.Size(27, 13);
            this.lblCA.TabIndex = 5;
            this.lblCA.Text = "CA :";
            // 
            // lblActiviteData
            // 
            this.lblActiviteData.AutoSize = true;
            this.lblActiviteData.Location = new System.Drawing.Point(58, 69);
            this.lblActiviteData.Name = "lblActiviteData";
            this.lblActiviteData.Size = new System.Drawing.Size(47, 13);
            this.lblActiviteData.TabIndex = 4;
            this.lblActiviteData.Text = "Exemple";
            // 
            // lblEffectifData
            // 
            this.lblEffectifData.AutoSize = true;
            this.lblEffectifData.Location = new System.Drawing.Point(58, 39);
            this.lblEffectifData.Name = "lblEffectifData";
            this.lblEffectifData.Size = new System.Drawing.Size(47, 13);
            this.lblEffectifData.TabIndex = 3;
            this.lblEffectifData.Text = "Exemple";
            // 
            // lblActivite
            // 
            this.lblActivite.AutoSize = true;
            this.lblActivite.Location = new System.Drawing.Point(8, 69);
            this.lblActivite.Name = "lblActivite";
            this.lblActivite.Size = new System.Drawing.Size(48, 13);
            this.lblActivite.TabIndex = 2;
            this.lblActivite.Text = "Activité :";
            // 
            // lblEffectif
            // 
            this.lblEffectif.AutoSize = true;
            this.lblEffectif.Location = new System.Drawing.Point(8, 39);
            this.lblEffectif.Name = "lblEffectif";
            this.lblEffectif.Size = new System.Drawing.Size(46, 13);
            this.lblEffectif.TabIndex = 1;
            this.lblEffectif.Text = "Effectif :";
            // 
            // chkbPrive
            // 
            this.chkbPrive.AutoSize = true;
            this.chkbPrive.Location = new System.Drawing.Point(11, 19);
            this.chkbPrive.Name = "chkbPrive";
            this.chkbPrive.Size = new System.Drawing.Size(50, 17);
            this.chkbPrive.TabIndex = 0;
            this.chkbPrive.Text = "Privé";
            this.chkbPrive.UseVisualStyleBackColor = true;
            // 
            // lblContacts
            // 
            this.lblContacts.AutoSize = true;
            this.lblContacts.Location = new System.Drawing.Point(20, 343);
            this.lblContacts.Name = "lblContacts";
            this.lblContacts.Size = new System.Drawing.Size(49, 13);
            this.lblContacts.TabIndex = 2;
            this.lblContacts.Text = "Contacts";
            // 
            // btnModifierClient
            // 
            this.btnModifierClient.Location = new System.Drawing.Point(131, 423);
            this.btnModifierClient.Name = "btnModifierClient";
            this.btnModifierClient.Size = new System.Drawing.Size(82, 23);
            this.btnModifierClient.TabIndex = 3;
            this.btnModifierClient.Text = "Modifier Client";
            this.btnModifierClient.UseVisualStyleBackColor = true;
            // 
            // btnNouveauContact
            // 
            this.btnNouveauContact.Location = new System.Drawing.Point(219, 423);
            this.btnNouveauContact.Name = "btnNouveauContact";
            this.btnNouveauContact.Size = new System.Drawing.Size(99, 23);
            this.btnNouveauContact.TabIndex = 4;
            this.btnNouveauContact.Text = "Nouveau Contact";
            this.btnNouveauContact.UseVisualStyleBackColor = true;
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(324, 423);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(75, 23);
            this.btnFermer.TabIndex = 5;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nom,
            this.Prénom,
            this.Telephone,
            this.Email,
            this.Fonction});
            this.dataGridView1.Location = new System.Drawing.Point(21, 360);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(376, 57);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Nom
            // 
            this.Nom.HeaderText = "Nom";
            this.Nom.Name = "Nom";
            this.Nom.Width = 50;
            // 
            // Prénom
            // 
            this.Prénom.HeaderText = "Prénom";
            this.Prénom.Name = "Prénom";
            this.Prénom.Width = 50;
            // 
            // Telephone
            // 
            this.Telephone.HeaderText = "Téléphone";
            this.Telephone.Name = "Telephone";
            this.Telephone.Width = 60;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // Fonction
            // 
            this.Fonction.HeaderText = "Fonction";
            this.Fonction.Name = "Fonction";
            this.Fonction.Width = 50;
            // 
            // frmConsultation_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 476);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.btnNouveauContact);
            this.Controls.Add(this.btnModifierClient);
            this.Controls.Add(this.lblContacts);
            this.Controls.Add(this.gbxCaracteristiques);
            this.Controls.Add(this.gbxIdentification);
            this.Name = "frmConsultation_Client";
            this.Text = "Consultation Client";
            this.gbxIdentification.ResumeLayout(false);
            this.gbxIdentification.PerformLayout();
            this.gbxCaracteristiques.ResumeLayout(false);
            this.gbxCaracteristiques.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxIdentification;
        private System.Windows.Forms.Label lblTelephoneData;
        private System.Windows.Forms.Label lblCpVilleData;
        private System.Windows.Forms.Label lblAdresseData;
        private System.Windows.Forms.Label lblRaisonSocialeData;
        private System.Windows.Forms.Label lblNumClientData;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.Label lblCpVille;
        private System.Windows.Forms.Label lblAdresse;
        private System.Windows.Forms.Label lblRaisonSociale;
        private System.Windows.Forms.Label lblNumClient;
        private System.Windows.Forms.GroupBox gbxCaracteristiques;
        private System.Windows.Forms.Label lblNatureData;
        private System.Windows.Forms.Label lblCAData;
        private System.Windows.Forms.Label lblNature;
        private System.Windows.Forms.Label lblCA;
        private System.Windows.Forms.Label lblActiviteData;
        private System.Windows.Forms.Label lblEffectifData;
        private System.Windows.Forms.Label lblActivite;
        private System.Windows.Forms.Label lblEffectif;
        private System.Windows.Forms.CheckBox chkbPrive;
        private System.Windows.Forms.Label lblContacts;
        private System.Windows.Forms.Button btnModifierClient;
        private System.Windows.Forms.Button btnNouveauContact;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prénom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telephone;
        private System.Windows.Forms.DataGridViewLinkColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fonction;
    }
}