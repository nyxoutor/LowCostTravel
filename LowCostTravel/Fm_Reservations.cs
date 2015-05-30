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
    public partial class Fm_Reservations : Form
    {
        private SoldVol bd;
        public Fm_Reservations(SoldVol p_bd)
        {
            InitializeComponent();
            bd = p_bd;
            reservationBindingSource.DataSource = bd.reservation.ToList();
        }

        private void Fm_Reservations_Load(object sender, EventArgs e)
        {

        }

        
    }
}
