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

        private void Bt_Modifier_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            int id2 = Convert.ToInt32(dataGridView1.CurrentRow.Cells[3].Value);
            DateTime date = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[7].Value);
            reservation resaModif = bd.reservation.Find(id, id2, date);
            Fm_Modif_Reservation resaModifier = new Fm_Modif_Reservation(bd, resaModif);
            resaModifier.ShowDialog();
            reservationBindingSource.DataSource = bd.reservation.ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}
