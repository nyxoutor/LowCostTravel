namespace LowCostTravel
{
    partial class Fm_Connexion
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.Lb_Connexion = new System.Windows.Forms.Label();
            this.Lb_Login = new System.Windows.Forms.Label();
            this.TB_Login = new System.Windows.Forms.TextBox();
            this.Lb_Password = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Btn_Connexion = new System.Windows.Forms.Button();
            this.Bt_New_Employe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lb_Connexion
            // 
            this.Lb_Connexion.AutoSize = true;
            this.Lb_Connexion.Location = new System.Drawing.Point(262, 68);
            this.Lb_Connexion.Name = "Lb_Connexion";
            this.Lb_Connexion.Size = new System.Drawing.Size(63, 13);
            this.Lb_Connexion.TabIndex = 0;
            this.Lb_Connexion.Text = "Connexion :";
            // 
            // Lb_Login
            // 
            this.Lb_Login.AutoSize = true;
            this.Lb_Login.Location = new System.Drawing.Point(221, 143);
            this.Lb_Login.Name = "Lb_Login";
            this.Lb_Login.Size = new System.Drawing.Size(39, 13);
            this.Lb_Login.TabIndex = 1;
            this.Lb_Login.Text = "Login :";
            // 
            // TB_Login
            // 
            this.TB_Login.Location = new System.Drawing.Point(316, 140);
            this.TB_Login.Name = "TB_Login";
            this.TB_Login.Size = new System.Drawing.Size(100, 20);
            this.TB_Login.TabIndex = 2;
            // 
            // Lb_Password
            // 
            this.Lb_Password.AutoSize = true;
            this.Lb_Password.Location = new System.Drawing.Point(201, 182);
            this.Lb_Password.Name = "Lb_Password";
            this.Lb_Password.Size = new System.Drawing.Size(59, 13);
            this.Lb_Password.TabIndex = 3;
            this.Lb_Password.Text = "Password :";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(316, 179);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            // 
            // Btn_Connexion
            // 
            this.Btn_Connexion.Location = new System.Drawing.Point(182, 246);
            this.Btn_Connexion.Name = "Btn_Connexion";
            this.Btn_Connexion.Size = new System.Drawing.Size(122, 23);
            this.Btn_Connexion.TabIndex = 5;
            this.Btn_Connexion.Text = "Se Connecter";
            this.Btn_Connexion.UseVisualStyleBackColor = true;
            this.Btn_Connexion.Click += new System.EventHandler(this.button1_Click);
            // 
            // Bt_New_Employe
            // 
            this.Bt_New_Employe.Location = new System.Drawing.Point(341, 246);
            this.Bt_New_Employe.Name = "Bt_New_Employe";
            this.Bt_New_Employe.Size = new System.Drawing.Size(109, 23);
            this.Bt_New_Employe.TabIndex = 6;
            this.Bt_New_Employe.Text = "Nouvel Utilisateur";
            this.Bt_New_Employe.UseVisualStyleBackColor = true;
            this.Bt_New_Employe.Click += new System.EventHandler(this.Bt_New_Employe_Click);
            // 
            // Fm_Connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 335);
            this.Controls.Add(this.Bt_New_Employe);
            this.Controls.Add(this.Btn_Connexion);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Lb_Password);
            this.Controls.Add(this.TB_Login);
            this.Controls.Add(this.Lb_Login);
            this.Controls.Add(this.Lb_Connexion);
            this.Name = "Fm_Connexion";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Fm_Connexion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lb_Connexion;
        private System.Windows.Forms.Label Lb_Login;
        private System.Windows.Forms.TextBox TB_Login;
        private System.Windows.Forms.Label Lb_Password;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Btn_Connexion;
        private System.Windows.Forms.Button Bt_New_Employe;
    }
}

