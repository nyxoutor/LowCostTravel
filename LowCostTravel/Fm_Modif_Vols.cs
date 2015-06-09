using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace LowCostTravel
{
    public partial class Fm_Modif__Vols : Form
    {
        private SoldVolEntities bd;
        private vols volModif;
        public Fm_Modif__Vols(SoldVolEntities p_bd, vols vol)
        {
            InitializeComponent();
            bd = p_bd;
            volModif = vol;
            dateTimePicker1.Text = Convert.ToString(volModif.depart_vols);
            dateTimePicker2.Text = Convert.ToString(volModif.arrivee_vols);
            Tb_Places.Text = Convert.ToString(volModif.places_vols);
            Tb_Prix.Text = Convert.ToString(volModif.prix_vols);

        }

        private void Fm_Modif__Vols_Load(object sender, EventArgs e)
        {
            Cb_Depart.DataSource = bd.aeroports.ToList();
            Cb_Depart.DisplayMember = "ville_aero";
            Cb_Depart.ValueMember = "id_aero";
            Cb_Arrivee.DataSource = bd.aeroports.ToList();
            Cb_Arrivee.DisplayMember = "ville_aero";
            Cb_Arrivee.ValueMember = "id_aero";

            //Cb_Depart.SelectedItem = volModif.id_aero_depart;
            int index = volModif.id_aero_depart;
            Cb_Depart.SelectedIndex = index-1;
            int index2 = volModif.id_aero_arriver;
            Cb_Arrivee.SelectedIndex = index2 - 1;
        }

        private void Annuler_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Bt_Modifier_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(dateTimePicker1.Text) || string.IsNullOrEmpty(dateTimePicker2.Text) || string.IsNullOrEmpty(Tb_Prix.Text) || string.IsNullOrEmpty(Tb_Places.Text))
            {
                MessageBox.Show("Veuillez remplir tout les champs.");
            }
            else
            {
                volModif.depart_vols = Convert.ToDateTime(dateTimePicker1.Text);
                volModif.arrivee_vols = Convert.ToDateTime(dateTimePicker2.Text);
                volModif.id_aero_depart = Convert.ToInt32(Cb_Depart.SelectedValue);
                volModif.id_aero_arriver = Convert.ToInt32(Cb_Arrivee.SelectedValue);
                volModif.prix_vols = Convert.ToInt32(Tb_Prix.Text);
                

                int places = Convert.ToInt32(Tb_Places.Text);
                int diff = volModif.places_vols - places;


                volModif.places_vols = Convert.ToInt32(Tb_Places.Text);
                bd.Entry(volModif).State = EntityState.Modified;
                bd.SaveChanges();


                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = "server=mysql.montpellier.epsi.fr;user id=tony.roux;password=epsi123CBY;allowuservariables=True;allowzerodatetime=True;port=5206;persistsecurityinfo=True;database=LowCostTravel";
                MySqlCommand cmd = new MySqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "egalise_place";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add("idVolAdd", MySqlDbType.Int32).Value = volModif.id_vols;
                cmd.Parameters.Add("placesAdd", MySqlDbType.Int32).Value = diff;
                cmd.ExecuteNonQuery();
                con.Close();

                System.Data.Objects.ObjectContext context = ((System.Data.Entity.Infrastructure.IObjectContextAdapter)bd).ObjectContext;
                context.Refresh(System.Data.Objects.RefreshMode.StoreWins, bd.vols);

                this.Hide();
            }

        }
    }
}

