using AbsenceApplication.Commands;
using AbsenceApplication.Models;
using AbsenceApplication.Views.DataEntry;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AbsenceApplication.Business
{
    public class UCEtudiantBusiness
    {
        #region Relay command
        public RelayCommand AddCommand { get; set; }
        public RelayCommand EditCommand { get; set; }
        public RelayCommand DeleteCommand { get; set; }
        #endregion

        #region Properties
        public string BusinessLabel { get; set; }
        public string AddButtonLabel { get; set; }
        public string EditButtonLabel { get; set; }
        public string DeleteButtonLabel { get; set; }

        public Etudiant SelectedData { get; set; }
        public ObservableCollection<Etudiant> ListOfData { get; set; } // Observable permet de mettre à jour les données sur l'interface

        #endregion

        #region Constructors
        public UCEtudiantBusiness()
        {
            AddCommand = new RelayCommand(AddStudent, CanAddStudent);
            EditCommand = new RelayCommand(EditStudent, CanEditStudent);
            DeleteCommand = new RelayCommand(DeleteStudent, CanDeleteStudent);

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
        #endregion

        #region Relay functions
        private bool CanAddStudent(object obj)
        {
            return true;
        }

        private void AddStudent(object obj)
        {
            StudentDataEntry dataEntry = new StudentDataEntry();
            Etudiant etudiant = new Etudiant();

            dataEntry.DataContext = etudiant;

            //dataEntry.Show(); // Pas bien parce que ça ne bloque pas, on peut ouvrir plusieurs même fenêtre, le code continue

            if (dataEntry.ShowDialog() == true) // ShowDialog mieux à utiliser
            {
                ListOfData.Add(etudiant);
            }
        }

        private bool CanEditStudent(object obj)
        {
            return true;
        }

        private void EditStudent(object obj)
        {
            if (SelectedData != null)
            {
                StudentDataEntry dataEntry = new StudentDataEntry();
                dataEntry.DataContext = SelectedData;
                dataEntry.ShowDialog();
            }
            else
            {
                MessageBox.Show("Sélectionner un étudiant", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private bool CanDeleteStudent(object obj)
        {
            return true;
        }

        private void DeleteStudent(object obj)
        {
            if (SelectedData != null)
            {
                ListOfData.Remove(SelectedData);
            }
            else
            {
                MessageBox.Show("Sélectionner un étudiant", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        #endregion

    }
}
