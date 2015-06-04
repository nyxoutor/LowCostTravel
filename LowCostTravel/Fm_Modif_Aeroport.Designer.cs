namespace LowCostTravel
{
    partial class Fm_Modif_Aeroport
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
            System.Windows.Forms.Label Lb_IdAero;
            System.Windows.Forms.Label Lb_VilleAero;
            this.aeroportsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Tb_Id = new System.Windows.Forms.TextBox();
            this.Tb_Ville = new System.Windows.Forms.TextBox();
            this.Lb_Modifier = new System.Windows.Forms.Label();
            this.Bt_Annuler = new System.Windows.Forms.Button();
            this.Bt_Modifier = new System.Windows.Forms.Button();
            Lb_IdAero = new System.Windows.Forms.Label();
            Lb_VilleAero = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aeroportsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Lb_IdAero
            // 
            Lb_IdAero.AutoSize = true;
            Lb_IdAero.Location = new System.Drawing.Point(79, 113);
            Lb_IdAero.Name = "Lb_IdAero";
            Lb_IdAero.Size = new System.Drawing.Size(59, 13);
            Lb_IdAero.TabIndex = 1;
            Lb_IdAero.Text = "Identifiant :";
            // 
            // Lb_VilleAero
            // 
            Lb_VilleAero.AutoSize = true;
            Lb_VilleAero.Location = new System.Drawing.Point(106, 156);
            Lb_VilleAero.Name = "Lb_VilleAero";
            Lb_VilleAero.Size = new System.Drawing.Size(32, 13);
            Lb_VilleAero.TabIndex = 3;
            Lb_VilleAero.Text = "Ville :";
            // 
            // aeroportsBindingSource
            // 
            this.aeroportsBindingSource.DataSource = typeof(LowCostTravel.aeroports);
            // 
            // Tb_Id
            // 
            this.Tb_Id.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aeroportsBindingSource, "id_aero", true));
            this.Tb_Id.Location = new System.Drawing.Point(154, 110);
            this.Tb_Id.Name = "Tb_Id";
            this.Tb_Id.ReadOnly = true;
            this.Tb_Id.Size = new System.Drawing.Size(100, 20);
            this.Tb_Id.TabIndex = 2;
            // 
            // Tb_Ville
            // 
            this.Tb_Ville.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aeroportsBindingSource, "ville_aero", true));
            this.Tb_Ville.Location = new System.Drawing.Point(154, 153);
            this.Tb_Ville.Name = "Tb_Ville";
            this.Tb_Ville.Size = new System.Drawing.Size(100, 20);
            this.Tb_Ville.TabIndex = 4;
            // 
            // Lb_Modifier
            // 
            this.Lb_Modifier.AutoSize = true;
            this.Lb_Modifier.Location = new System.Drawing.Point(96, 66);
            this.Lb_Modifier.Name = "Lb_Modifier";
            this.Lb_Modifier.Size = new System.Drawing.Size(186, 13);
            this.Lb_Modifier.TabIndex = 5;
            this.Lb_Modifier.Text = "Modifier les informations de l\'aéroport :";
            // 
            // Bt_Annuler
            // 
            this.Bt_Annuler.Location = new System.Drawing.Point(82, 229);
            this.Bt_Annuler.Name = "Bt_Annuler";
            this.Bt_Annuler.Size = new System.Drawing.Size(75, 23);
            this.Bt_Annuler.TabIndex = 6;
            this.Bt_Annuler.Text = "Annuler";
            this.Bt_Annuler.UseVisualStyleBackColor = true;
            this.Bt_Annuler.Click += new System.EventHandler(this.Bt_Annuler_Click);
            // 
            // Bt_Modifier
            // 
            this.Bt_Modifier.Location = new System.Drawing.Point(223, 229);
            this.Bt_Modifier.Name = "Bt_Modifier";
            this.Bt_Modifier.Size = new System.Drawing.Size(75, 23);
            this.Bt_Modifier.TabIndex = 7;
            this.Bt_Modifier.Text = "Modifier";
            this.Bt_Modifier.UseVisualStyleBackColor = true;
            this.Bt_Modifier.Click += new System.EventHandler(this.Bt_Modifier_Click);
            // 
            // Fm_Modif_Aeroport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 295);
            this.Controls.Add(this.Bt_Modifier);
            this.Controls.Add(this.Bt_Annuler);
            this.Controls.Add(this.Lb_Modifier);
            this.Controls.Add(Lb_VilleAero);
            this.Controls.Add(this.Tb_Ville);
            this.Controls.Add(Lb_IdAero);
            this.Controls.Add(this.Tb_Id);
            this.Name = "Fm_Modif_Aeroport";
            this.Text = "Fm_Modif_Aeroport";
            this.Load += new System.EventHandler(this.Fm_Modif_Aeroport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aeroportsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource aeroportsBindingSource;
        private System.Windows.Forms.TextBox Tb_Id;
        private System.Windows.Forms.TextBox Tb_Ville;
        private System.Windows.Forms.Label Lb_Modifier;
        private System.Windows.Forms.Button Bt_Annuler;
        private System.Windows.Forms.Button Bt_Modifier;
    }
}