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
    public partial class Fm_Aeroports : Form
    {
        private SoldVolEntity bd;
        public Fm_Aeroports(SoldVolEntity p_bd)
        {
            InitializeComponent();
            bd = p_bd;
            Bs.DataSource = bd.aeroports.ToList();
            
        }
        //Bouton modifier
        private void button7_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
            aeroports aeroModifier = bd.aeroports.Find(id);
            Fm_Modif_Aeroport modifAeroports = new Fm_Modif_Aeroport(bd, aeroModifier);
            modifAeroports.ShowDialog();
            Bs.DataSource = bd.aeroports.ToList();
            
        }

        private void Fm_Aeroports_Load(object sender, EventArgs e)
        {
        }

        private void Btn_Ajouter_Click(object sender, EventArgs e)
        {
            Fm_Add_Aeroport addAeroports = new Fm_Add_Aeroport(bd);
            addAeroports.ShowDialog();
            Bs.DataSource = bd.aeroports.ToList();
        }

        private void Btn_Supprimer_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
            aeroports aeroToDelete = bd.aeroports.Find(id);
            bd.aeroports.Remove(aeroToDelete);
            bd.SaveChanges();


            Bs.DataSource = bd.aeroports.ToList();
            //dataGridView1.DataSource = MonBindingSource;

            
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

        private void Btn_Debut_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows[0].Selected = true;
            dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[0];
        }

        private void Btn_Fin_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.Rows.Count;
            dataGridView1.Rows[index-1].Selected = true;
            dataGridView1.CurrentCell = dataGridView1.Rows[index-1].Cells[0];
        }

        private void Btn_Clients_Click(object sender, EventArgs e)
        {
            Fm_Clients clients = new Fm_Clients(bd);
            clients.Show();
            this.Hide();
        }

        private void Btn_Vols_Click(object sender, EventArgs e)
        {
            Fm_Vols vols = new Fm_Vols(bd);
            vols.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Btn_Reservations_Click(object sender, EventArgs e)
        {
            Fm_Reservations resas = new Fm_Reservations(bd);
            resas.Show();
            this.Hide();
        }
    }
}
