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
    
    public partial class reservation
    {
        public int id_vols { get; set; }
        public int id_clients { get; set; }
        public string etat_reservation { get; set; }
        public System.DateTime date_reservation { get; set; }
        public int place_reservation { get; set; }
    
        public virtual clients clients { get; set; }
        public virtual vols vols { get; set; }

        public string Nom_client { get { return this.clients.nom_clients; } }
        public string Prenom_client { get { return this.clients.prenom_clients; } }
        public string Depart { get { return this.vols.Aero_Dep; } }
        public string Arrivee { get { return this.vols.Aero_Arr; } }
        public System.DateTime Date_Vol { get { return this.vols.depart_vols; } }
    }
}
