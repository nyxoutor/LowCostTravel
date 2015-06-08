namespace LowCostTravel
{
    partial class Fm_Add_Compagnie
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
            this.Tb_Nom = new System.Windows.Forms.TextBox();
            this.Bt_Annuler = new System.Windows.Forms.Button();
            this.Bt_Ajouter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Compagnie à ajouter :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom de la compagnie :";
            // 
            // Tb_Nom
            // 
            this.Tb_Nom.Location = new System.Drawing.Point(262, 151);
            this.Tb_Nom.Name = "Tb_Nom";
            this.Tb_Nom.Size = new System.Drawing.Size(100, 20);
            this.Tb_Nom.TabIndex = 2;
            // 
            // Bt_Annuler
            // 
            this.Bt_Annuler.Location = new System.Drawing.Point(124, 248);
            this.Bt_Annuler.Name = "Bt_Annuler";
            this.Bt_Annuler.Size = new System.Drawing.Size(75, 23);
            this.Bt_Annuler.TabIndex = 3;
            this.Bt_Annuler.Text = "Annuler";
            this.Bt_Annuler.UseVisualStyleBackColor = true;
            this.Bt_Annuler.Click += new System.EventHandler(this.Bt_Annuler_Click);
            // 
            // Bt_Ajouter
            // 
            this.Bt_Ajouter.Location = new System.Drawing.Point(287, 248);
            this.Bt_Ajouter.Name = "Bt_Ajouter";
            this.Bt_Ajouter.Size = new System.Drawing.Size(75, 23);
            this.Bt_Ajouter.TabIndex = 4;
            this.Bt_Ajouter.Text = "Ajouter";
            this.Bt_Ajouter.UseVisualStyleBackColor = true;
            this.Bt_Ajouter.Click += new System.EventHandler(this.Bt_Ajouter_Click);
            // 
            // Fm_Add_Compagnie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 336);
            this.Controls.Add(this.Bt_Ajouter);
            this.Controls.Add(this.Bt_Annuler);
            this.Controls.Add(this.Tb_Nom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Fm_Add_Compagnie";
            this.Text = "Fm_Add_Compagnie";
            this.Load += new System.EventHandler(this.Fm_Add_Compagnie_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Tb_Nom;
        private System.Windows.Forms.Button Bt_Annuler;
        private System.Windows.Forms.Button Bt_Ajouter;
    }
}