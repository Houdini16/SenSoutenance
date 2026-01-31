using System.ComponentModel.DataAnnotations;

namespace AppSenSoutenance.Models
{
    public class Candidat : Utilisateur
    {
        [Required, MaxLength(20)]
        public string MatriculeCandidat { get; set; }
    }
}
