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
    public partial class Fm_Connexion : Form
    {
        public Fm_Connexion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Fm_Menu menu = new Fm_Menu();
            menu.Show();
            this.Hide();
        }

        private void Fm_Connexion_Load(object sender, EventArgs e)
        {

        }

        private void Bt_New_Employe_Click(object sender, EventArgs e)
        {
            Fm_Add_Employe employe = new Fm_Add_Employe();
            employe.Show();
        }
        
    }
}
