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
        private SoldVolEntities bd;
        public Fm_Add_Employe(SoldVolEntities p_bd)
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
            if (string.IsNullOrEmpty(Tb_Nom.Text) || string.IsNullOrEmpty(Tb_Prenom.Text) || string.IsNullOrEmpty(Tb_Login.Text) || string.IsNullOrEmpty(Tb_Pass.Text))
            {
                MessageBox.Show("Veuillez remplir tout les champs");
            }else{
                employe employeAdd = new employe();
                employeAdd.nom = Tb_Nom.Text;
                employeAdd.prenom = Tb_Prenom.Text;
                employeAdd.login = Tb_Login.Text;
                using (MD5 md5Hash = MD5.Create()){
                    employeAdd.password = GetMd5Hash(md5Hash, Tb_Pass.Text);
                }
                try
                {
                    bd.employe.Add(employeAdd);
                    bd.SaveChanges();
                }

                catch (System.Data.Entity.Validation.DbEntityValidationException ex)
                {
                    // Retrieve the error messages as a list of strings.
                    var errorMessages = ex.EntityValidationErrors
                            .SelectMany(x => x.ValidationErrors)
                            .Select(x => x.ErrorMessage);

                    // Join the list to a single string.
                    var fullErrorMessage = string.Join("; ", errorMessages);

                    // Combine the original exception message with the new one.
                    var exceptionMessage = string.Concat(ex.Message, " The validation errors are: ", fullErrorMessage);

                    // Throw a new DbEntityValidationException with the improved exception message.
                    throw new Exception(exceptionMessage);
                }
                this.Close();
            }
            
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
