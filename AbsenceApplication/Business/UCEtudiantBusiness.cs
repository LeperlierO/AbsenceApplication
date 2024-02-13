using AbsenceApplication.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsenceApplication.Business
{
    public class UCEtudiantBusiness
    {
        public string BusinessLabel { get; set; }
        public string AddButtonLabel { get; set; }
        public string EditButtonLabel { get; set; }
        public string DeleteButtonLabel { get; set; }


        public Etudiant SelectedStudent { get; set; }
        public ObservableCollection<Etudiant> ListOfData { get; set; } // Observable permet de mettre à jour les données sur l'interface

        public UCEtudiantBusiness()
        {
            BusinessLabel = "Gestion des étudiants";
            AddButtonLabel = "Ajouter étudiant";
            EditButtonLabel = "Modifier étudiant";
            DeleteButtonLabel = "Supprimer étudiant";

            ListOfData = new ObservableCollection<Etudiant>
            {
                new Etudiant("Le boss", "Junior", "111", "222", new DateTime(1999, 12, 9)),
                new Etudiant("La boss", "Henoux", "333", "444", new DateTime(1999, 07, 15))
            };
        }
    }
}
