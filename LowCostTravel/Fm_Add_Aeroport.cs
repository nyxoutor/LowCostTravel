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
    public partial class Fm_Add_Aeroport : Form
    {
        private VolsModele bd;
        public Fm_Add_Aeroport(VolsModele p_bd)
        {
            InitializeComponent();
            bd = p_bd;
            
        }

        private void Btn_Annuler_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Bt_Ajouter_Click(object sender, EventArgs e)
        {
            aeroports aero = new aeroports();
            aero.ville_aero = Tb_Ville.Text;
            bd.aeroports.Add(aero);
            bd.SaveChanges();
            this.Hide();
        }

        private void Fm_Add_Aeroport_Load(object sender, EventArgs e)
        {

        }
    }
}
