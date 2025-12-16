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
    }
}
