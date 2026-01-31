using System.ComponentModel.DataAnnotations;

namespace AppSenSoutenance.Models
{
    public class Departement
    {
        [Key]
        public int IdDepartement { get; set; }

        [Required, MaxLength(80)]
        public string LibelleDepartement { get; set; }
    }
}
