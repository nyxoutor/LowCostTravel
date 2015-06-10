namespace LowCostTravel
{
    partial class Fm_Clients
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
            this.components = new System.ComponentModel.Container();
            this.Lb_Choix = new System.Windows.Forms.Label();
            this.Bt_Aeroports = new System.Windows.Forms.Button();
            this.Bt_Reservations = new System.Windows.Forms.Button();
            this.Bt_Vols = new System.Windows.Forms.Button();
            this.Lb_Clients = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idclientsDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomclientsDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomclientsDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresseclientsDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpclientsDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.villeclientsDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telclientsDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailclientsDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Bt_Debut = new System.Windows.Forms.Button();
            this.Bt_Precedent = new System.Windows.Forms.Button();
            this.Bt_Suivant = new System.Windows.Forms.Button();
            this.Bt_Fin = new System.Windows.Forms.Button();
            this.Bt_Supprimer = new System.Windows.Forms.Button();
            this.Bt_Ajouter = new System.Windows.Forms.Button();
            this.Bt_Modifier = new System.Windows.Forms.Button();
            this.idclientsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomclientsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomclientsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresseclientsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpclientsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.villeclientsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telclientsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailclientsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordclientsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tokenclientsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.volsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Lb_Choix
            // 
            this.Lb_Choix.AutoSize = true;
            this.Lb_Choix.Location = new System.Drawing.Point(38, 33);
            this.Lb_Choix.Name = "Lb_Choix";
            this.Lb_Choix.Size = new System.Drawing.Size(94, 13);
            this.Lb_Choix.TabIndex = 0;
            this.Lb_Choix.Text = "Changer de table :";
            // 
            // Bt_Aeroports
            // 
            this.Bt_Aeroports.Location = new System.Drawing.Point(157, 28);
            this.Bt_Aeroports.Name = "Bt_Aeroports";
            this.Bt_Aeroports.Size = new System.Drawing.Size(75, 23);
            this.Bt_Aeroports.TabIndex = 1;
            this.Bt_Aeroports.Text = "Aéroports";
            this.Bt_Aeroports.UseVisualStyleBackColor = true;
            this.Bt_Aeroports.Click += new System.EventHandler(this.Bt_Aeroports_Click);
            // 
            // Bt_Reservations
            // 
            this.Bt_Reservations.Location = new System.Drawing.Point(295, 28);
            this.Bt_Reservations.Name = "Bt_Reservations";
            this.Bt_Reservations.Size = new System.Drawing.Size(80, 23);
            this.Bt_Reservations.TabIndex = 3;
            this.Bt_Reservations.Text = "Réservations";
            this.Bt_Reservations.UseVisualStyleBackColor = true;
            this.Bt_Reservations.Click += new System.EventHandler(this.Bt_Reservations_Click);
            // 
            // Bt_Vols
            // 
            this.Bt_Vols.Location = new System.Drawing.Point(419, 28);
            this.Bt_Vols.Name = "Bt_Vols";
            this.Bt_Vols.Size = new System.Drawing.Size(75, 23);
            this.Bt_Vols.TabIndex = 4;
            this.Bt_Vols.Text = "Vols";
            this.Bt_Vols.UseVisualStyleBackColor = true;
            this.Bt_Vols.Click += new System.EventHandler(this.Bt_Vols_Click);
            // 
            // Lb_Clients
            // 
            this.Lb_Clients.AutoSize = true;
            this.Lb_Clients.Location = new System.Drawing.Point(260, 85);
            this.Lb_Clients.Name = "Lb_Clients";
            this.Lb_Clients.Size = new System.Drawing.Size(88, 13);
            this.Lb_Clients.TabIndex = 5;
            this.Lb_Clients.Text = "Liste des clients :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idclientsDataGridViewTextBoxColumn1,
            this.nomclientsDataGridViewTextBoxColumn1,
            this.prenomclientsDataGridViewTextBoxColumn1,
            this.adresseclientsDataGridViewTextBoxColumn1,
            this.cpclientsDataGridViewTextBoxColumn1,
            this.villeclientsDataGridViewTextBoxColumn1,
            this.telclientsDataGridViewTextBoxColumn1,
            this.mailclientsDataGridViewTextBoxColumn1});
            this.dataGridView1.DataSource = this.clientsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(57, 101);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(539, 217);
            this.dataGridView1.TabIndex = 6;
            // 
            // idclientsDataGridViewTextBoxColumn1
            // 
            this.idclientsDataGridViewTextBoxColumn1.DataPropertyName = "id_clients";
            this.idclientsDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.idclientsDataGridViewTextBoxColumn1.Name = "idclientsDataGridViewTextBoxColumn1";
            this.idclientsDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nomclientsDataGridViewTextBoxColumn1
            // 
            this.nomclientsDataGridViewTextBoxColumn1.DataPropertyName = "nom_clients";
            this.nomclientsDataGridViewTextBoxColumn1.HeaderText = "Nom";
            this.nomclientsDataGridViewTextBoxColumn1.Name = "nomclientsDataGridViewTextBoxColumn1";
            this.nomclientsDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // prenomclientsDataGridViewTextBoxColumn1
            // 
            this.prenomclientsDataGridViewTextBoxColumn1.DataPropertyName = "prenom_clients";
            this.prenomclientsDataGridViewTextBoxColumn1.HeaderText = "Prénom";
            this.prenomclientsDataGridViewTextBoxColumn1.Name = "prenomclientsDataGridViewTextBoxColumn1";
            this.prenomclientsDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // adresseclientsDataGridViewTextBoxColumn1
            // 
            this.adresseclientsDataGridViewTextBoxColumn1.DataPropertyName = "adresse_clients";
            this.adresseclientsDataGridViewTextBoxColumn1.HeaderText = "Adresse";
            this.adresseclientsDataGridViewTextBoxColumn1.Name = "adresseclientsDataGridViewTextBoxColumn1";
            this.adresseclientsDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // cpclientsDataGridViewTextBoxColumn1
            // 
            this.cpclientsDataGridViewTextBoxColumn1.DataPropertyName = "cp_clients";
            this.cpclientsDataGridViewTextBoxColumn1.HeaderText = "Code Postal";
            this.cpclientsDataGridViewTextBoxColumn1.Name = "cpclientsDataGridViewTextBoxColumn1";
            this.cpclientsDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // villeclientsDataGridViewTextBoxColumn1
            // 
            this.villeclientsDataGridViewTextBoxColumn1.DataPropertyName = "ville_clients";
            this.villeclientsDataGridViewTextBoxColumn1.HeaderText = "Ville";
            this.villeclientsDataGridViewTextBoxColumn1.Name = "villeclientsDataGridViewTextBoxColumn1";
            this.villeclientsDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // telclientsDataGridViewTextBoxColumn1
            // 
            this.telclientsDataGridViewTextBoxColumn1.DataPropertyName = "tel_clients";
            this.telclientsDataGridViewTextBoxColumn1.HeaderText = "Téléphone";
            this.telclientsDataGridViewTextBoxColumn1.Name = "telclientsDataGridViewTextBoxColumn1";
            this.telclientsDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // mailclientsDataGridViewTextBoxColumn1
            // 
            this.mailclientsDataGridViewTextBoxColumn1.DataPropertyName = "mail_clients";
            this.mailclientsDataGridViewTextBoxColumn1.HeaderText = "Mail";
            this.mailclientsDataGridViewTextBoxColumn1.Name = "mailclientsDataGridViewTextBoxColumn1";
            this.mailclientsDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataSource = typeof(LowCostTravel.clients);
            // 
            // Bt_Debut
            // 
            this.Bt_Debut.Location = new System.Drawing.Point(25, 337);
            this.Bt_Debut.Name = "Bt_Debut";
            this.Bt_Debut.Size = new System.Drawing.Size(75, 23);
            this.Bt_Debut.TabIndex = 7;
            this.Bt_Debut.Text = "<<";
            this.Bt_Debut.UseVisualStyleBackColor = true;
            this.Bt_Debut.Click += new System.EventHandler(this.Bt_Debut_Click);
            // 
            // Bt_Precedent
            // 
            this.Bt_Precedent.Location = new System.Drawing.Point(115, 337);
            this.Bt_Precedent.Name = "Bt_Precedent";
            this.Bt_Precedent.Size = new System.Drawing.Size(75, 23);
            this.Bt_Precedent.TabIndex = 8;
            this.Bt_Precedent.Text = "<";
            this.Bt_Precedent.UseVisualStyleBackColor = true;
            this.Bt_Precedent.Click += new System.EventHandler(this.Bt_Precedent_Click);
            // 
            // Bt_Suivant
            // 
            this.Bt_Suivant.Location = new System.Drawing.Point(196, 337);
            this.Bt_Suivant.Name = "Bt_Suivant";
            this.Bt_Suivant.Size = new System.Drawing.Size(75, 23);
            this.Bt_Suivant.TabIndex = 9;
            this.Bt_Suivant.Text = ">";
            this.Bt_Suivant.UseVisualStyleBackColor = true;
            this.Bt_Suivant.Click += new System.EventHandler(this.Bt_Suivant_Click);
            // 
            // Bt_Fin
            // 
            this.Bt_Fin.Location = new System.Drawing.Point(278, 337);
            this.Bt_Fin.Name = "Bt_Fin";
            this.Bt_Fin.Size = new System.Drawing.Size(75, 23);
            this.Bt_Fin.TabIndex = 10;
            this.Bt_Fin.Text = ">>";
            this.Bt_Fin.UseVisualStyleBackColor = true;
            this.Bt_Fin.Click += new System.EventHandler(this.Bt_Fin_Click);
            // 
            // Bt_Supprimer
            // 
            this.Bt_Supprimer.Location = new System.Drawing.Point(363, 336);
            this.Bt_Supprimer.Name = "Bt_Supprimer";
            this.Bt_Supprimer.Size = new System.Drawing.Size(75, 23);
            this.Bt_Supprimer.TabIndex = 11;
            this.Bt_Supprimer.Text = "-";
            this.Bt_Supprimer.UseVisualStyleBackColor = true;
            this.Bt_Supprimer.Click += new System.EventHandler(this.Bt_Supprimer_Click);
            // 
            // Bt_Ajouter
            // 
            this.Bt_Ajouter.Location = new System.Drawing.Point(445, 335);
            this.Bt_Ajouter.Name = "Bt_Ajouter";
            this.Bt_Ajouter.Size = new System.Drawing.Size(75, 23);
            this.Bt_Ajouter.TabIndex = 12;
            this.Bt_Ajouter.Text = "+";
            this.Bt_Ajouter.UseVisualStyleBackColor = true;
            this.Bt_Ajouter.Click += new System.EventHandler(this.Bt_Ajouter_Click);
            // 
            // Bt_Modifier
            // 
            this.Bt_Modifier.Location = new System.Drawing.Point(543, 337);
            this.Bt_Modifier.Name = "Bt_Modifier";
            this.Bt_Modifier.Size = new System.Drawing.Size(75, 23);
            this.Bt_Modifier.TabIndex = 13;
            this.Bt_Modifier.Text = "Modifier";
            this.Bt_Modifier.UseVisualStyleBackColor = true;
            this.Bt_Modifier.Click += new System.EventHandler(this.Bt_Modifier_Click);
            // 
            // idclientsDataGridViewTextBoxColumn
            // 
            this.idclientsDataGridViewTextBoxColumn.DataPropertyName = "id_clients";
            this.idclientsDataGridViewTextBoxColumn.HeaderText = "id_clients";
            this.idclientsDataGridViewTextBoxColumn.Name = "idclientsDataGridViewTextBoxColumn";
            this.idclientsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomclientsDataGridViewTextBoxColumn
            // 
            this.nomclientsDataGridViewTextBoxColumn.DataPropertyName = "nom_clients";
            this.nomclientsDataGridViewTextBoxColumn.HeaderText = "nom_clients";
            this.nomclientsDataGridViewTextBoxColumn.Name = "nomclientsDataGridViewTextBoxColumn";
            this.nomclientsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prenomclientsDataGridViewTextBoxColumn
            // 
            this.prenomclientsDataGridViewTextBoxColumn.DataPropertyName = "prenom_clients";
            this.prenomclientsDataGridViewTextBoxColumn.HeaderText = "prenom_clients";
            this.prenomclientsDataGridViewTextBoxColumn.Name = "prenomclientsDataGridViewTextBoxColumn";
            this.prenomclientsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adresseclientsDataGridViewTextBoxColumn
            // 
            this.adresseclientsDataGridViewTextBoxColumn.DataPropertyName = "adresse_clients";
            this.adresseclientsDataGridViewTextBoxColumn.HeaderText = "adresse_clients";
            this.adresseclientsDataGridViewTextBoxColumn.Name = "adresseclientsDataGridViewTextBoxColumn";
            this.adresseclientsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cpclientsDataGridViewTextBoxColumn
            // 
            this.cpclientsDataGridViewTextBoxColumn.DataPropertyName = "cp_clients";
            this.cpclientsDataGridViewTextBoxColumn.HeaderText = "cp_clients";
            this.cpclientsDataGridViewTextBoxColumn.Name = "cpclientsDataGridViewTextBoxColumn";
            this.cpclientsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // villeclientsDataGridViewTextBoxColumn
            // 
            this.villeclientsDataGridViewTextBoxColumn.DataPropertyName = "ville_clients";
            this.villeclientsDataGridViewTextBoxColumn.HeaderText = "ville_clients";
            this.villeclientsDataGridViewTextBoxColumn.Name = "villeclientsDataGridViewTextBoxColumn";
            this.villeclientsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telclientsDataGridViewTextBoxColumn
            // 
            this.telclientsDataGridViewTextBoxColumn.DataPropertyName = "tel_clients";
            this.telclientsDataGridViewTextBoxColumn.HeaderText = "tel_clients";
            this.telclientsDataGridViewTextBoxColumn.Name = "telclientsDataGridViewTextBoxColumn";
            this.telclientsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mailclientsDataGridViewTextBoxColumn
            // 
            this.mailclientsDataGridViewTextBoxColumn.DataPropertyName = "mail_clients";
            this.mailclientsDataGridViewTextBoxColumn.HeaderText = "mail_clients";
            this.mailclientsDataGridViewTextBoxColumn.Name = "mailclientsDataGridViewTextBoxColumn";
            this.mailclientsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passwordclientsDataGridViewTextBoxColumn
            // 
            this.passwordclientsDataGridViewTextBoxColumn.DataPropertyName = "password_clients";
            this.passwordclientsDataGridViewTextBoxColumn.HeaderText = "password_clients";
            this.passwordclientsDataGridViewTextBoxColumn.Name = "passwordclientsDataGridViewTextBoxColumn";
            this.passwordclientsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tokenclientsDataGridViewTextBoxColumn
            // 
            this.tokenclientsDataGridViewTextBoxColumn.DataPropertyName = "token_clients";
            this.tokenclientsDataGridViewTextBoxColumn.HeaderText = "token_clients";
            this.tokenclientsDataGridViewTextBoxColumn.Name = "tokenclientsDataGridViewTextBoxColumn";
            this.tokenclientsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // volsDataGridViewTextBoxColumn
            // 
            this.volsDataGridViewTextBoxColumn.DataPropertyName = "vols";
            this.volsDataGridViewTextBoxColumn.HeaderText = "vols";
            this.volsDataGridViewTextBoxColumn.Name = "volsDataGridViewTextBoxColumn";
            this.volsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Fm_Clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 372);
            this.Controls.Add(this.Bt_Modifier);
            this.Controls.Add(this.Bt_Ajouter);
            this.Controls.Add(this.Bt_Supprimer);
            this.Controls.Add(this.Bt_Fin);
            this.Controls.Add(this.Bt_Suivant);
            this.Controls.Add(this.Bt_Precedent);
            this.Controls.Add(this.Bt_Debut);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Lb_Clients);
            this.Controls.Add(this.Bt_Vols);
            this.Controls.Add(this.Bt_Reservations);
            this.Controls.Add(this.Bt_Aeroports);
            this.Controls.Add(this.Lb_Choix);
            this.Name = "Fm_Clients";
            this.Text = "Liste des clients";
            this.Load += new System.EventHandler(this.Fm_Clients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lb_Choix;
        private System.Windows.Forms.Button Bt_Aeroports;
        private System.Windows.Forms.Button Bt_Reservations;
        private System.Windows.Forms.Button Bt_Vols;
        private System.Windows.Forms.Label Lb_Clients;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Bt_Debut;
        private System.Windows.Forms.Button Bt_Precedent;
        private System.Windows.Forms.Button Bt_Suivant;
        private System.Windows.Forms.Button Bt_Fin;
        private System.Windows.Forms.Button Bt_Supprimer;
        private System.Windows.Forms.Button Bt_Ajouter;
        private System.Windows.Forms.Button Bt_Modifier;
        private System.Windows.Forms.DataGridViewTextBoxColumn idclientsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomclientsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomclientsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseclientsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpclientsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn villeclientsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telclientsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailclientsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordclientsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tokenclientsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn volsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn volsDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idclientsDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomclientsDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomclientsDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseclientsDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpclientsDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn villeclientsDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn telclientsDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailclientsDataGridViewTextBoxColumn1;
    }
}