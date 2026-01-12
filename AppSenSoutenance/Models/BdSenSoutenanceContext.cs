using MySql.Data.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSenSoutenance.Models
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class BdSenSoutenanceContext: DbContext
    {
        public BdSenSoutenanceContext() : base("connBdSenSoutenance") { }

        public DbSet<AnneeAcademique> AnneesAcademiques { get; set; }

        public DbSet<Departement> Departements { get; set; }

        public DbSet<Mémoire> Mémoires { get; set; }

        public DbSet<Session> Sessions { get; set; }

        public DbSet<Soutenance> Soutenances { get; set; }

        public DbSet<Utilisateur> Utilisateurs { get; set; }

        public DbSet<Admin> Admin { get; set; }

        public DbSet<ChefDepartement> ChefDepartements { get; set; }

        public DbSet<Candidat> Candidats { get; set; }

        public DbSet<Professeur> Professeurs { get; set; }
    }
}
