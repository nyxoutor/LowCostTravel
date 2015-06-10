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
    public partial class Fm_Add_Reservation : Form
    {
        private SoldVolEntity bd;
        public Fm_Add_Reservation(SoldVolEntity p_bd)
        {
            InitializeComponent();
            bd = p_bd;
        }

        private void Fm_Add_Reservation_Load(object sender, EventArgs e)
        {
            CB_Clients.DataSource = bd.clients.ToList();
            CB_Clients.DisplayMember = "nomComplet";
            CB_Clients.ValueMember = "id_clients";
            CB_Vols.DataSource = bd.vols.ToList();
            CB_Vols.DisplayMember = "choixVol";
            CB_Vols.ValueMember = "id_vols";
            

        }

        private void Bt_Annuler_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Bt_Confirmer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TB_Places.Text))
            {
                MessageBox.Show("Veuillez remplir tout les champs.");
            }else{
                reservation resaAdd = new reservation();
                resaAdd.id_vols = Convert.ToInt32(CB_Vols.SelectedValue);
                resaAdd.id_clients = Convert.ToInt32(CB_Clients.SelectedValue);
                resaAdd.etat_reservation = "En attente";
                resaAdd.date_reservation = DateTime.Now;
                resaAdd.place_reservation = Convert.ToInt32(TB_Places.Text);


                vols vol = bd.vols.Find(resaAdd.id_vols);

                if (vol.places_dispo_vols < resaAdd.place_reservation)
                {
                    MessageBox.Show("Pas assez de places disponibles sur ce vol.");
                }
                else
                {

                    bd.reservation.Add(resaAdd);
                    bd.SaveChanges();
                    this.Hide();
                }
            }

        }
    }
}
