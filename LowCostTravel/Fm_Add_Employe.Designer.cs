namespace LowCostTravel
{
    partial class Fm_Add_Employe
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
            this.Lb_New_Emp = new System.Windows.Forms.Label();
            this.Lb_nom = new System.Windows.Forms.Label();
            this.Lb_Prenom = new System.Windows.Forms.Label();
            this.Lb_Login = new System.Windows.Forms.Label();
            this.Lb_Password = new System.Windows.Forms.Label();
            this.Tb_Nom = new System.Windows.Forms.TextBox();
            this.Tb_Prenom = new System.Windows.Forms.TextBox();
            this.Tb_Login = new System.Windows.Forms.TextBox();
            this.Tb_Pass = new System.Windows.Forms.TextBox();
            this.Bt_Annuler = new System.Windows.Forms.Button();
            this.Bt_Confirmer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lb_New_Emp
            // 
            this.Lb_New_Emp.AutoSize = true;
            this.Lb_New_Emp.Location = new System.Drawing.Point(209, 57);
            this.Lb_New_Emp.Name = "Lb_New_Emp";
            this.Lb_New_Emp.Size = new System.Drawing.Size(90, 13);
            this.Lb_New_Emp.TabIndex = 0;
            this.Lb_New_Emp.Text = "Nouvel Employé :";
            // 
            // Lb_nom
            // 
            this.Lb_nom.AutoSize = true;
            this.Lb_nom.Location = new System.Drawing.Point(148, 106);
            this.Lb_nom.Name = "Lb_nom";
            this.Lb_nom.Size = new System.Drawing.Size(35, 13);
            this.Lb_nom.TabIndex = 1;
            this.Lb_nom.Text = "Nom :";
            // 
            // Lb_Prenom
            // 
            this.Lb_Prenom.AutoSize = true;
            this.Lb_Prenom.Location = new System.Drawing.Point(134, 143);
            this.Lb_Prenom.Name = "Lb_Prenom";
            this.Lb_Prenom.Size = new System.Drawing.Size(49, 13);
            this.Lb_Prenom.TabIndex = 2;
            this.Lb_Prenom.Text = "Prénom :";
            // 
            // Lb_Login
            // 
            this.Lb_Login.AutoSize = true;
            this.Lb_Login.Location = new System.Drawing.Point(144, 182);
            this.Lb_Login.Name = "Lb_Login";
            this.Lb_Login.Size = new System.Drawing.Size(39, 13);
            this.Lb_Login.TabIndex = 3;
            this.Lb_Login.Text = "Login :";
            // 
            // Lb_Password
            // 
            this.Lb_Password.AutoSize = true;
            this.Lb_Password.Location = new System.Drawing.Point(106, 215);
            this.Lb_Password.Name = "Lb_Password";
            this.Lb_Password.Size = new System.Drawing.Size(77, 13);
            this.Lb_Password.TabIndex = 4;
            this.Lb_Password.Text = "Mot de passe :";
            // 
            // Tb_Nom
            // 
            this.Tb_Nom.Location = new System.Drawing.Point(254, 103);
            this.Tb_Nom.Name = "Tb_Nom";
            this.Tb_Nom.Size = new System.Drawing.Size(100, 20);
            this.Tb_Nom.TabIndex = 5;
            // 
            // Tb_Prenom
            // 
            this.Tb_Prenom.Location = new System.Drawing.Point(254, 140);
            this.Tb_Prenom.Name = "Tb_Prenom";
            this.Tb_Prenom.Size = new System.Drawing.Size(100, 20);
            this.Tb_Prenom.TabIndex = 6;
            // 
            // Tb_Login
            // 
            this.Tb_Login.Location = new System.Drawing.Point(254, 179);
            this.Tb_Login.Name = "Tb_Login";
            this.Tb_Login.Size = new System.Drawing.Size(100, 20);
            this.Tb_Login.TabIndex = 7;
            // 
            // Tb_Pass
            // 
            this.Tb_Pass.Location = new System.Drawing.Point(254, 212);
            this.Tb_Pass.Name = "Tb_Pass";
            this.Tb_Pass.PasswordChar = '*';
            this.Tb_Pass.Size = new System.Drawing.Size(100, 20);
            this.Tb_Pass.TabIndex = 8;
            // 
            // Bt_Annuler
            // 
            this.Bt_Annuler.Location = new System.Drawing.Point(161, 274);
            this.Bt_Annuler.Name = "Bt_Annuler";
            this.Bt_Annuler.Size = new System.Drawing.Size(75, 23);
            this.Bt_Annuler.TabIndex = 9;
            this.Bt_Annuler.Text = "Annuler";
            this.Bt_Annuler.UseVisualStyleBackColor = true;
            this.Bt_Annuler.Click += new System.EventHandler(this.Bt_Annuler_Click);
            // 
            // Bt_Confirmer
            // 
            this.Bt_Confirmer.Location = new System.Drawing.Point(269, 274);
            this.Bt_Confirmer.Name = "Bt_Confirmer";
            this.Bt_Confirmer.Size = new System.Drawing.Size(75, 23);
            this.Bt_Confirmer.TabIndex = 10;
            this.Bt_Confirmer.Text = "Confirmer";
            this.Bt_Confirmer.UseVisualStyleBackColor = true;
            this.Bt_Confirmer.Click += new System.EventHandler(this.Bt_Confirmer_Click);
            // 
            // Fm_Add_Employe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 359);
            this.Controls.Add(this.Bt_Confirmer);
            this.Controls.Add(this.Bt_Annuler);
            this.Controls.Add(this.Tb_Pass);
            this.Controls.Add(this.Tb_Login);
            this.Controls.Add(this.Tb_Prenom);
            this.Controls.Add(this.Tb_Nom);
            this.Controls.Add(this.Lb_Password);
            this.Controls.Add(this.Lb_Login);
            this.Controls.Add(this.Lb_Prenom);
            this.Controls.Add(this.Lb_nom);
            this.Controls.Add(this.Lb_New_Emp);
            this.Name = "Fm_Add_Employe";
            this.Text = "Création d\'un nouvel employé";
            this.Load += new System.EventHandler(this.Fm_Add_Employe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lb_New_Emp;
        private System.Windows.Forms.Label Lb_nom;
        private System.Windows.Forms.Label Lb_Prenom;
        private System.Windows.Forms.Label Lb_Login;
        private System.Windows.Forms.Label Lb_Password;
        private System.Windows.Forms.TextBox Tb_Nom;
        private System.Windows.Forms.TextBox Tb_Prenom;
        private System.Windows.Forms.TextBox Tb_Login;
        private System.Windows.Forms.TextBox Tb_Pass;
        private System.Windows.Forms.Button Bt_Annuler;
        private System.Windows.Forms.Button Bt_Confirmer;
    }
}