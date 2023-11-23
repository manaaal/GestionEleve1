using System.ComponentModel.DataAnnotations;

namespace GestionEleve1.Models
{
    public class Etablissement
    {
        [Key]
        public int EtablissementId { get; set; }
        public string EtablissementName { get; set; }

    }
}
