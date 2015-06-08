using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LowCostTravel
{
    public partial class Fm_Compagnie : Form
    {
        private SoldVolEntity bd;
        public Fm_Compagnie(SoldVolEntity p_bd)
        {
            InitializeComponent();
            bd = p_bd;
            compagniesBindingSource.DataSource = bd.compagnies.ToList();
        }

        private void Fm_Compagnie_Load(object sender, EventArgs e)
        {

        }

        private void Bt_Ajouter_Click(object sender, EventArgs e)
        {
            Fm_Add_Compagnie addComp = new Fm_Add_Compagnie(bd);
            addComp.ShowDialog();
            compagniesBindingSource.DataSource = bd.compagnies.ToList();
        }

        private void Bt_Supprimer_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
            compagnies compToDelete = bd.compagnies.Find(id);
            bd.compagnies.Remove(compToDelete);
            bd.SaveChanges();


            compagniesBindingSource.DataSource = bd.compagnies.ToList();
        }

        private void Bt_Modifier_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
            compagnies compModifier = bd.compagnies.Find(id);
            Fm_Modif_Compagnie modifComp = new Fm_Modif_Compagnie(bd, compModifier);
            modifComp.ShowDialog();
            compagniesBindingSource.DataSource = bd.compagnies.ToList();
        }
    }
}
