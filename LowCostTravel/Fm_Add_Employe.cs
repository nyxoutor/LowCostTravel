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
    public partial class Fm_Add_Employe : Form
    {
        private SoldVol bd;
        public Fm_Add_Employe()
        {
            InitializeComponent();
            bd = new SoldVol();
        }

        private void Fm_Add_Employe_Load(object sender, EventArgs e)
        {

        }

        private void Bt_Annuler_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Bt_Confirmer_Click(object sender, EventArgs e)
        {
            employe employeAdd = new employe();
            employeAdd.nom = Tb_Nom.Text;
            employeAdd.prenom = Tb_Prenom.Text;
            employeAdd.login = Tb_Login.Text;
            employeAdd.password = "test";
            // a continuer pour crypter le mdp

            
        }
    }
}
