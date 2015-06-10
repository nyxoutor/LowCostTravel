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
    public partial class Fm_Modif_Clients : Form
    {
        private SoldVolEntity bd;
        private clients clientModif;
        public Fm_Modif_Clients(SoldVolEntity p_bd, clients client)
        {
            InitializeComponent();
            bd = p_bd;
            clientModif = client;
            Tb_Nom.Text = clientModif.nom_clients;
            Tb_Prenom.Text = clientModif.prenom_clients;
            Tb_Adresse.Text = clientModif.adresse_clients;
            Tb_Cp.Text = clientModif.cp_clients;
            Tb_Ville.Text = clientModif.ville_clients;
            Tb_Tel.Text = clientModif.tel_clients;
            Tb_Mail.Text = clientModif.mail_clients;

        }

        private void Fm_Modif_Clients_Load(object sender, EventArgs e)
        {

        }

        private void Bt_Annuler_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Bt_Modifier_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Tb_Nom.Text) || string.IsNullOrEmpty(Tb_Prenom.Text) || string.IsNullOrEmpty(Tb_Adresse.Text) || string.IsNullOrEmpty(Tb_Cp.Text) || string.IsNullOrEmpty(Tb_Ville.Text) || string.IsNullOrEmpty(Tb_Mail.Text) || string.IsNullOrEmpty(Tb_Tel.Text))
            {
                MessageBox.Show("Veuillez remplir tous les champs.");
            }
            else
            {
                clientModif.nom_clients = Tb_Nom.Text;
                clientModif.prenom_clients = Tb_Prenom.Text;
                clientModif.adresse_clients = Tb_Adresse.Text;
                clientModif.cp_clients = Tb_Cp.Text;
                clientModif.ville_clients = Tb_Ville.Text;
                clientModif.mail_clients = Tb_Mail.Text;
                clientModif.tel_clients = Tb_Tel.Text;
                bd.Entry(clientModif).State = EntityState.Modified;
                bd.SaveChanges();

                this.Hide();
            }
        }
    }
}
