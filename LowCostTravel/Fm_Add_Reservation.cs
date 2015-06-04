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
        private SoldVolEntities bd;
        public Fm_Add_Reservation(SoldVolEntities p_bd)
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
            reservation resaAdd = new reservation();

        }
    }
}
