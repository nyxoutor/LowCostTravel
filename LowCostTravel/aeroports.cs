//------------------------------------------------------------------------------
// <auto-generated>
//    Ce code a été généré à partir d'un modèle.
//
//    Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//    Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LowCostTravel
{
    using System;
    using System.Collections.Generic;
    
    public partial class aeroports
    {
        public aeroports()
        {
            this.vols = new HashSet<vols>();
            this.vols1 = new HashSet<vols>();
        }
    
        public int id_aero { get; set; }
        public string ville_aero { get; set; }
    
        public virtual ICollection<vols> vols { get; set; }
        public virtual ICollection<vols> vols1 { get; set; }
    }
}
