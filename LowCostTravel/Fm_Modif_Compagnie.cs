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
    public partial class Fm_Modif_Compagnie : Form
    {
        private SoldVolEntity bd;
        private compagnies compModif;
        public Fm_Modif_Compagnie(SoldVolEntity p_bd, compagnies comp)
        {
            InitializeComponent();
            bd = p_bd;
            compModif = comp;
            Tb_Id.Text = Convert.ToString(compModif.id_comp);
            Tb_Nom.Text = compModif.nom_comp;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Bt_Annuler_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Bt_Confirmer_Click(object sender, EventArgs e)
        {
            compModif.nom_comp = Tb_Nom.Text;
            //aeroports fly = bd.aeroports.Find(aeroModifier.id_aero);
            bd.Entry(compModif).State = EntityState.Modified;
            bd.SaveChanges();
            this.Hide();
        }

        private void Fm_Modif_Compagnie_Load(object sender, EventArgs e)
        {

        }
    }
}
