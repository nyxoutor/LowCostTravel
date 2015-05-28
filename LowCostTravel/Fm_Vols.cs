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
    public partial class Fm_Vols : Form
    {
        private VolsModele bd;
        public Fm_Vols(VolsModele p_bd)
        {
            InitializeComponent();
            bd = p_bd;
            volsBindingSource.DataSource = bd.vols.ToList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.Rows.Count;
            dataGridView1.Rows[index - 2].Selected = true;
            dataGridView1.CurrentCell = dataGridView1.Rows[index-2].Cells[0];
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
                if (index >= 0 && index < dataGridView1.Rows.Count)
                {
                    dataGridView1.Rows[index + 1].Selected = true;
                    dataGridView1.CurrentCell = dataGridView1.Rows[index + 1].Cells[0];

                }
            }
        }

        private void Btn_Supprimer_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
            vols volToDelete = bd.vols.Find(id);
            bd.vols.Remove(volToDelete);
            bd.SaveChanges();


            volsBindingSource.DataSource = bd.vols.ToList();
        }

        private void Btn_Ajouter_Click(object sender, EventArgs e)
        {
            Fm_Add_Vols addVols = new Fm_Add_Vols(bd);
            addVols.ShowDialog();
            volsBindingSource.DataSource = bd.vols.ToList();
        }
    }
}
