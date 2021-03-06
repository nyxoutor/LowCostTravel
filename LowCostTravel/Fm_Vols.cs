﻿using System;
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
    public partial class Fm_Vols : Form
    {
        private SoldVolEntity bd;
        public Fm_Vols(SoldVolEntity p_bd)
        {
            InitializeComponent();
            bd = p_bd;
            volsBindingSource.DataSource = bd.vols.ToList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.Rows.Count;
            dataGridView1.Rows[index - 1].Selected = true;
            dataGridView1.CurrentCell = dataGridView1.Rows[index-1].Cells[0];
        }

        private void Fm_Vols_Load(object sender, EventArgs e)
        {
            //volsBindingSource.DataSource = bd.vols.d
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Btn_Debut_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows[0].Selected = true;
            dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[0];
        }

        private void Btn_Precedent_Click(object sender, EventArgs e)
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

        private void Btn_Suivant_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                if (index >= 0 && index < dataGridView1.Rows.Count-1)
                {
                    dataGridView1.Rows[index + 1].Selected = true;
                    dataGridView1.CurrentCell = dataGridView1.Rows[index + 1].Cells[0];

                }
            }
        }

        private void Btn_Supprimer_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
            try
            {
                vols volToDelete = bd.vols.Find(id);
                bd.vols.Remove(volToDelete);
                bd.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Impossible de supprimer ce vol car il existe des réservations sur ce vol.");
            }

            volsBindingSource.DataSource = bd.vols.ToList();
        }

        private void Btn_Ajouter_Click(object sender, EventArgs e)
        {
            Fm_Add_Vols addVols = new Fm_Add_Vols(bd);
            addVols.ShowDialog();
            volsBindingSource.DataSource = bd.vols.ToList();
        }

        private void Btn_Modifier_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
            vols volModif = bd.vols.Find(id);
            Fm_Modif__Vols volModifier = new Fm_Modif__Vols(bd, volModif);
            volModifier.ShowDialog();
            volsBindingSource.DataSource = bd.vols.ToList();
        }

        private void Btn_Aeroports_Click(object sender, EventArgs e)
        {
            Fm_Aeroports aero = new Fm_Aeroports(bd);
            aero.Show();
            this.Hide();
        }

        private void Btn_Clients_Click(object sender, EventArgs e)
        {
            Fm_Clients clients = new Fm_Clients(bd);
            clients.Show();
            this.Hide();
        }

        private void Btn_Reservations_Click(object sender, EventArgs e)
        {
            Fm_Reservations resas = new Fm_Reservations(bd);
            resas.Show();
            this.Hide();
        }
    }
}
