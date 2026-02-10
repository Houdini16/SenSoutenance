using System;
using System.ComponentModel.DataAnnotations;

namespace AppSenSoutenance.Models
{
    public class Td_Erreur
    {
        [Key]
        public int IdTdErreur { get; set; }

        [MaxLength(200)]
        public string TitreErreur { get; set; }
        [MaxLength(2000)]
        public string DescriptionErreur { get; set; }
        public DateTime DateErreur { get; set; }
    }
}
