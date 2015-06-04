namespace LowCostTravel
{
    partial class Fm_Add_Reservation
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CB_Clients = new System.Windows.Forms.ComboBox();
            this.CB_Vols = new System.Windows.Forms.ComboBox();
            this.TB_Places = new System.Windows.Forms.TextBox();
            this.Bt_Annuler = new System.Windows.Forms.Button();
            this.Bt_Confirmer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(216, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nouvelle Réservation :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Client :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(189, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vol :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(172, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Places :";
            // 
            // CB_Clients
            // 
            this.CB_Clients.FormattingEnabled = true;
            this.CB_Clients.Location = new System.Drawing.Point(289, 83);
            this.CB_Clients.Name = "CB_Clients";
            this.CB_Clients.Size = new System.Drawing.Size(258, 21);
            this.CB_Clients.TabIndex = 5;
            // 
            // CB_Vols
            // 
            this.CB_Vols.FormattingEnabled = true;
            this.CB_Vols.Location = new System.Drawing.Point(289, 126);
            this.CB_Vols.Name = "CB_Vols";
            this.CB_Vols.Size = new System.Drawing.Size(258, 21);
            this.CB_Vols.TabIndex = 6;
            // 
            // TB_Places
            // 
            this.TB_Places.Location = new System.Drawing.Point(289, 165);
            this.TB_Places.Name = "TB_Places";
            this.TB_Places.Size = new System.Drawing.Size(258, 20);
            this.TB_Places.TabIndex = 7;
            // 
            // Bt_Annuler
            // 
            this.Bt_Annuler.Location = new System.Drawing.Point(192, 265);
            this.Bt_Annuler.Name = "Bt_Annuler";
            this.Bt_Annuler.Size = new System.Drawing.Size(75, 23);
            this.Bt_Annuler.TabIndex = 8;
            this.Bt_Annuler.Text = "Annuler";
            this.Bt_Annuler.UseVisualStyleBackColor = true;
            this.Bt_Annuler.Click += new System.EventHandler(this.Bt_Annuler_Click);
            // 
            // Bt_Confirmer
            // 
            this.Bt_Confirmer.Location = new System.Drawing.Point(301, 265);
            this.Bt_Confirmer.Name = "Bt_Confirmer";
            this.Bt_Confirmer.Size = new System.Drawing.Size(75, 23);
            this.Bt_Confirmer.TabIndex = 9;
            this.Bt_Confirmer.Text = "Confirmer";
            this.Bt_Confirmer.UseVisualStyleBackColor = true;
            this.Bt_Confirmer.Click += new System.EventHandler(this.Bt_Confirmer_Click);
            // 
            // Fm_Add_Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 385);
            this.Controls.Add(this.Bt_Confirmer);
            this.Controls.Add(this.Bt_Annuler);
            this.Controls.Add(this.TB_Places);
            this.Controls.Add(this.CB_Vols);
            this.Controls.Add(this.CB_Clients);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Fm_Add_Reservation";
            this.Text = "Fm_Add_Reservation";
            this.Load += new System.EventHandler(this.Fm_Add_Reservation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CB_Clients;
        private System.Windows.Forms.ComboBox CB_Vols;
        private System.Windows.Forms.TextBox TB_Places;
        private System.Windows.Forms.Button Bt_Annuler;
        private System.Windows.Forms.Button Bt_Confirmer;
    }
}