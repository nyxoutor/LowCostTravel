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
    public partial class Fm_Modif_Aeroport : Form
    {
        private VolsModele bd;
        private aeroports aeroModifier;
        public Fm_Modif_Aeroport(VolsModele p_bd, aeroports aero)
        {
            InitializeComponent();
            bd = p_bd;
            aeroModifier = aero;
            Tb_Id.Text = Convert.ToString(aeroModifier.id_aero);
            Tb_Ville.Text = aeroModifier.ville_aero;
            
        }

        private void Bt_Annuler_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Bt_Modifier_Click(object sender, EventArgs e)
        {
            aeroModifier.ville_aero = Tb_Ville.Text;
            //aeroports fly = bd.aeroports.Find(aeroModifier.id_aero);
            bd.Entry(aeroModifier).State = EntityState.Modified;
            bd.SaveChanges();
            this.Hide();
        }

        private void Fm_Modif_Aeroport_Load(object sender, EventArgs e)
        {

        }

        private void aeroportsBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }
    }
}
