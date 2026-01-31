using AppSenSoutenance.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSenSoutenance.Shared
{
    public static class Logger
    {
        /// <summary>
        /// rédiger les erreurs au niveau de la base de données
        /// </summary>
        public static void WriteDataError(string TitreErreur, string erreur)
        {
            try
            {
                BdSenSoutenanceContext db = new BdSenSoutenanceContext();
                Td_Erreur log = new Td_Erreur();
                log.DateErreur = DateTime.Now;
                log.DescriptionErreur = erreur.Length > 2000 ? erreur.Substring(0, 2000) : erreur;
                log.TitreErreur = TitreErreur;
                db.Td_Erreur.Add(log);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                WriteLogSystem(ex.ToString(), "WriteDataError");
            }
        }


        /// <summary>
        /// Pour créer un fichier d'erreur
        /// </summary>
        public static bool CreateFile(string message)
        {
            bool rep = false;
            string fileName = string.Format("{0}{1}{2}", DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            try
            {
                // Placer les fichiers d'erreur dans un dossier Error à côté de l'exécutable
                string dir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Error");
                if (!Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }

                string path = Path.Combine(dir, fileName + ".txt");

                bool fileUse = true;
                while (fileUse)
                {
                    try
                    {
                        using (System.IO.TextWriter writeFile = new StreamWriter(path, true))
                        {
                            writeFile.WriteLine("" + DateTime.Now);
                            writeFile.WriteLine(message);
                            writeFile.WriteLine("-------------------------------------------");
                            writeFile.Flush();
                        }

                        fileUse = false;
                    }
                    catch (Exception e)
                    {
                        // Eviter boucle infinie si CreateFile appelle WriteLogSystem qui appelle CreateFile
                        // Ici on écrit sur la console en dernier recours
                        try
                        {
                            System.Diagnostics.Debug.WriteLine("CreateFile error: " + e);
                        }
                        catch
                        {
                        }

                        // Petite pause avant nouvelle tentative
                        System.Threading.Thread.Sleep(50);
                    }
                }
                rep = true;
            }
            catch (IOException e)
            {
                try { System.Diagnostics.Debug.WriteLine(e.ToString()); } catch { }
            }
            return rep;
        }



        /// <summary>
        /// Crée la source d'événements si elle n'existe pas. Doit être exécutée avec des droits administrateur.
        /// Appeler depuis l'installation ou au démarrage si l'application est lancée en mode administrateur.
        /// </summary>
        public static void EnsureEventSourceExists()
        {
            const string source = "SenSoutenance";
            const string logName = "Application";

            try
            {
                if (!EventLog.SourceExists(source))
                {
                    var sourceData = new EventSourceCreationData(source, logName);
                    EventLog.CreateEventSource(sourceData);
                }
            }
            catch (System.Security.SecurityException)
            {
                // Pas de droits pour créer la source : enregistrer en fallback
                CreateFile($"[EnsureEventSourceExists] droits insuffisants pour créer la source '{source}'.");
            }
            catch (Exception ex)
            {
                CreateFile($"[EnsureEventSourceExists] erreur inattendue: {ex}");
            }
        }


        /// <summary>
        /// Ecrire un message d'erreur au niveau du Systéme
        /// </summary>
        public static void WriteLogSystem(string erreur, string libelle)
        {
            try
            {
                using (EventLog eventLog = new EventLog("Application"))
                {
                    eventLog.Source = "SenSoutenance";
                    eventLog.WriteEntry(string.Format("date: {0}, libelle: {1}, description {2}", DateTime.Now, libelle, erreur), EventLogEntryType.Information, 101, 1);
                }
            }
            catch (System.Security.SecurityException)
            {
                // Fallback si pas de droits pour accéder/créer la source
                CreateFile($"[EventLog fallback] {libelle}: {erreur}");
            }
            catch (Exception ex)
            {
                // Eviter boucles de log trop profondes
                try { CreateFile($"[EventLog unexpected] {ex}"); } catch { }
            }
        }

    }
}
