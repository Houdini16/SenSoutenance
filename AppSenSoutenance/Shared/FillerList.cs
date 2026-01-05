using AppSenSoutenance.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSenSoutenance.Shared
{
    public class FillerList
    {
        BdSenSoutenanceContext db = new BdSenSoutenanceContext();
        public List<ListItem> FillAnneeAcademique()
        /// <summary>
        /// Remplit la liste des années académiques
        /// </summary>
        /// returns>Liste des années académiques</returns>

        {
            List<ListItem> laListe = new List<ListItem>();
            var liste = db.AnneesAcademiques.ToList();
            laListe.Add(new ListItem
            {
                Value= null,
                Text ="Selectionner"
            });
            foreach (var t in liste)
            {
                var item = new ListItem
                {
                    Value = t.IdAnneeAcademique.ToString(),
                    Text = t.LibelleAnneeAcademique.ToString()
                };
                laListe.Add(item);
            }
            return laListe;
        }
        
    }
}
