using System.ComponentModel.DataAnnotations;

namespace GestionEleve1.Models
{
    public class Eleve
    {
        [Key]
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime DateNaissance { get; set; }
        public int EtablissementId { get; set; }
        public Etablissement Etablissement { get; set;}
    }
}


//Models: Classes that represent the data of the app. The model classes use validation logic to enforce business
//rules for that data. Typically, model objects retrieve and store model state in a database.
//A model retrieves data from a database, provides it to the view or updates it. Updated data is written to a database.
