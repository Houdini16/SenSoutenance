using AppSenSoutenance.Models;
using System.Collections.Generic;
using System.Linq;

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
                Value = null,
                Text = "Selectionner"
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

        public List<ListItem> FillDepartement()
        {
            List<ListItem> laListe = new List<ListItem>();
            var liste = db.Departements.ToList();
            laListe.Add(new ListItem
            {
                Value = null,
                Text = "Selectionner"
            });
            foreach (var t in liste)
            {
                var item = new ListItem
                {
                    Value = t.IdDepartement.ToString(),
                    Text = t.LibelleDepartement
                };
                laListe.Add(item);
            }
            return laListe;
        }

        public List<ListItem> FillSession(int? anneeAcademiqueId = null)
        {
            List<ListItem> laListe = new List<ListItem>();
            var liste = db.Sessions.AsQueryable();
            if (anneeAcademiqueId.HasValue)
            {
                liste = liste.Where(s => s.IdAnneeAcademique == anneeAcademiqueId.Value);
            }

            laListe.Add(new ListItem
            {
                Value = null,
                Text = "Selectionner"
            });

            foreach (var t in liste.ToList())
            {
                var item = new ListItem
                {
                    Value = t.IdSession.ToString(),
                    Text = t.LibelleSession
                };
                laListe.Add(item);
            }

            return laListe;
        }

        public List<ListItem> FillMemoire()
        {
            List<ListItem> laListe = new List<ListItem>();
            var liste = db.Mémoires.ToList();
            laListe.Add(new ListItem
            {
                Value = null,
                Text = "Selectionner"
            });
            foreach (var t in liste)
            {
                var item = new ListItem
                {
                    Value = t.IdMemoire.ToString(),
                    Text = t.SujetMemoire
                };
                laListe.Add(item);
            }
            return laListe;
        }

    }
}
