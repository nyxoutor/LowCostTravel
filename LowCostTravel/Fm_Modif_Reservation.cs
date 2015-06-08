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
                Cb_Etat.SelectedIndex = 1;
            }
            else if (resaModif.etat_reservation == "En attente")
            {
                Cb_Etat.SelectedIndex = 2;
            }
            else if (resaModif.etat_reservation == "Confirmée")
            {
                Cb_Etat.SelectedIndex = 3;
            }
        }
    }
}
