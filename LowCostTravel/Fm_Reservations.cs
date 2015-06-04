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
    public partial class Fm_Reservations : Form
    {
        private SoldVolEntities bd;
        public Fm_Reservations(SoldVolEntities p_bd)
        {
            InitializeComponent();
            bd = p_bd;
            reservationBindingSource.DataSource = bd.reservation.ToList();
        }

        private void Fm_Reservations_Load(object sender, EventArgs e)
        {

        }

        private void Bt_Ajout_Click(object sender, EventArgs e)
        {
            Fm_Add_Reservation addResa = new Fm_Add_Reservation(bd);
            addResa.ShowDialog();
            reservationBindingSource.DataSource = bd.reservation.ToList();
        }

        
    }
}
