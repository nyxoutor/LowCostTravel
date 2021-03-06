﻿namespace LowCostTravel
{
    partial class Fm_Reservations
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
            this.label1 = new System.Windows.Forms.Label();
            this.Bt_Aeroports = new System.Windows.Forms.Button();
            this.Bt_Clients = new System.Windows.Forms.Button();
            this.Bt_Vols = new System.Windows.Forms.Button();
            this.Lb_Reservations = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.date_reservation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etat_reservation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_clients = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom_client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prenom_client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_vol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Depart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Arrivee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_Vol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.place_reservation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reservationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Bt_Debut = new System.Windows.Forms.Button();
            this.Bt_Precedent = new System.Windows.Forms.Button();
            this.Bt_Suivant = new System.Windows.Forms.Button();
            this.Bt_Fin = new System.Windows.Forms.Button();
            this.Bt_Supprimer = new System.Windows.Forms.Button();
            this.Bt_Ajout = new System.Windows.Forms.Button();
            this.Bt_Modifier = new System.Windows.Forms.Button();
            this.idvolsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idclientsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etatreservationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datereservationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placereservationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.volsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomclientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomclientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arriveeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateVolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Changer de table :";
            // 
            // Bt_Aeroports
            // 
            this.Bt_Aeroports.Location = new System.Drawing.Point(170, 22);
            this.Bt_Aeroports.Name = "Bt_Aeroports";
            this.Bt_Aeroports.Size = new System.Drawing.Size(75, 23);
            this.Bt_Aeroports.TabIndex = 1;
            this.Bt_Aeroports.Text = "Aéroports";
            this.Bt_Aeroports.UseVisualStyleBackColor = true;
            this.Bt_Aeroports.Click += new System.EventHandler(this.Bt_Aeroports_Click);
            // 
            // Bt_Clients
            // 
            this.Bt_Clients.Location = new System.Drawing.Point(279, 22);
            this.Bt_Clients.Name = "Bt_Clients";
            this.Bt_Clients.Size = new System.Drawing.Size(75, 23);
            this.Bt_Clients.TabIndex = 2;
            this.Bt_Clients.Text = "Clients";
            this.Bt_Clients.UseVisualStyleBackColor = true;
            this.Bt_Clients.Click += new System.EventHandler(this.Bt_Clients_Click);
            // 
            // Bt_Vols
            // 
            this.Bt_Vols.Location = new System.Drawing.Point(393, 22);
            this.Bt_Vols.Name = "Bt_Vols";
            this.Bt_Vols.Size = new System.Drawing.Size(75, 23);
            this.Bt_Vols.TabIndex = 3;
            this.Bt_Vols.Text = "Vols";
            this.Bt_Vols.UseVisualStyleBackColor = true;
            this.Bt_Vols.Click += new System.EventHandler(this.Bt_Vols_Click);
            // 
            // Lb_Reservations
            // 
            this.Lb_Reservations.AutoSize = true;
            this.Lb_Reservations.Location = new System.Drawing.Point(276, 100);
            this.Lb_Reservations.Name = "Lb_Reservations";
            this.Lb_Reservations.Size = new System.Drawing.Size(115, 13);
            this.Lb_Reservations.TabIndex = 4;
            this.Lb_Reservations.Text = "Liste des réservations :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.date_reservation,
            this.etat_reservation,
            this.id_clients,
            this.Nom_client,
            this.Prenom_client,
            this.id_vol,
            this.Depart,
            this.Arrivee,
            this.Date_Vol,
            this.place_reservation,
            this.idvolsDataGridViewTextBoxColumn,
            this.idclientsDataGridViewTextBoxColumn,
            this.etatreservationDataGridViewTextBoxColumn,
            this.datereservationDataGridViewTextBoxColumn,
            this.placereservationDataGridViewTextBoxColumn,
            this.clientsDataGridViewTextBoxColumn,
            this.volsDataGridViewTextBoxColumn,
            this.nomclientDataGridViewTextBoxColumn,
            this.prenomclientDataGridViewTextBoxColumn,
            this.departDataGridViewTextBoxColumn,
            this.arriveeDataGridViewTextBoxColumn,
            this.dateVolDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.reservationBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(76, 145);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(480, 189);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // date_reservation
            // 
            this.date_reservation.DataPropertyName = "date_reservation";
            this.date_reservation.HeaderText = "Date réservation";
            this.date_reservation.Name = "date_reservation";
            this.date_reservation.ReadOnly = true;
            // 
            // etat_reservation
            // 
            this.etat_reservation.DataPropertyName = "etat_reservation";
            this.etat_reservation.HeaderText = "Etat de la réservation";
            this.etat_reservation.Name = "etat_reservation";
            this.etat_reservation.ReadOnly = true;
            // 
            // id_clients
            // 
            this.id_clients.DataPropertyName = "id_clients";
            this.id_clients.HeaderText = "ID Client";
            this.id_clients.Name = "id_clients";
            this.id_clients.ReadOnly = true;
            // 
            // Nom_client
            // 
            this.Nom_client.DataPropertyName = "Nom_client";
            this.Nom_client.HeaderText = "Nom Client";
            this.Nom_client.Name = "Nom_client";
            this.Nom_client.ReadOnly = true;
            // 
            // Prenom_client
            // 
            this.Prenom_client.DataPropertyName = "Prenom_client";
            this.Prenom_client.HeaderText = "Prenom Client";
            this.Prenom_client.Name = "Prenom_client";
            this.Prenom_client.ReadOnly = true;
            // 
            // id_vol
            // 
            this.id_vol.DataPropertyName = "id_vols";
            this.id_vol.HeaderText = "ID Vol";
            this.id_vol.Name = "id_vol";
            this.id_vol.ReadOnly = true;
            // 
            // Depart
            // 
            this.Depart.DataPropertyName = "Depart";
            this.Depart.HeaderText = "Depart";
            this.Depart.Name = "Depart";
            this.Depart.ReadOnly = true;
            // 
            // Arrivee
            // 
            this.Arrivee.DataPropertyName = "Arrivee";
            this.Arrivee.HeaderText = "Arrivee";
            this.Arrivee.Name = "Arrivee";
            this.Arrivee.ReadOnly = true;
            // 
            // Date_Vol
            // 
            this.Date_Vol.DataPropertyName = "Date_Vol";
            this.Date_Vol.HeaderText = "Date du vol";
            this.Date_Vol.Name = "Date_Vol";
            this.Date_Vol.ReadOnly = true;
            // 
            // place_reservation
            // 
            this.place_reservation.DataPropertyName = "place_reservation";
            this.place_reservation.HeaderText = "Nombre de places";
            this.place_reservation.Name = "place_reservation";
            this.place_reservation.ReadOnly = true;
            // 
            // reservationBindingSource
            // 
            this.reservationBindingSource.DataSource = typeof(LowCostTravel.reservation);
            // 
            // Bt_Debut
            // 
            this.Bt_Debut.Location = new System.Drawing.Point(12, 375);
            this.Bt_Debut.Name = "Bt_Debut";
            this.Bt_Debut.Size = new System.Drawing.Size(75, 23);
            this.Bt_Debut.TabIndex = 6;
            this.Bt_Debut.Text = "<<";
            this.Bt_Debut.UseVisualStyleBackColor = true;
            this.Bt_Debut.Click += new System.EventHandler(this.Bt_Debut_Click);
            // 
            // Bt_Precedent
            // 
            this.Bt_Precedent.Location = new System.Drawing.Point(93, 375);
            this.Bt_Precedent.Name = "Bt_Precedent";
            this.Bt_Precedent.Size = new System.Drawing.Size(75, 23);
            this.Bt_Precedent.TabIndex = 7;
            this.Bt_Precedent.Text = "<";
            this.Bt_Precedent.UseVisualStyleBackColor = true;
            this.Bt_Precedent.Click += new System.EventHandler(this.Bt_Precedent_Click);
            // 
            // Bt_Suivant
            // 
            this.Bt_Suivant.Location = new System.Drawing.Point(174, 375);
            this.Bt_Suivant.Name = "Bt_Suivant";
            this.Bt_Suivant.Size = new System.Drawing.Size(75, 23);
            this.Bt_Suivant.TabIndex = 8;
            this.Bt_Suivant.Text = ">";
            this.Bt_Suivant.UseVisualStyleBackColor = true;
            this.Bt_Suivant.Click += new System.EventHandler(this.Bt_Suivant_Click);
            // 
            // Bt_Fin
            // 
            this.Bt_Fin.Location = new System.Drawing.Point(255, 375);
            this.Bt_Fin.Name = "Bt_Fin";
            this.Bt_Fin.Size = new System.Drawing.Size(75, 23);
            this.Bt_Fin.TabIndex = 9;
            this.Bt_Fin.Text = ">>";
            this.Bt_Fin.UseVisualStyleBackColor = true;
            this.Bt_Fin.Click += new System.EventHandler(this.Bt_Fin_Click);
            // 
            // Bt_Supprimer
            // 
            this.Bt_Supprimer.Location = new System.Drawing.Point(336, 375);
            this.Bt_Supprimer.Name = "Bt_Supprimer";
            this.Bt_Supprimer.Size = new System.Drawing.Size(75, 23);
            this.Bt_Supprimer.TabIndex = 10;
            this.Bt_Supprimer.Text = "-";
            this.Bt_Supprimer.UseVisualStyleBackColor = true;
            this.Bt_Supprimer.Click += new System.EventHandler(this.Bt_Supprimer_Click);
            // 
            // Bt_Ajout
            // 
            this.Bt_Ajout.Location = new System.Drawing.Point(428, 375);
            this.Bt_Ajout.Name = "Bt_Ajout";
            this.Bt_Ajout.Size = new System.Drawing.Size(75, 23);
            this.Bt_Ajout.TabIndex = 11;
            this.Bt_Ajout.Text = "+";
            this.Bt_Ajout.UseVisualStyleBackColor = true;
            this.Bt_Ajout.Click += new System.EventHandler(this.Bt_Ajout_Click);
            // 
            // Bt_Modifier
            // 
            this.Bt_Modifier.Location = new System.Drawing.Point(523, 375);
            this.Bt_Modifier.Name = "Bt_Modifier";
            this.Bt_Modifier.Size = new System.Drawing.Size(75, 23);
            this.Bt_Modifier.TabIndex = 12;
            this.Bt_Modifier.Text = "Modifier";
            this.Bt_Modifier.UseVisualStyleBackColor = true;
            this.Bt_Modifier.Click += new System.EventHandler(this.Bt_Modifier_Click);
            // 
            // idvolsDataGridViewTextBoxColumn
            // 
            this.idvolsDataGridViewTextBoxColumn.DataPropertyName = "id_vols";
            this.idvolsDataGridViewTextBoxColumn.HeaderText = "id_vols";
            this.idvolsDataGridViewTextBoxColumn.Name = "idvolsDataGridViewTextBoxColumn";
            this.idvolsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idclientsDataGridViewTextBoxColumn
            // 
            this.idclientsDataGridViewTextBoxColumn.DataPropertyName = "id_clients";
            this.idclientsDataGridViewTextBoxColumn.HeaderText = "id_clients";
            this.idclientsDataGridViewTextBoxColumn.Name = "idclientsDataGridViewTextBoxColumn";
            this.idclientsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // etatreservationDataGridViewTextBoxColumn
            // 
            this.etatreservationDataGridViewTextBoxColumn.DataPropertyName = "etat_reservation";
            this.etatreservationDataGridViewTextBoxColumn.HeaderText = "etat_reservation";
            this.etatreservationDataGridViewTextBoxColumn.Name = "etatreservationDataGridViewTextBoxColumn";
            this.etatreservationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datereservationDataGridViewTextBoxColumn
            // 
            this.datereservationDataGridViewTextBoxColumn.DataPropertyName = "date_reservation";
            this.datereservationDataGridViewTextBoxColumn.HeaderText = "date_reservation";
            this.datereservationDataGridViewTextBoxColumn.Name = "datereservationDataGridViewTextBoxColumn";
            this.datereservationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // placereservationDataGridViewTextBoxColumn
            // 
            this.placereservationDataGridViewTextBoxColumn.DataPropertyName = "place_reservation";
            this.placereservationDataGridViewTextBoxColumn.HeaderText = "place_reservation";
            this.placereservationDataGridViewTextBoxColumn.Name = "placereservationDataGridViewTextBoxColumn";
            this.placereservationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clientsDataGridViewTextBoxColumn
            // 
            this.clientsDataGridViewTextBoxColumn.DataPropertyName = "clients";
            this.clientsDataGridViewTextBoxColumn.HeaderText = "clients";
            this.clientsDataGridViewTextBoxColumn.Name = "clientsDataGridViewTextBoxColumn";
            this.clientsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // volsDataGridViewTextBoxColumn
            // 
            this.volsDataGridViewTextBoxColumn.DataPropertyName = "vols";
            this.volsDataGridViewTextBoxColumn.HeaderText = "vols";
            this.volsDataGridViewTextBoxColumn.Name = "volsDataGridViewTextBoxColumn";
            this.volsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomclientDataGridViewTextBoxColumn
            // 
            this.nomclientDataGridViewTextBoxColumn.DataPropertyName = "Nom_client";
            this.nomclientDataGridViewTextBoxColumn.HeaderText = "Nom_client";
            this.nomclientDataGridViewTextBoxColumn.Name = "nomclientDataGridViewTextBoxColumn";
            this.nomclientDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prenomclientDataGridViewTextBoxColumn
            // 
            this.prenomclientDataGridViewTextBoxColumn.DataPropertyName = "Prenom_client";
            this.prenomclientDataGridViewTextBoxColumn.HeaderText = "Prenom_client";
            this.prenomclientDataGridViewTextBoxColumn.Name = "prenomclientDataGridViewTextBoxColumn";
            this.prenomclientDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // departDataGridViewTextBoxColumn
            // 
            this.departDataGridViewTextBoxColumn.DataPropertyName = "Depart";
            this.departDataGridViewTextBoxColumn.HeaderText = "Depart";
            this.departDataGridViewTextBoxColumn.Name = "departDataGridViewTextBoxColumn";
            this.departDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // arriveeDataGridViewTextBoxColumn
            // 
            this.arriveeDataGridViewTextBoxColumn.DataPropertyName = "Arrivee";
            this.arriveeDataGridViewTextBoxColumn.HeaderText = "Arrivee";
            this.arriveeDataGridViewTextBoxColumn.Name = "arriveeDataGridViewTextBoxColumn";
            this.arriveeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateVolDataGridViewTextBoxColumn
            // 
            this.dateVolDataGridViewTextBoxColumn.DataPropertyName = "Date_Vol";
            this.dateVolDataGridViewTextBoxColumn.HeaderText = "Date_Vol";
            this.dateVolDataGridViewTextBoxColumn.Name = "dateVolDataGridViewTextBoxColumn";
            this.dateVolDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Fm_Reservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 423);
            this.Controls.Add(this.Bt_Modifier);
            this.Controls.Add(this.Bt_Ajout);
            this.Controls.Add(this.Bt_Supprimer);
            this.Controls.Add(this.Bt_Fin);
            this.Controls.Add(this.Bt_Suivant);
            this.Controls.Add(this.Bt_Precedent);
            this.Controls.Add(this.Bt_Debut);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Lb_Reservations);
            this.Controls.Add(this.Bt_Vols);
            this.Controls.Add(this.Bt_Clients);
            this.Controls.Add(this.Bt_Aeroports);
            this.Controls.Add(this.label1);
            this.Name = "Fm_Reservations";
            this.Text = "Liste des réservations";
            this.Load += new System.EventHandler(this.Fm_Reservations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Bt_Aeroports;
        private System.Windows.Forms.Button Bt_Clients;
        private System.Windows.Forms.Button Bt_Vols;
        private System.Windows.Forms.Label Lb_Reservations;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Bt_Debut;
        private System.Windows.Forms.Button Bt_Precedent;
        private System.Windows.Forms.Button Bt_Suivant;
        private System.Windows.Forms.Button Bt_Fin;
        private System.Windows.Forms.Button Bt_Supprimer;
        private System.Windows.Forms.Button Bt_Ajout;
        private System.Windows.Forms.Button Bt_Modifier;
        private System.Windows.Forms.DataGridViewTextBoxColumn etatreservationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datereservationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn placereservationDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource reservationBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_reservation;
        private System.Windows.Forms.DataGridViewTextBoxColumn etat_reservation;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_clients;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom_client;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prenom_client;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_vol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Depart;
        private System.Windows.Forms.DataGridViewTextBoxColumn Arrivee;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_Vol;
        private System.Windows.Forms.DataGridViewTextBoxColumn place_reservation;
        private System.Windows.Forms.DataGridViewTextBoxColumn idvolsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idclientsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn volsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomclientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomclientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arriveeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateVolDataGridViewTextBoxColumn;
    }
}