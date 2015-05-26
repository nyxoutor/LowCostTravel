namespace LowCostTravel
{
    partial class Fm_Add_Aeroport
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
            this.Lb_Aero = new System.Windows.Forms.Label();
            this.Lb_Ville = new System.Windows.Forms.Label();
            this.Tb_Ville = new System.Windows.Forms.TextBox();
            this.Bt_Ajouter = new System.Windows.Forms.Button();
            this.Btn_Annuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lb_Aero
            // 
            this.Lb_Aero.AutoSize = true;
            this.Lb_Aero.Location = new System.Drawing.Point(122, 53);
            this.Lb_Aero.Name = "Lb_Aero";
            this.Lb_Aero.Size = new System.Drawing.Size(89, 13);
            this.Lb_Aero.TabIndex = 0;
            this.Lb_Aero.Text = "Nouvel aéroport :";
            // 
            // Lb_Ville
            // 
            this.Lb_Ville.AutoSize = true;
            this.Lb_Ville.Location = new System.Drawing.Point(67, 136);
            this.Lb_Ville.Name = "Lb_Ville";
            this.Lb_Ville.Size = new System.Drawing.Size(32, 13);
            this.Lb_Ville.TabIndex = 1;
            this.Lb_Ville.Text = "Ville :";
            // 
            // Tb_Ville
            // 
            this.Tb_Ville.Location = new System.Drawing.Point(125, 133);
            this.Tb_Ville.Name = "Tb_Ville";
            this.Tb_Ville.Size = new System.Drawing.Size(100, 20);
            this.Tb_Ville.TabIndex = 2;
            // 
            // Bt_Ajouter
            // 
            this.Bt_Ajouter.Location = new System.Drawing.Point(185, 205);
            this.Bt_Ajouter.Name = "Bt_Ajouter";
            this.Bt_Ajouter.Size = new System.Drawing.Size(75, 23);
            this.Bt_Ajouter.TabIndex = 3;
            this.Bt_Ajouter.Text = "Ajouter";
            this.Bt_Ajouter.UseVisualStyleBackColor = true;
            this.Bt_Ajouter.Click += new System.EventHandler(this.Bt_Ajouter_Click);
            // 
            // Btn_Annuler
            // 
            this.Btn_Annuler.Location = new System.Drawing.Point(86, 205);
            this.Btn_Annuler.Name = "Btn_Annuler";
            this.Btn_Annuler.Size = new System.Drawing.Size(75, 23);
            this.Btn_Annuler.TabIndex = 4;
            this.Btn_Annuler.Text = "Annuler";
            this.Btn_Annuler.UseVisualStyleBackColor = true;
            this.Btn_Annuler.Click += new System.EventHandler(this.Btn_Annuler_Click);
            // 
            // Fm_Add_Aeroport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 315);
            this.Controls.Add(this.Btn_Annuler);
            this.Controls.Add(this.Bt_Ajouter);
            this.Controls.Add(this.Tb_Ville);
            this.Controls.Add(this.Lb_Ville);
            this.Controls.Add(this.Lb_Aero);
            this.Name = "Fm_Add_Aeroport";
            this.Text = "Fm_Add_Aeroport";
            this.Load += new System.EventHandler(this.Fm_Add_Aeroport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lb_Aero;
        private System.Windows.Forms.Label Lb_Ville;
        private System.Windows.Forms.TextBox Tb_Ville;
        private System.Windows.Forms.Button Bt_Ajouter;
        private System.Windows.Forms.Button Btn_Annuler;
    }
}