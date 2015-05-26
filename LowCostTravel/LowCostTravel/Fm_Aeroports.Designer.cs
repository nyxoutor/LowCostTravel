namespace LowCostTravel
{
    partial class Fm_Aeroports
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
            this.Lb_Aeroports = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Bs = new System.Windows.Forms.BindingSource(this.components);
            this.Lb_Choix = new System.Windows.Forms.Label();
            this.Btn_Clients = new System.Windows.Forms.Button();
            this.Btn_Destinations = new System.Windows.Forms.Button();
            this.Btn_Reservations = new System.Windows.Forms.Button();
            this.Btn_Vols = new System.Windows.Forms.Button();
            this.Btn_Debut = new System.Windows.Forms.Button();
            this.Btn_Precedent = new System.Windows.Forms.Button();
            this.Btn_Suivant = new System.Windows.Forms.Button();
            this.Btn_Fin = new System.Windows.Forms.Button();
            this.Btn_Supprimer = new System.Windows.Forms.Button();
            this.Btn_Ajouter = new System.Windows.Forms.Button();
            this.Btn_Modifier = new System.Windows.Forms.Button();
            this.idaeroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.villeaeroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idaeroDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.villeaeroDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bs)).BeginInit();
            this.SuspendLayout();
            // 
            // Lb_Aeroports
            // 
            this.Lb_Aeroports.AutoSize = true;
            this.Lb_Aeroports.Location = new System.Drawing.Point(254, 71);
            this.Lb_Aeroports.Name = "Lb_Aeroports";
            this.Lb_Aeroports.Size = new System.Drawing.Size(102, 13);
            this.Lb_Aeroports.TabIndex = 0;
            this.Lb_Aeroports.Text = "Liste des aéroports :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idaeroDataGridViewTextBoxColumn1,
            this.villeaeroDataGridViewTextBoxColumn1});
            this.dataGridView1.DataSource = this.Bs;
            this.dataGridView1.Location = new System.Drawing.Point(194, 103);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(256, 216);
            this.dataGridView1.TabIndex = 1;
            // 
            // Bs
            // 
            this.Bs.DataSource = typeof(LowCostTravel.aeroports);
            // 
            // Lb_Choix
            // 
            this.Lb_Choix.AutoSize = true;
            this.Lb_Choix.Location = new System.Drawing.Point(22, 28);
            this.Lb_Choix.Name = "Lb_Choix";
            this.Lb_Choix.Size = new System.Drawing.Size(94, 13);
            this.Lb_Choix.TabIndex = 2;
            this.Lb_Choix.Text = "Changer de table :";
            // 
            // Btn_Clients
            // 
            this.Btn_Clients.Location = new System.Drawing.Point(137, 23);
            this.Btn_Clients.Name = "Btn_Clients";
            this.Btn_Clients.Size = new System.Drawing.Size(89, 23);
            this.Btn_Clients.TabIndex = 3;
            this.Btn_Clients.Text = "Clients";
            this.Btn_Clients.UseVisualStyleBackColor = true;
            this.Btn_Clients.Click += new System.EventHandler(this.Btn_Clients_Click);
            // 
            // Btn_Destinations
            // 
            this.Btn_Destinations.Location = new System.Drawing.Point(245, 23);
            this.Btn_Destinations.Name = "Btn_Destinations";
            this.Btn_Destinations.Size = new System.Drawing.Size(89, 23);
            this.Btn_Destinations.TabIndex = 4;
            this.Btn_Destinations.Text = "Destinations";
            this.Btn_Destinations.UseVisualStyleBackColor = true;
            // 
            // Btn_Reservations
            // 
            this.Btn_Reservations.Location = new System.Drawing.Point(351, 23);
            this.Btn_Reservations.Name = "Btn_Reservations";
            this.Btn_Reservations.Size = new System.Drawing.Size(87, 23);
            this.Btn_Reservations.TabIndex = 5;
            this.Btn_Reservations.Text = "Réservations";
            this.Btn_Reservations.UseVisualStyleBackColor = true;
            // 
            // Btn_Vols
            // 
            this.Btn_Vols.Location = new System.Drawing.Point(458, 23);
            this.Btn_Vols.Name = "Btn_Vols";
            this.Btn_Vols.Size = new System.Drawing.Size(83, 23);
            this.Btn_Vols.TabIndex = 6;
            this.Btn_Vols.Text = "Vols";
            this.Btn_Vols.UseVisualStyleBackColor = true;
            // 
            // Btn_Debut
            // 
            this.Btn_Debut.Location = new System.Drawing.Point(12, 336);
            this.Btn_Debut.Name = "Btn_Debut";
            this.Btn_Debut.Size = new System.Drawing.Size(75, 23);
            this.Btn_Debut.TabIndex = 7;
            this.Btn_Debut.Text = "<<";
            this.Btn_Debut.UseVisualStyleBackColor = true;
            this.Btn_Debut.Click += new System.EventHandler(this.Btn_Debut_Click);
            // 
            // Btn_Precedent
            // 
            this.Btn_Precedent.Location = new System.Drawing.Point(106, 336);
            this.Btn_Precedent.Name = "Btn_Precedent";
            this.Btn_Precedent.Size = new System.Drawing.Size(75, 23);
            this.Btn_Precedent.TabIndex = 8;
            this.Btn_Precedent.Text = "<";
            this.Btn_Precedent.UseVisualStyleBackColor = true;
            this.Btn_Precedent.Click += new System.EventHandler(this.Btn_Precedent_Click);
            // 
            // Btn_Suivant
            // 
            this.Btn_Suivant.Location = new System.Drawing.Point(201, 336);
            this.Btn_Suivant.Name = "Btn_Suivant";
            this.Btn_Suivant.Size = new System.Drawing.Size(75, 23);
            this.Btn_Suivant.TabIndex = 9;
            this.Btn_Suivant.Text = ">";
            this.Btn_Suivant.UseVisualStyleBackColor = true;
            this.Btn_Suivant.Click += new System.EventHandler(this.Btn_Suivant_Click);
            // 
            // Btn_Fin
            // 
            this.Btn_Fin.Location = new System.Drawing.Point(293, 336);
            this.Btn_Fin.Name = "Btn_Fin";
            this.Btn_Fin.Size = new System.Drawing.Size(75, 23);
            this.Btn_Fin.TabIndex = 10;
            this.Btn_Fin.Text = ">>";
            this.Btn_Fin.UseVisualStyleBackColor = true;
            this.Btn_Fin.Click += new System.EventHandler(this.Btn_Fin_Click);
            // 
            // Btn_Supprimer
            // 
            this.Btn_Supprimer.Location = new System.Drawing.Point(385, 336);
            this.Btn_Supprimer.Name = "Btn_Supprimer";
            this.Btn_Supprimer.Size = new System.Drawing.Size(75, 23);
            this.Btn_Supprimer.TabIndex = 11;
            this.Btn_Supprimer.Text = "-";
            this.Btn_Supprimer.UseVisualStyleBackColor = true;
            this.Btn_Supprimer.Click += new System.EventHandler(this.Btn_Supprimer_Click);
            // 
            // Btn_Ajouter
            // 
            this.Btn_Ajouter.Location = new System.Drawing.Point(475, 336);
            this.Btn_Ajouter.Name = "Btn_Ajouter";
            this.Btn_Ajouter.Size = new System.Drawing.Size(75, 23);
            this.Btn_Ajouter.TabIndex = 12;
            this.Btn_Ajouter.Text = "+";
            this.Btn_Ajouter.UseVisualStyleBackColor = true;
            this.Btn_Ajouter.Click += new System.EventHandler(this.Btn_Ajouter_Click);
            // 
            // Btn_Modifier
            // 
            this.Btn_Modifier.Location = new System.Drawing.Point(565, 336);
            this.Btn_Modifier.Name = "Btn_Modifier";
            this.Btn_Modifier.Size = new System.Drawing.Size(75, 23);
            this.Btn_Modifier.TabIndex = 13;
            this.Btn_Modifier.Text = "Modifier";
            this.Btn_Modifier.UseVisualStyleBackColor = true;
            this.Btn_Modifier.Click += new System.EventHandler(this.button7_Click);
            // 
            // idaeroDataGridViewTextBoxColumn
            // 
            this.idaeroDataGridViewTextBoxColumn.DataPropertyName = "id_aero";
            this.idaeroDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idaeroDataGridViewTextBoxColumn.Name = "idaeroDataGridViewTextBoxColumn";
            this.idaeroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // villeaeroDataGridViewTextBoxColumn
            // 
            this.villeaeroDataGridViewTextBoxColumn.DataPropertyName = "ville_aero";
            this.villeaeroDataGridViewTextBoxColumn.HeaderText = "Ville";
            this.villeaeroDataGridViewTextBoxColumn.Name = "villeaeroDataGridViewTextBoxColumn";
            this.villeaeroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idaeroDataGridViewTextBoxColumn1
            // 
            this.idaeroDataGridViewTextBoxColumn1.DataPropertyName = "id_aero";
            this.idaeroDataGridViewTextBoxColumn1.HeaderText = "id_aero";
            this.idaeroDataGridViewTextBoxColumn1.Name = "idaeroDataGridViewTextBoxColumn1";
            this.idaeroDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // villeaeroDataGridViewTextBoxColumn1
            // 
            this.villeaeroDataGridViewTextBoxColumn1.DataPropertyName = "ville_aero";
            this.villeaeroDataGridViewTextBoxColumn1.HeaderText = "ville_aero";
            this.villeaeroDataGridViewTextBoxColumn1.Name = "villeaeroDataGridViewTextBoxColumn1";
            this.villeaeroDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Fm_Aeroports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 371);
            this.Controls.Add(this.Btn_Modifier);
            this.Controls.Add(this.Btn_Ajouter);
            this.Controls.Add(this.Btn_Supprimer);
            this.Controls.Add(this.Btn_Fin);
            this.Controls.Add(this.Btn_Suivant);
            this.Controls.Add(this.Btn_Precedent);
            this.Controls.Add(this.Btn_Debut);
            this.Controls.Add(this.Btn_Vols);
            this.Controls.Add(this.Btn_Reservations);
            this.Controls.Add(this.Btn_Destinations);
            this.Controls.Add(this.Btn_Clients);
            this.Controls.Add(this.Lb_Choix);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Lb_Aeroports);
            this.Name = "Fm_Aeroports";
            this.Text = "Fm_Aeroports";
            this.Load += new System.EventHandler(this.Fm_Aeroports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lb_Aeroports;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Lb_Choix;
        private System.Windows.Forms.Button Btn_Clients;
        private System.Windows.Forms.Button Btn_Destinations;
        private System.Windows.Forms.Button Btn_Reservations;
        private System.Windows.Forms.Button Btn_Vols;
        private System.Windows.Forms.Button Btn_Debut;
        private System.Windows.Forms.Button Btn_Precedent;
        private System.Windows.Forms.Button Btn_Suivant;
        private System.Windows.Forms.Button Btn_Fin;
        private System.Windows.Forms.Button Btn_Supprimer;
        private System.Windows.Forms.Button Btn_Ajouter;
        private System.Windows.Forms.Button Btn_Modifier;
        private System.Windows.Forms.BindingSource Bs;
        private System.Windows.Forms.DataGridViewTextBoxColumn idaeroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn villeaeroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idaeroDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn villeaeroDataGridViewTextBoxColumn1;
    }
}