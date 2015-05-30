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
    public partial class Fm_Menu : Form
    {
        private SoldVol bd;
        public Fm_Menu()
        {
            InitializeComponent();
            bd = new SoldVol();
        }

        private void Btn_Aeroports_Click(object sender, EventArgs e)
        {
            Fm_Aeroports aeroports = new Fm_Aeroports(bd);
            aeroports.Show();
            this.Hide();
        }

        private void Btn_Vols_Click(object sender, EventArgs e)
        {
            Fm_Vols vols = new Fm_Vols(bd);
            vols.Show();
            this.Hide();
        }

        private void Fm_Menu_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Clients_Click(object sender, EventArgs e)
        {
            Fm_Clients clients = new Fm_Clients(bd);
            clients.Show();
            this.Hide();
        }

        private void Btn_Reservations_Click(object sender, EventArgs e)
        {
            Fm_Reservations reservations = new Fm_Reservations(bd);
            reservations.Show();
            this.Hide();
        }
    }
}
