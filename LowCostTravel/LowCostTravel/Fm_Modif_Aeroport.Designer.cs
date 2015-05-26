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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fm_Modif_Aeroport));
            System.Windows.Forms.Label Lb_IdAero;
            System.Windows.Forms.Label Lb_VilleAero;
            this.aeroportsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.aeroportsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.Tb_Id = new System.Windows.Forms.TextBox();
            this.Tb_Ville = new System.Windows.Forms.TextBox();
            this.Lb_Modifier = new System.Windows.Forms.Label();
            this.Bt_Annuler = new System.Windows.Forms.Button();
            this.Bt_Modifier = new System.Windows.Forms.Button();
            this.aeroportsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            Lb_IdAero = new System.Windows.Forms.Label();
            Lb_VilleAero = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aeroportsBindingNavigator)).BeginInit();
            this.aeroportsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aeroportsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // aeroportsBindingNavigator
            // 
            this.aeroportsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.aeroportsBindingNavigator.BindingSource = this.aeroportsBindingSource;
            this.aeroportsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.aeroportsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.aeroportsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.aeroportsBindingNavigatorSaveItem});
            this.aeroportsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.aeroportsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.aeroportsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.aeroportsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.aeroportsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.aeroportsBindingNavigator.Name = "aeroportsBindingNavigator";
            this.aeroportsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.aeroportsBindingNavigator.Size = new System.Drawing.Size(386, 25);
            this.aeroportsBindingNavigator.TabIndex = 0;
            this.aeroportsBindingNavigator.Text = "bindingNavigator1";
            this.aeroportsBindingNavigator.RefreshItems += new System.EventHandler(this.aeroportsBindingNavigator_RefreshItems);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Placer en premier";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Déplacer vers le haut";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Position actuelle";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Nombre total d\'éléments";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Déplacer vers le bas";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Placer en dernier";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Ajouter nouveau";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Supprimer";
            // 
            // aeroportsBindingNavigatorSaveItem
            // 
            this.aeroportsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.aeroportsBindingNavigatorSaveItem.Enabled = false;
            this.aeroportsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("aeroportsBindingNavigatorSaveItem.Image")));
            this.aeroportsBindingNavigatorSaveItem.Name = "aeroportsBindingNavigatorSaveItem";
            this.aeroportsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.aeroportsBindingNavigatorSaveItem.Text = "Enregistrer les données";
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
            // Tb_Id
            // 
            this.Tb_Id.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aeroportsBindingSource, "id_aero", true));
            this.Tb_Id.Location = new System.Drawing.Point(154, 110);
            this.Tb_Id.Name = "Tb_Id";
            this.Tb_Id.ReadOnly = true;
            this.Tb_Id.Size = new System.Drawing.Size(100, 20);
            this.Tb_Id.TabIndex = 2;
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
            // aeroportsBindingSource
            // 
            this.aeroportsBindingSource.DataSource = typeof(LowCostTravel.aeroports);
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
            this.Controls.Add(this.aeroportsBindingNavigator);
            this.Name = "Fm_Modif_Aeroport";
            this.Text = "Fm_Modif_Aeroport";
            this.Load += new System.EventHandler(this.Fm_Modif_Aeroport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aeroportsBindingNavigator)).EndInit();
            this.aeroportsBindingNavigator.ResumeLayout(false);
            this.aeroportsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aeroportsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource aeroportsBindingSource;
        private System.Windows.Forms.BindingNavigator aeroportsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton aeroportsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox Tb_Id;
        private System.Windows.Forms.TextBox Tb_Ville;
        private System.Windows.Forms.Label Lb_Modifier;
        private System.Windows.Forms.Button Bt_Annuler;
        private System.Windows.Forms.Button Bt_Modifier;
    }
}