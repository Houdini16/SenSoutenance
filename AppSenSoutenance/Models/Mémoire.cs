using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSenSoutenance.Models
{
    public class Mémoire
    {
        [Key]
        public int IdMemoire { get; set; }

        [MaxLength(500), Required]
        public string SujetMemoire { get; set; }

        public int AnneeAcademiqueId { get; set; }

        [ForeignKey("AnneeAcademiqueId")]
        public virtual AnneeAcademique AnneeAcademique { get; set; }

        public byte[] DocumentMemoire { get; set; }

        public int IdSession { get; set; }

        [ForeignKey("IdSession")]
        public virtual Session Session { get; set; }

    }
}
