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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
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
            this.Lb_Client.Location = new System.Drawing.Point(109, 108);
            this.Lb_Client.Name = "Lb_Client";
            this.Lb_Client.Size = new System.Drawing.Size(39, 13);
            this.Lb_Client.TabIndex = 1;
            this.Lb_Client.Text = "Client :";
            // 
            // Lb_Vol
            // 
            this.Lb_Vol.AutoSize = true;
            this.Lb_Vol.Location = new System.Drawing.Point(120, 147);
            this.Lb_Vol.Name = "Lb_Vol";
            this.Lb_Vol.Size = new System.Drawing.Size(28, 13);
            this.Lb_Vol.TabIndex = 2;
            this.Lb_Vol.Text = "Vol :";
            // 
            // Lb_Etat
            // 
            this.Lb_Etat.AutoSize = true;
            this.Lb_Etat.Location = new System.Drawing.Point(35, 183);
            this.Lb_Etat.Name = "Lb_Etat";
            this.Lb_Etat.Size = new System.Drawing.Size(113, 13);
            this.Lb_Etat.TabIndex = 3;
            this.Lb_Etat.Text = "Etat de la réservation :";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(250, 105);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(250, 144);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 5;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Annulée",
            "En attente",
            "Confirmée"});
            this.comboBox3.Location = new System.Drawing.Point(250, 183);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 6;
            // 
            // Fm_Modif_Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 390);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Lb_Etat);
            this.Controls.Add(this.Lb_Vol);
            this.Controls.Add(this.Lb_Client);
            this.Controls.Add(this.label1);
            this.Name = "Fm_Modif_Reservation";
            this.Text = "Fm_Modif_Reservation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lb_Client;
        private System.Windows.Forms.Label Lb_Vol;
        private System.Windows.Forms.Label Lb_Etat;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
    }
}