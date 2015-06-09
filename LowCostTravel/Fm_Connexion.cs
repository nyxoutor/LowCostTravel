using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace LowCostTravel
{
    public partial class Fm_Connexion : Form
    {
        public string Login { get; set; }
        public string Password { get; set; }
        private SoldVolEntities bd;
        public Fm_Connexion()
        {
            InitializeComponent();
            bd = new SoldVolEntities();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Login = TB_Login.Text;
            if (string.IsNullOrEmpty(Login) || string.IsNullOrEmpty(TB_Password.Text))
            {
                MessageBox.Show("Veuillez remplir tous les champs");
                return;
            }

            try
            {
                var user = (from em in bd.employe
                            where em.login.Equals(Login)
                            select em).Single();

                using (MD5 md5Hash = MD5.Create())
                {
                    Password = GetMd5Hash(md5Hash, TB_Password.Text);
                }
                if (Password.Equals(user.password))
                {

                    MessageBox.Show("Bienvenue " + user.prenom + " " + user.nom + ".");
                    Fm_Menu menu = new Fm_Menu();
                    menu.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Mot de passe invalide !");
                }
                //this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login invalide !");
                
            }
            /*Fm_Menu menu = new Fm_Menu();
            menu.Show();
            this.Hide();*/
        }

        private void Fm_Connexion_Load(object sender, EventArgs e)
        {

        }

        private void Bt_New_Employe_Click(object sender, EventArgs e)
        {
            Fm_Add_Employe employe = new Fm_Add_Employe(bd);
            employe.Show();
        }

        static string GetMd5Hash(MD5 md5Hash, string input)
        {

            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }
        
    }
}
