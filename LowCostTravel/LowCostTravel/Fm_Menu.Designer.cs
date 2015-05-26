namespace LowCostTravel
{
    partial class Fm_Menu
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
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Aeroports = new System.Windows.Forms.Button();
            this.Btn_Clients = new System.Windows.Forms.Button();
            this.Btn_Destinations = new System.Windows.Forms.Button();
            this.Btn_Reservations = new System.Windows.Forms.Button();
            this.Btn_Vols = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choisissez la table que vous voulez modifier :";
            // 
            // Btn_Aeroports
            // 
            this.Btn_Aeroports.Location = new System.Drawing.Point(111, 165);
            this.Btn_Aeroports.Name = "Btn_Aeroports";
            this.Btn_Aeroports.Size = new System.Drawing.Size(83, 23);
            this.Btn_Aeroports.TabIndex = 1;
            this.Btn_Aeroports.Text = "Aéroports";
            this.Btn_Aeroports.UseVisualStyleBackColor = true;
            this.Btn_Aeroports.Click += new System.EventHandler(this.Btn_Aeroports_Click);
            // 
            // Btn_Clients
            // 
            this.Btn_Clients.Location = new System.Drawing.Point(267, 165);
            this.Btn_Clients.Name = "Btn_Clients";
            this.Btn_Clients.Size = new System.Drawing.Size(83, 23);
            this.Btn_Clients.TabIndex = 2;
            this.Btn_Clients.Text = "Clients";
            this.Btn_Clients.UseVisualStyleBackColor = true;
            this.Btn_Clients.Click += new System.EventHandler(this.Btn_Clients_Click);
            // 
            // Btn_Destinations
            // 
            this.Btn_Destinations.Location = new System.Drawing.Point(111, 214);
            this.Btn_Destinations.Name = "Btn_Destinations";
            this.Btn_Destinations.Size = new System.Drawing.Size(83, 23);
            this.Btn_Destinations.TabIndex = 3;
            this.Btn_Destinations.Text = "Destinations";
            this.Btn_Destinations.UseVisualStyleBackColor = true;
            // 
            // Btn_Reservations
            // 
            this.Btn_Reservations.Location = new System.Drawing.Point(267, 214);
            this.Btn_Reservations.Name = "Btn_Reservations";
            this.Btn_Reservations.Size = new System.Drawing.Size(83, 23);
            this.Btn_Reservations.TabIndex = 4;
            this.Btn_Reservations.Text = "Réservations";
            this.Btn_Reservations.UseVisualStyleBackColor = true;
            // 
            // Btn_Vols
            // 
            this.Btn_Vols.Location = new System.Drawing.Point(191, 270);
            this.Btn_Vols.Name = "Btn_Vols";
            this.Btn_Vols.Size = new System.Drawing.Size(80, 23);
            this.Btn_Vols.TabIndex = 5;
            this.Btn_Vols.Text = "Vols";
            this.Btn_Vols.UseVisualStyleBackColor = true;
            this.Btn_Vols.Click += new System.EventHandler(this.Btn_Vols_Click);
            // 
            // Fm_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 334);
            this.Controls.Add(this.Btn_Vols);
            this.Controls.Add(this.Btn_Reservations);
            this.Controls.Add(this.Btn_Destinations);
            this.Controls.Add(this.Btn_Clients);
            this.Controls.Add(this.Btn_Aeroports);
            this.Controls.Add(this.label1);
            this.Name = "Fm_Menu";
            this.Text = "Fm_Menu";
            this.Load += new System.EventHandler(this.Fm_Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Aeroports;
        private System.Windows.Forms.Button Btn_Clients;
        private System.Windows.Forms.Button Btn_Destinations;
        private System.Windows.Forms.Button Btn_Reservations;
        private System.Windows.Forms.Button Btn_Vols;
    }
}