using System.ComponentModel.DataAnnotations;

namespace AppSenSoutenance.Models
{
    public class Professeur : Utilisateur
    {
        [Required, MaxLength(80)]
        public string SpecialiteProfesseur { get; set; }

    }
}
