namespace LowCostTravel
{
    partial class Fm_Add_Vols
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
            this.Lb_New_Vol = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Lb_Dh_Depart = new System.Windows.Forms.Label();
            this.Lb_Dh_Arrivee = new System.Windows.Forms.Label();
            this.Lb_Lieu_Depart = new System.Windows.Forms.Label();
            this.Cb_Depart = new System.Windows.Forms.ComboBox();
            this.Lb_Lieu_Arrivee = new System.Windows.Forms.Label();
            this.Cb_arrivee = new System.Windows.Forms.ComboBox();
            this.Lb_Prix = new System.Windows.Forms.Label();
            this.Tb_Prix = new System.Windows.Forms.TextBox();
            this.Lb_Places = new System.Windows.Forms.Label();
            this.Tb_Places = new System.Windows.Forms.TextBox();
            this.Btn_Annuler = new System.Windows.Forms.Button();
            this.Btn_Ajouter = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // Lb_New_Vol
            // 
            this.Lb_New_Vol.AutoSize = true;
            this.Lb_New_Vol.Location = new System.Drawing.Point(262, 23);
            this.Lb_New_Vol.Name = "Lb_New_Vol";
            this.Lb_New_Vol.Size = new System.Drawing.Size(74, 13);
            this.Lb_New_Vol.TabIndex = 0;
            this.Lb_New_Vol.Text = "Nouveau vol :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dddd dd MMMM yyyy HH:mm:ss";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(265, 69);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(228, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // Lb_Dh_Depart
            // 
            this.Lb_Dh_Depart.AutoSize = true;
            this.Lb_Dh_Depart.Location = new System.Drawing.Point(115, 75);
            this.Lb_Dh_Depart.Name = "Lb_Dh_Depart";
            this.Lb_Dh_Depart.Size = new System.Drawing.Size(105, 13);
            this.Lb_Dh_Depart.TabIndex = 2;
            this.Lb_Dh_Depart.Text = "Date/Heure Départ :";
            // 
            // Lb_Dh_Arrivee
            // 
            this.Lb_Dh_Arrivee.AutoSize = true;
            this.Lb_Dh_Arrivee.Location = new System.Drawing.Point(114, 117);
            this.Lb_Dh_Arrivee.Name = "Lb_Dh_Arrivee";
            this.Lb_Dh_Arrivee.Size = new System.Drawing.Size(106, 13);
            this.Lb_Dh_Arrivee.TabIndex = 3;
            this.Lb_Dh_Arrivee.Text = "Date/Heure Arrivée :";
            // 
            // Lb_Lieu_Depart
            // 
            this.Lb_Lieu_Depart.AutoSize = true;
            this.Lb_Lieu_Depart.Location = new System.Drawing.Point(175, 166);
            this.Lb_Lieu_Depart.Name = "Lb_Lieu_Depart";
            this.Lb_Lieu_Depart.Size = new System.Drawing.Size(45, 13);
            this.Lb_Lieu_Depart.TabIndex = 5;
            this.Lb_Lieu_Depart.Text = "Départ :";
            // 
            // Cb_Depart
            // 
            this.Cb_Depart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb_Depart.FormattingEnabled = true;
            this.Cb_Depart.Location = new System.Drawing.Point(265, 166);
            this.Cb_Depart.Name = "Cb_Depart";
            this.Cb_Depart.Size = new System.Drawing.Size(121, 21);
            this.Cb_Depart.TabIndex = 6;
            // 
            // Lb_Lieu_Arrivee
            // 
            this.Lb_Lieu_Arrivee.AutoSize = true;
            this.Lb_Lieu_Arrivee.Location = new System.Drawing.Point(174, 208);
            this.Lb_Lieu_Arrivee.Name = "Lb_Lieu_Arrivee";
            this.Lb_Lieu_Arrivee.Size = new System.Drawing.Size(46, 13);
            this.Lb_Lieu_Arrivee.TabIndex = 7;
            this.Lb_Lieu_Arrivee.Text = "Arrivée :";
            // 
            // Cb_arrivee
            // 
            this.Cb_arrivee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb_arrivee.FormattingEnabled = true;
            this.Cb_arrivee.Location = new System.Drawing.Point(264, 205);
            this.Cb_arrivee.Name = "Cb_arrivee";
            this.Cb_arrivee.Size = new System.Drawing.Size(121, 21);
            this.Cb_arrivee.TabIndex = 8;
            // 
            // Lb_Prix
            // 
            this.Lb_Prix.AutoSize = true;
            this.Lb_Prix.Location = new System.Drawing.Point(186, 252);
            this.Lb_Prix.Name = "Lb_Prix";
            this.Lb_Prix.Size = new System.Drawing.Size(30, 13);
            this.Lb_Prix.TabIndex = 9;
            this.Lb_Prix.Text = "Prix :";
            // 
            // Tb_Prix
            // 
            this.Tb_Prix.Location = new System.Drawing.Point(265, 245);
            this.Tb_Prix.Name = "Tb_Prix";
            this.Tb_Prix.Size = new System.Drawing.Size(120, 20);
            this.Tb_Prix.TabIndex = 10;
            // 
            // Lb_Places
            // 
            this.Lb_Places.AutoSize = true;
            this.Lb_Places.Location = new System.Drawing.Point(171, 297);
            this.Lb_Places.Name = "Lb_Places";
            this.Lb_Places.Size = new System.Drawing.Size(45, 13);
            this.Lb_Places.TabIndex = 11;
            this.Lb_Places.Text = "Places :";
            // 
            // Tb_Places
            // 
            this.Tb_Places.Location = new System.Drawing.Point(265, 290);
            this.Tb_Places.Name = "Tb_Places";
            this.Tb_Places.Size = new System.Drawing.Size(120, 20);
            this.Tb_Places.TabIndex = 12;
            // 
            // Btn_Annuler
            // 
            this.Btn_Annuler.Location = new System.Drawing.Point(189, 340);
            this.Btn_Annuler.Name = "Btn_Annuler";
            this.Btn_Annuler.Size = new System.Drawing.Size(75, 23);
            this.Btn_Annuler.TabIndex = 13;
            this.Btn_Annuler.Text = "Annuler";
            this.Btn_Annuler.UseVisualStyleBackColor = true;
            this.Btn_Annuler.Click += new System.EventHandler(this.Btn_Annuler_Click);
            // 
            // Btn_Ajouter
            // 
            this.Btn_Ajouter.Location = new System.Drawing.Point(311, 340);
            this.Btn_Ajouter.Name = "Btn_Ajouter";
            this.Btn_Ajouter.Size = new System.Drawing.Size(75, 23);
            this.Btn_Ajouter.TabIndex = 14;
            this.Btn_Ajouter.Text = "Ajouter";
            this.Btn_Ajouter.UseVisualStyleBackColor = true;
            this.Btn_Ajouter.Click += new System.EventHandler(this.Btn_Ajouter_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "dddd dd MMMM yyyy HH:mm:ss";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(264, 111);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(229, 20);
            this.dateTimePicker2.TabIndex = 15;
            // 
            // Fm_Add_Vols
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 375);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.Btn_Ajouter);
            this.Controls.Add(this.Btn_Annuler);
            this.Controls.Add(this.Tb_Places);
            this.Controls.Add(this.Lb_Places);
            this.Controls.Add(this.Tb_Prix);
            this.Controls.Add(this.Lb_Prix);
            this.Controls.Add(this.Cb_arrivee);
            this.Controls.Add(this.Lb_Lieu_Arrivee);
            this.Controls.Add(this.Cb_Depart);
            this.Controls.Add(this.Lb_Lieu_Depart);
            this.Controls.Add(this.Lb_Dh_Arrivee);
            this.Controls.Add(this.Lb_Dh_Depart);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Lb_New_Vol);
            this.Name = "Fm_Add_Vols";
            this.Text = "Ajout d\'un vol";
            this.Load += new System.EventHandler(this.Fm_Add_Vols_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lb_New_Vol;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label Lb_Dh_Depart;
        private System.Windows.Forms.Label Lb_Dh_Arrivee;
        private System.Windows.Forms.Label Lb_Lieu_Depart;
        private System.Windows.Forms.ComboBox Cb_Depart;
        private System.Windows.Forms.Label Lb_Lieu_Arrivee;
        private System.Windows.Forms.ComboBox Cb_arrivee;
        private System.Windows.Forms.Label Lb_Prix;
        private System.Windows.Forms.TextBox Tb_Prix;
        private System.Windows.Forms.Label Lb_Places;
        private System.Windows.Forms.TextBox Tb_Places;
        private System.Windows.Forms.Button Btn_Annuler;
        private System.Windows.Forms.Button Btn_Ajouter;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
    }
}