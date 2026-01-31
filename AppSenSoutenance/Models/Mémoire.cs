using System; // Fournit les types de base du .NET
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations; // Contient les attributs de validation (Key, Required, MaxLength…)
using System.ComponentModel.DataAnnotations.Schema; // Contient les attributs liés à la base de données (ForeignKey…)
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSenSoutenance.Models
{
    // Classe représentant l'entité Mémoire dans l'application
    public class Mémoire
    {
        // Clé primaire de la table Mémoire
        [Key]
        public int IdMemoire { get; set; }

        // Sujet du mémoire
        // MaxLength limite la taille à 500 caractères
        // Required rend le champ obligatoire
        [MaxLength(500), Required]
        public string SujetMemoire { get; set; }

        // Clé étrangère vers l'entité AnneeAcademique
        public int AnneeAcademiqueId { get; set; }

        // Navigation vers l'année académique associée
        // ForeignKey précise que AnneeAcademiqueId est la clé étrangère
        [ForeignKey("AnneeAcademiqueId")]
        public virtual AnneeAcademique AnneeAcademique { get; set; }

        // Contient le document du mémoire sous forme de tableau de bytes
        // (PDF, Word, etc.)
        public byte[] DocumentMemoire { get; set; }

        // Clé étrangère vers la session (soutenance, dépôt, etc.)
        public int IdSession { get; set; }

        // Navigation vers l'entité Session associée
        [ForeignKey("IdSession")]
        public virtual Session Session { get; set; }
    }
}
