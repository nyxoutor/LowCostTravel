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
        private SoldVolEntities bd;
        public Fm_Add_Aeroport(SoldVolEntities p_bd)
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
            if (string.IsNullOrEmpty(Tb_Ville.Text))
            {
                MessageBox.Show("Veuillez remplir tout les champs");
            }
            else
            {
                aeroports aero = new aeroports();
                aero.ville_aero = Tb_Ville.Text;
                bd.aeroports.Add(aero);
                bd.SaveChanges();
                this.Hide();
            }
        }

        private void Fm_Add_Aeroport_Load(object sender, EventArgs e)
        {
            
        }
    }
}
