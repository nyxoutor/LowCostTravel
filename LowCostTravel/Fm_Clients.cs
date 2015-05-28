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
    public partial class Fm_Clients : Form
    {
        private VolsModele bd;
        public Fm_Clients(VolsModele p_bd)
        {
            InitializeComponent();
            bd = p_bd;
            clientsBindingSource.DataSource = bd.clients.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {

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
            int index = dataGridView1.Rows.Count;
            dataGridView1.Rows[index - 1].Selected = true;
            dataGridView1.CurrentCell = dataGridView1.Rows[index-1].Cells[0];
        }

        private void Bt_Aeroports_Click(object sender, EventArgs e)
        {
            Fm_Aeroports aeroports = new Fm_Aeroports(bd);
            aeroports.Show();
            this.Hide();
        }

        private void Fm_Clients_Load(object sender, EventArgs e)
        {

        }
    }
}
