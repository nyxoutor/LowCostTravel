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
            //reservation resaModif = bd.reservation.Find(id, id2, date);
            reservation resa = new reservation();

            try
            {
                 resa = bd.reservation.Where(r => r.id_clients == id && r.id_vols == id2 && r.date_reservation.Equals(date)).Single();
            }
            catch(Exception ex)
            {

            }
            Fm_Modif_Reservation resaModifier = new Fm_Modif_Reservation(bd, resa);
            resaModifier.ShowDialog();
            reservationBindingSource.DataSource = bd.reservation.ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Bt_Supprimer_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            int id2 = Convert.ToInt32(dataGridView1.CurrentRow.Cells[3].Value);
            DateTime date = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[7].Value);
            //reservation resaModif = bd.reservation.Find(id, id2, date);
            reservation resa = new reservation();

            try
            {
                resa = bd.reservation.Where(r => r.id_clients == id && r.id_vols == id2 && r.date_reservation.Equals(date)).Single();
            }
            catch (Exception ex)
            {

            }
            bd.reservation.Remove(resa);
            bd.SaveChanges();
            reservationBindingSource.DataSource = bd.reservation.ToList();
        }

        private void Bt_Debut_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows[0].Selected = true;
            dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[0];
        }

        private void Bt_Precedent_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                if (index > 0 && index <= dataGridView1.Rows.Count)
                {
                    dataGridView1.Rows[index - 1].Selected = true;
                    dataGridView1.CurrentCell = dataGridView1.Rows[index - 1].Cells[0];
                }
            }
        }

        private void Bt_Suivant_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                if (index >= 0 && index < dataGridView1.Rows.Count)
                {
                    dataGridView1.Rows[index + 1].Selected = true;
                    dataGridView1.CurrentCell = dataGridView1.Rows[index + 1].Cells[0];

                }
            }
        }

        private void Bt_Fin_Click(object sender, EventArgs e)
        {

        }

        
    }
}
