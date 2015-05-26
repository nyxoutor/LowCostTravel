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

        }

        private void Fm_Vols_Load(object sender, EventArgs e)
        {
            //volsBindingSource.DataSource = bd.vols.d
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
