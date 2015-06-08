namespace LowCostTravel
{
    partial class Fm_Compagnie
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Bt_Ajouter = new System.Windows.Forms.Button();
            this.Bt_Supprimer = new System.Windows.Forms.Button();
            this.Bt_Modifier = new System.Windows.Forms.Button();
            this.idcompDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomcompDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compagniesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compagniesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idcompDataGridViewTextBoxColumn,
            this.nomcompDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.compagniesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(70, 107);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(456, 224);
            this.dataGridView1.TabIndex = 0;
            // 
            // Bt_Ajouter
            // 
            this.Bt_Ajouter.Location = new System.Drawing.Point(100, 424);
            this.Bt_Ajouter.Name = "Bt_Ajouter";
            this.Bt_Ajouter.Size = new System.Drawing.Size(75, 23);
            this.Bt_Ajouter.TabIndex = 1;
            this.Bt_Ajouter.Text = "+";
            this.Bt_Ajouter.UseVisualStyleBackColor = true;
            this.Bt_Ajouter.Click += new System.EventHandler(this.Bt_Ajouter_Click);
            // 
            // Bt_Supprimer
            // 
            this.Bt_Supprimer.Location = new System.Drawing.Point(240, 424);
            this.Bt_Supprimer.Name = "Bt_Supprimer";
            this.Bt_Supprimer.Size = new System.Drawing.Size(75, 23);
            this.Bt_Supprimer.TabIndex = 2;
            this.Bt_Supprimer.Text = "-";
            this.Bt_Supprimer.UseVisualStyleBackColor = true;
            this.Bt_Supprimer.Click += new System.EventHandler(this.Bt_Supprimer_Click);
            // 
            // Bt_Modifier
            // 
            this.Bt_Modifier.Location = new System.Drawing.Point(393, 424);
            this.Bt_Modifier.Name = "Bt_Modifier";
            this.Bt_Modifier.Size = new System.Drawing.Size(75, 23);
            this.Bt_Modifier.TabIndex = 3;
            this.Bt_Modifier.Text = "Modifier";
            this.Bt_Modifier.UseVisualStyleBackColor = true;
            this.Bt_Modifier.Click += new System.EventHandler(this.Bt_Modifier_Click);
            // 
            // idcompDataGridViewTextBoxColumn
            // 
            this.idcompDataGridViewTextBoxColumn.DataPropertyName = "id_comp";
            this.idcompDataGridViewTextBoxColumn.HeaderText = "id_comp";
            this.idcompDataGridViewTextBoxColumn.Name = "idcompDataGridViewTextBoxColumn";
            // 
            // nomcompDataGridViewTextBoxColumn
            // 
            this.nomcompDataGridViewTextBoxColumn.DataPropertyName = "nom_comp";
            this.nomcompDataGridViewTextBoxColumn.HeaderText = "nom_comp";
            this.nomcompDataGridViewTextBoxColumn.Name = "nomcompDataGridViewTextBoxColumn";
            // 
            // compagniesBindingSource
            // 
            this.compagniesBindingSource.DataSource = typeof(LowCostTravel.compagnies);
            // 
            // Fm_Compagnie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 513);
            this.Controls.Add(this.Bt_Modifier);
            this.Controls.Add(this.Bt_Supprimer);
            this.Controls.Add(this.Bt_Ajouter);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Fm_Compagnie";
            this.Text = "Fm_Compagnie";
            this.Load += new System.EventHandler(this.Fm_Compagnie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compagniesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcompDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomcompDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource compagniesBindingSource;
        private System.Windows.Forms.Button Bt_Ajouter;
        private System.Windows.Forms.Button Bt_Supprimer;
        private System.Windows.Forms.Button Bt_Modifier;
    }
}