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
    public partial class Fm_Add_Employe : Form
    {
        private SoldVol bd;
        public Fm_Add_Employe(SoldVol p_bd)
        {
            InitializeComponent();
            bd = p_bd;
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
            using (MD5 md5Hash = MD5.Create()){
                employeAdd.password = GetMd5Hash(md5Hash, Tb_Pass.Text);
            }
            bd.employe.Add(employeAdd);
            bd.SaveChanges();
            MessageBox.Show("GG WP !");
            this.Close();
            // a continuer pour crypter le mdp

        

         

            
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
