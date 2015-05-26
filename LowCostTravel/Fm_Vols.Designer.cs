namespace LowCostTravel
{
    partial class Fm_Vols
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
            this.Btn_Aeroports = new System.Windows.Forms.Button();
            this.Btn_Destinations = new System.Windows.Forms.Button();
            this.Btn_Reservations = new System.Windows.Forms.Button();
            this.Btn_Clients = new System.Windows.Forms.Button();
            this.Lb_Vols = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Btn_Debut = new System.Windows.Forms.Button();
            this.Btn_Precedent = new System.Windows.Forms.Button();
            this.Btn_Suivant = new System.Windows.Forms.Button();
            this.Btn_Fin = new System.Windows.Forms.Button();
            this.Btn_Supprimer = new System.Windows.Forms.Button();
            this.Btn_Ajouter = new System.Windows.Forms.Button();
            this.Btn_Modifier = new System.Windows.Forms.Button();
            this.volsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departvolsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arriveevolsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placesdispovolsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placesvolsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Lb_Choix
            // 
            this.Lb_Choix.AutoSize = true;
            this.Lb_Choix.Location = new System.Drawing.Point(37, 24);
            this.Lb_Choix.Name = "Lb_Choix";
            this.Lb_Choix.Size = new System.Drawing.Size(94, 13);
            this.Lb_Choix.TabIndex = 0;
            this.Lb_Choix.Text = "Changer de table :";
            // 
            // Btn_Aeroports
            // 
            this.Btn_Aeroports.Location = new System.Drawing.Point(166, 19);
            this.Btn_Aeroports.Name = "Btn_Aeroports";
            this.Btn_Aeroports.Size = new System.Drawing.Size(75, 23);
            this.Btn_Aeroports.TabIndex = 1;
            this.Btn_Aeroports.Text = "Aeroports";
            this.Btn_Aeroports.UseVisualStyleBackColor = true;
            // 
            // Btn_Destinations
            // 
            this.Btn_Destinations.Location = new System.Drawing.Point(472, 19);
            this.Btn_Destinations.Name = "Btn_Destinations";
            this.Btn_Destinations.Size = new System.Drawing.Size(75, 23);
            this.Btn_Destinations.TabIndex = 2;
            this.Btn_Destinations.Text = "Destinations";
            this.Btn_Destinations.UseVisualStyleBackColor = true;
            // 
            // Btn_Reservations
            // 
            this.Btn_Reservations.Location = new System.Drawing.Point(368, 19);
            this.Btn_Reservations.Name = "Btn_Reservations";
            this.Btn_Reservations.Size = new System.Drawing.Size(78, 23);
            this.Btn_Reservations.TabIndex = 3;
            this.Btn_Reservations.Text = "Réservations";
            this.Btn_Reservations.UseVisualStyleBackColor = true;
            // 
            // Btn_Clients
            // 
            this.Btn_Clients.Location = new System.Drawing.Point(266, 19);
            this.Btn_Clients.Name = "Btn_Clients";
            this.Btn_Clients.Size = new System.Drawing.Size(75, 23);
            this.Btn_Clients.TabIndex = 4;
            this.Btn_Clients.Text = "Clients";
            this.Btn_Clients.UseVisualStyleBackColor = true;
            // 
            // Lb_Vols
            // 
            this.Lb_Vols.AutoSize = true;
            this.Lb_Vols.Location = new System.Drawing.Point(292, 79);
            this.Lb_Vols.Name = "Lb_Vols";
            this.Lb_Vols.Size = new System.Drawing.Size(77, 13);
            this.Lb_Vols.TabIndex = 6;
            this.Lb_Vols.Text = "Liste des vols :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.departvolsDataGridViewTextBoxColumn,
            this.arriveevolsDataGridViewTextBoxColumn,
            this.placesdispovolsDataGridViewTextBoxColumn,
            this.placesvolsDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.dataGridView1.DataSource = this.volsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(166, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(341, 217);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Btn_Debut
            // 
            this.Btn_Debut.Location = new System.Drawing.Point(12, 336);
            this.Btn_Debut.Name = "Btn_Debut";
            this.Btn_Debut.Size = new System.Drawing.Size(75, 23);
            this.Btn_Debut.TabIndex = 8;
            this.Btn_Debut.Text = "<<";
            this.Btn_Debut.UseVisualStyleBackColor = true;
            // 
            // Btn_Precedent
            // 
            this.Btn_Precedent.Location = new System.Drawing.Point(102, 336);
            this.Btn_Precedent.Name = "Btn_Precedent";
            this.Btn_Precedent.Size = new System.Drawing.Size(75, 23);
            this.Btn_Precedent.TabIndex = 9;
            this.Btn_Precedent.Text = "<";
            this.Btn_Precedent.UseVisualStyleBackColor = true;
            // 
            // Btn_Suivant
            // 
            this.Btn_Suivant.Location = new System.Drawing.Point(198, 336);
            this.Btn_Suivant.Name = "Btn_Suivant";
            this.Btn_Suivant.Size = new System.Drawing.Size(75, 23);
            this.Btn_Suivant.TabIndex = 10;
            this.Btn_Suivant.Text = ">";
            this.Btn_Suivant.UseVisualStyleBackColor = true;
            // 
            // Btn_Fin
            // 
            this.Btn_Fin.Location = new System.Drawing.Point(295, 336);
            this.Btn_Fin.Name = "Btn_Fin";
            this.Btn_Fin.Size = new System.Drawing.Size(75, 23);
            this.Btn_Fin.TabIndex = 11;
            this.Btn_Fin.Text = ">>";
            this.Btn_Fin.UseVisualStyleBackColor = true;
            this.Btn_Fin.Click += new System.EventHandler(this.button4_Click);
            // 
            // Btn_Supprimer
            // 
            this.Btn_Supprimer.Location = new System.Drawing.Point(391, 336);
            this.Btn_Supprimer.Name = "Btn_Supprimer";
            this.Btn_Supprimer.Size = new System.Drawing.Size(75, 23);
            this.Btn_Supprimer.TabIndex = 12;
            this.Btn_Supprimer.Text = "-";
            this.Btn_Supprimer.UseVisualStyleBackColor = true;
            // 
            // Btn_Ajouter
            // 
            this.Btn_Ajouter.Location = new System.Drawing.Point(484, 336);
            this.Btn_Ajouter.Name = "Btn_Ajouter";
            this.Btn_Ajouter.Size = new System.Drawing.Size(75, 23);
            this.Btn_Ajouter.TabIndex = 13;
            this.Btn_Ajouter.Text = "+";
            this.Btn_Ajouter.UseVisualStyleBackColor = true;
            // 
            // Btn_Modifier
            // 
            this.Btn_Modifier.Location = new System.Drawing.Point(565, 336);
            this.Btn_Modifier.Name = "Btn_Modifier";
            this.Btn_Modifier.Size = new System.Drawing.Size(75, 23);
            this.Btn_Modifier.TabIndex = 14;
            this.Btn_Modifier.Text = "Modifier";
            this.Btn_Modifier.UseVisualStyleBackColor = true;
            // 
            // volsBindingSource
            // 
            this.volsBindingSource.DataSource = typeof(LowCostTravel.vols);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_vols";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_vols";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "id_dest";
            this.dataGridViewTextBoxColumn2.HeaderText = "id_dest";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "id_aero_depart";
            this.dataGridViewTextBoxColumn3.HeaderText = "id_aero_depart";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "id_aero_arriver";
            this.dataGridViewTextBoxColumn4.HeaderText = "id_aero_arriver";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "prix_vols";
            this.dataGridViewTextBoxColumn5.HeaderText = "prix_vols";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // departvolsDataGridViewTextBoxColumn
            // 
            this.departvolsDataGridViewTextBoxColumn.DataPropertyName = "depart_vols";
            this.departvolsDataGridViewTextBoxColumn.HeaderText = "depart_vols";
            this.departvolsDataGridViewTextBoxColumn.Name = "departvolsDataGridViewTextBoxColumn";
            // 
            // arriveevolsDataGridViewTextBoxColumn
            // 
            this.arriveevolsDataGridViewTextBoxColumn.DataPropertyName = "arrivee_vols";
            this.arriveevolsDataGridViewTextBoxColumn.HeaderText = "arrivee_vols";
            this.arriveevolsDataGridViewTextBoxColumn.Name = "arriveevolsDataGridViewTextBoxColumn";
            // 
            // placesdispovolsDataGridViewTextBoxColumn
            // 
            this.placesdispovolsDataGridViewTextBoxColumn.DataPropertyName = "places_dispo_vols";
            this.placesdispovolsDataGridViewTextBoxColumn.HeaderText = "places_dispo_vols";
            this.placesdispovolsDataGridViewTextBoxColumn.Name = "placesdispovolsDataGridViewTextBoxColumn";
            // 
            // placesvolsDataGridViewTextBoxColumn
            // 
            this.placesvolsDataGridViewTextBoxColumn.DataPropertyName = "places_vols";
            this.placesvolsDataGridViewTextBoxColumn.HeaderText = "places_vols";
            this.placesvolsDataGridViewTextBoxColumn.Name = "placesvolsDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "destinations";
            this.dataGridViewTextBoxColumn6.HeaderText = "destinations";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "clients";
            this.dataGridViewTextBoxColumn7.HeaderText = "clients";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // Fm_Vols
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
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Lb_Vols);
            this.Controls.Add(this.Btn_Clients);
            this.Controls.Add(this.Btn_Reservations);
            this.Controls.Add(this.Btn_Destinations);
            this.Controls.Add(this.Btn_Aeroports);
            this.Controls.Add(this.Lb_Choix);
            this.Name = "Fm_Vols";
            this.Text = "Fm_Vols";
            this.Load += new System.EventHandler(this.Fm_Vols_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lb_Choix;
        private System.Windows.Forms.Button Btn_Aeroports;
        private System.Windows.Forms.Button Btn_Destinations;
        private System.Windows.Forms.Button Btn_Reservations;
        private System.Windows.Forms.Button Btn_Clients;
        private System.Windows.Forms.Label Lb_Vols;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Btn_Debut;
        private System.Windows.Forms.Button Btn_Precedent;
        private System.Windows.Forms.Button Btn_Suivant;
        private System.Windows.Forms.Button Btn_Fin;
        private System.Windows.Forms.Button Btn_Supprimer;
        private System.Windows.Forms.Button Btn_Ajouter;
        private System.Windows.Forms.Button Btn_Modifier;
        private System.Windows.Forms.DataGridViewTextBoxColumn idvolsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datevolsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heuredepartvolsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heurearrivervolsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddestDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idaerodepartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idaeroarriverDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixvolsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinationsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn departvolsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arriveevolsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn placesdispovolsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn placesvolsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.BindingSource volsBindingSource;
    }
}