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
    public partial class Fm_Add_Clients : Form
    {
        private SoldVolEntity bd;
        public Fm_Add_Clients(SoldVolEntity p_bd)
        {
            InitializeComponent();
            bd = p_bd;
        }

        private void Fm_Add_Clients_Load(object sender, EventArgs e)
        {

        }

        private void Bt_Annuler_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Bt_Ajouter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Tb_Nom.Text) || string.IsNullOrEmpty(Tb_Prenom.Text) || string.IsNullOrEmpty(Tb_Adresse.Text) || string.IsNullOrEmpty(Tb_Cp.Text) || string.IsNullOrEmpty(Tb_Ville.Text) || string.IsNullOrEmpty(Tb_Mail.Text) || string.IsNullOrEmpty(Tb_Tel.Text))
            {
                MessageBox.Show("Veuillez remplir tous les champs.");
            }
            else
            {
                clients client = new clients();
                client.nom_clients = Tb_Nom.Text;
                client.prenom_clients = Tb_Prenom.Text;
                client.adresse_clients = Tb_Adresse.Text;
                client.cp_clients = Tb_Cp.Text;
                client.ville_clients = Tb_Ville.Text;
                client.tel_clients = Tb_Tel.Text;
                client.mail_clients = Tb_Mail.Text;
                bd.clients.Add(client);
                bd.SaveChanges();
                this.Hide();
            }
        }
    }
}
