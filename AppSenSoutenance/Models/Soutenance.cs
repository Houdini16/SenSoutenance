using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppSenSoutenance.Models
{
    public class Soutenance
    {
        [Key]
        public int IdSoutenance { get; set; }
        public DateTime DateSoutenance { get; set; } = DateTime.Now;

        [MaxLength(2000)]
        public string LieuSoutenance { get; set; }

        [MaxLength(40)]
        public String ResultatSoutenance { get; set; }

        [MaxLength(100)]
        public String MentionSoutenance { get; set; }

        [MaxLength(5000)]
        public String ObservationsSoutenance { get; set; }

        public int? IdMemoire { get; set; }

        [ForeignKey("IdMemoire")]
        public virtual Mémoire Mémoire { get; set; }
    }
}
