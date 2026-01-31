using System.ComponentModel.DataAnnotations.Schema;

namespace AppSenSoutenance.Models
{
    public class ChefDepartement : Utilisateur
    {

        public int? IdDepartement { get; set; }

        [ForeignKey("IdDepartement")]
        public virtual Departement Departement { get; set; }
    }
}
