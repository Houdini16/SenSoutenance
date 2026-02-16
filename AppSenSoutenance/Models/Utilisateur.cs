using System.ComponentModel.DataAnnotations;

namespace AppSenSoutenance.Models
{
    public class Utilisateur
    {
        [Key]
        public int IdUtilisateur { get; set; }

        [Required, MaxLength(80)]
        public string NomUtilisateur { get; set; }

        [Required, MaxLength(80)]
        public string PrenomUtilisateur { get; set; }

        [Required, MaxLength(15)]
        public string TellUtilisateur { get; set; }

        [Required, MaxLength(100), DataType(DataType.EmailAddress)]
        public string EmailUtilisateur { get; set; }

        [Required, MaxLength(300)]
        public string MotDePasse { get; set; }

        [Required, MaxLength(50)]
        public string Role { get; set; }
    }
}
