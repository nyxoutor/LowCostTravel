using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace LowCostTravel
{
    public partial class Fm_Add_Vols : Form
    {
        private SoldVolEntities bd;
        public Fm_Add_Vols(SoldVolEntities p_bd)
        {
            InitializeComponent();
            bd = p_bd;
        }

        private void Fm_Add_Vols_Load(object sender, EventArgs e)
        {
            /*var aeroports = (from a in bd.aeroports
                             select a.ville_aero).Distinct();*/
            Cb_Depart.DataSource = bd.aeroports.ToList();
            Cb_Depart.DisplayMember = "ville_aero";
            Cb_Depart.ValueMember = "id_aero";
            Cb_arrivee.DataSource = bd.aeroports.ToList();
            Cb_arrivee.DisplayMember = "ville_aero";
            Cb_arrivee.ValueMember = "id_aero";
        }

        private void Btn_Annuler_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Btn_Ajouter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(dateTimePicker1.Text) || string.IsNullOrEmpty(dateTimePicker2.Text) || string.IsNullOrEmpty(Tb_Prix.Text) || string.IsNullOrEmpty(Tb_Places.Text))
            {
                MessageBox.Show("Veuillez remplir tout les champs.");
            }
            else
            {
                vols vol = new vols();
                vol.depart_vols = Convert.ToDateTime(dateTimePicker1.Text);
                vol.arrivee_vols = Convert.ToDateTime(dateTimePicker2.Text);
                vol.id_aero_depart = Convert.ToInt32(Cb_Depart.SelectedValue);
                vol.id_aero_arriver = Convert.ToInt32(Cb_arrivee.SelectedValue);
                vol.prix_vols = Convert.ToInt32(Tb_Prix.Text);
                vol.places_vols = Convert.ToInt32(Tb_Places.Text);
                vol.places_dispo_vols = Convert.ToInt32(Tb_Places.Text);
                bd.vols.Add(vol);
                bd.SaveChanges();
                this.Hide();
            }
        }
    }
}
