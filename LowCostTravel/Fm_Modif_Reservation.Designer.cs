namespace LowCostTravel
{
    partial class Fm_Modif_Reservation
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
            this.Lb_Client = new System.Windows.Forms.Label();
            this.Lb_Vol = new System.Windows.Forms.Label();
            this.Lb_Etat = new System.Windows.Forms.Label();
            this.Cb_Client = new System.Windows.Forms.ComboBox();
            this.Cb_Vol = new System.Windows.Forms.ComboBox();
            this.Cb_Etat = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Tb_Place = new System.Windows.Forms.TextBox();
            this.Bt_Annuler = new System.Windows.Forms.Button();
            this.Bt_Modifier = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Réservation à modifiée :";
            // 
            // Lb_Client
            // 
            this.Lb_Client.AutoSize = true;
            this.Lb_Client.Location = new System.Drawing.Point(159, 108);
            this.Lb_Client.Name = "Lb_Client";
            this.Lb_Client.Size = new System.Drawing.Size(39, 13);
            this.Lb_Client.TabIndex = 1;
            this.Lb_Client.Text = "Client :";
            // 
            // Lb_Vol
            // 
            this.Lb_Vol.AutoSize = true;
            this.Lb_Vol.Location = new System.Drawing.Point(170, 147);
            this.Lb_Vol.Name = "Lb_Vol";
            this.Lb_Vol.Size = new System.Drawing.Size(28, 13);
            this.Lb_Vol.TabIndex = 2;
            this.Lb_Vol.Text = "Vol :";
            // 
            // Lb_Etat
            // 
            this.Lb_Etat.AutoSize = true;
            this.Lb_Etat.Location = new System.Drawing.Point(85, 186);
            this.Lb_Etat.Name = "Lb_Etat";
            this.Lb_Etat.Size = new System.Drawing.Size(113, 13);
            this.Lb_Etat.TabIndex = 3;
            this.Lb_Etat.Text = "Etat de la réservation :";
            // 
            // Cb_Client
            // 
            this.Cb_Client.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb_Client.Enabled = false;
            this.Cb_Client.FormattingEnabled = true;
            this.Cb_Client.Location = new System.Drawing.Point(250, 105);
            this.Cb_Client.Name = "Cb_Client";
            this.Cb_Client.Size = new System.Drawing.Size(211, 21);
            this.Cb_Client.TabIndex = 4;
            // 
            // Cb_Vol
            // 
            this.Cb_Vol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb_Vol.Enabled = false;
            this.Cb_Vol.FormattingEnabled = true;
            this.Cb_Vol.Location = new System.Drawing.Point(250, 144);
            this.Cb_Vol.Name = "Cb_Vol";
            this.Cb_Vol.Size = new System.Drawing.Size(211, 21);
            this.Cb_Vol.TabIndex = 5;
            // 
            // Cb_Etat
            // 
            this.Cb_Etat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb_Etat.FormattingEnabled = true;
            this.Cb_Etat.Items.AddRange(new object[] {
            "Annulée",
            "En attente",
            "Confirmée"});
            this.Cb_Etat.Location = new System.Drawing.Point(250, 183);
            this.Cb_Etat.Name = "Cb_Etat";
            this.Cb_Etat.Size = new System.Drawing.Size(211, 21);
            this.Cb_Etat.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombres de places réservées :";
            // 
            // Tb_Place
            // 
            this.Tb_Place.Location = new System.Drawing.Point(250, 219);
            this.Tb_Place.Name = "Tb_Place";
            this.Tb_Place.Size = new System.Drawing.Size(211, 20);
            this.Tb_Place.TabIndex = 8;
            // 
            // Bt_Annuler
            // 
            this.Bt_Annuler.Location = new System.Drawing.Point(162, 303);
            this.Bt_Annuler.Name = "Bt_Annuler";
            this.Bt_Annuler.Size = new System.Drawing.Size(75, 23);
            this.Bt_Annuler.TabIndex = 9;
            this.Bt_Annuler.Text = "Annuler";
            this.Bt_Annuler.UseVisualStyleBackColor = true;
            this.Bt_Annuler.Click += new System.EventHandler(this.Bt_Annuler_Click);
            // 
            // Bt_Modifier
            // 
            this.Bt_Modifier.Location = new System.Drawing.Point(296, 303);
            this.Bt_Modifier.Name = "Bt_Modifier";
            this.Bt_Modifier.Size = new System.Drawing.Size(75, 23);
            this.Bt_Modifier.TabIndex = 10;
            this.Bt_Modifier.Text = "Modifier";
            this.Bt_Modifier.UseVisualStyleBackColor = true;
            this.Bt_Modifier.Click += new System.EventHandler(this.Bt_Modifier_Click);
            // 
            // Fm_Modif_Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 390);
            this.Controls.Add(this.Bt_Modifier);
            this.Controls.Add(this.Bt_Annuler);
            this.Controls.Add(this.Tb_Place);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Cb_Etat);
            this.Controls.Add(this.Cb_Vol);
            this.Controls.Add(this.Cb_Client);
            this.Controls.Add(this.Lb_Etat);
            this.Controls.Add(this.Lb_Vol);
            this.Controls.Add(this.Lb_Client);
            this.Controls.Add(this.label1);
            this.Name = "Fm_Modif_Reservation";
            this.Text = "Fm_Modif_Reservation";
            this.Load += new System.EventHandler(this.Fm_Modif_Reservation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lb_Client;
        private System.Windows.Forms.Label Lb_Vol;
        private System.Windows.Forms.Label Lb_Etat;
        private System.Windows.Forms.ComboBox Cb_Client;
        private System.Windows.Forms.ComboBox Cb_Vol;
        private System.Windows.Forms.ComboBox Cb_Etat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Tb_Place;
        private System.Windows.Forms.Button Bt_Annuler;
        private System.Windows.Forms.Button Bt_Modifier;
    }
}