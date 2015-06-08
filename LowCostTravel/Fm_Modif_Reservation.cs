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
    public partial class Fm_Modif_Reservation : Form
    {
        private SoldVolEntities bd;
        private reservation resaModif;
        public Fm_Modif_Reservation(SoldVolEntities p_bd, reservation resa)
        {
            InitializeComponent();
            bd = p_bd;
            resaModif = resa;
        }

        private void Fm_Modif_Reservation_Load(object sender, EventArgs e)
        {
            Cb_Client.DataSource = bd.clients.ToList();
            Cb_Client.DisplayMember = "nomComplet";
            Cb_Client.ValueMember = "id_clients";
            Cb_Vol.DataSource = bd.vols.ToList();
            Cb_Vol.DisplayMember = "choixVol";
            Cb_Vol.ValueMember = "id_vols";

            int index = resaModif.id_clients;
            Cb_Client.SelectedIndex = index - 1;
            int index2 = resaModif.id_vols;
            Cb_Vol.SelectedIndex = index2 - 1;

            if (resaModif.etat_reservation == "Annulée")
            {
                Cb_Etat.SelectedItem = "Annulée";
            }
            else if (resaModif.etat_reservation == "En attente")
            {
                Cb_Etat.SelectedItem = "En attente";
            }
            else if (resaModif.etat_reservation == "Confirmée")
            {
                Cb_Etat.SelectedItem = "Confirmée";
            }

            Tb_Place.Text = Convert.ToString(resaModif.place_reservation);

        }

        private void Bt_Annuler_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Bt_Modifier_Click(object sender, EventArgs e)
        {
            
            resaModif.etat_reservation = Convert.ToString(Cb_Etat.SelectedItem);
            resaModif.place_reservation = Convert.ToInt32(Tb_Place.Text);
            bd.Entry(resaModif).State = EntityState.Modified;
            bd.SaveChanges();
            this.Hide();
        }
    }
}
