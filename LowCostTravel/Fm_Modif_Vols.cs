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
    public partial class Fm_Modif__Vols : Form
    {
        private SoldVol bd;
        private vols volModif;
        public Fm_Modif__Vols(SoldVol p_bd, vols vol)
        {
            InitializeComponent();
            bd = p_bd;
            volModif = vol;
            dateTimePicker1.Text = Convert.ToString(volModif.depart_vols);
            dateTimePicker2.Text = Convert.ToString(volModif.arrivee_vols);
            Tb_Places.Text = Convert.ToString(volModif.places_vols);
            Tb_Prix.Text = Convert.ToString(volModif.prix_vols);

        }

        private void Fm_Modif__Vols_Load(object sender, EventArgs e)
        {
            Cb_Depart.DataSource = bd.aeroports.ToList();
            Cb_Depart.DisplayMember = "ville_aero";
            Cb_Depart.ValueMember = "id_aero";
            Cb_Arrivee.DataSource = bd.aeroports.ToList();
            Cb_Arrivee.DisplayMember = "ville_aero";
            Cb_Arrivee.ValueMember = "id_aero";

            //Cb_Depart.SelectedItem = volModif.id_aero_depart;
            int index = volModif.id_aero_depart;
            Cb_Depart.SelectedIndex = index-1;
            int index2 = volModif.id_aero_arriver;
            Cb_Arrivee.SelectedIndex = index2 - 1;
        }

        private void Annuler_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Bt_Modifier_Click(object sender, EventArgs e)
        {
            volModif.depart_vols = Convert.ToDateTime(dateTimePicker1.Text);
            volModif.arrivee_vols = Convert.ToDateTime(dateTimePicker2.Text);
            volModif.id_aero_depart = Convert.ToInt32(Cb_Depart.SelectedValue);
            volModif.id_aero_arriver = Convert.ToInt32(Cb_Arrivee.SelectedValue);
            volModif.prix_vols = Convert.ToInt32(Tb_Prix.Text);
            volModif.places_vols = Convert.ToInt32(Tb_Places.Text);
            volModif.places_dispo_vols = Convert.ToInt32(Tb_Places.Text);
            bd.Entry(volModif).State = EntityState.Modified;
            bd.SaveChanges();
            
            this.Hide();

        }
    }
}
