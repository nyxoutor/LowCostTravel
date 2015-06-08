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
    public partial class Fm_Add_Compagnie : Form
    {
        private SoldVolEntity bd;
        public Fm_Add_Compagnie(SoldVolEntity p_bd)
        {
            InitializeComponent();
            bd = p_bd;
        }

        private void Fm_Add_Compagnie_Load(object sender, EventArgs e)
        {
            
        }

        private void Bt_Annuler_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Bt_Ajouter_Click(object sender, EventArgs e)
        {
            compagnies compAdd = new compagnies();
            compAdd.nom_comp = Tb_Nom.Text;
            bd.compagnies.Add(compAdd);
            bd.SaveChanges();
            this.Hide();
        }
    }
}
