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
    public class UCAbsenceBusiness
    {
        public RelayCommand AddCommand { get; set; }
        public RelayCommand EditCommand { get; set; }
        public RelayCommand DeleteCommand { get; set; }

        public string BusinessLabel { get; set; }
        public string AddButtonLabel { get; set; }
        public string EditButtonLabel { get; set; }
        public string DeleteButtonLabel { get; set; }

        public Absence SelectedData { get; set; }
        public ObservableCollection<Absence> ListOfData { get; set; }

        public UCAbsenceBusiness()
        {
            AddCommand = new RelayCommand(AddAbsence, CanAddAbsence);
            EditCommand = new RelayCommand(EditAbsence, CanEditAbsence);
            DeleteCommand = new RelayCommand(DeleteAbsence, CanDeleteAbsence);

            BusinessLabel = "Gestion absences";
            AddButtonLabel = "Ajouter absence";
            EditButtonLabel = "Modifier absence";
            DeleteButtonLabel = "Supprimer absence";

            ListOfData = new ObservableCollection<Absence>
            {
                new Absence(1),
                new Absence(2),
                new Absence(3)
            };
        }

        private bool CanAddAbsence(object obj)
        {
            return true;
        }

        private void AddAbsence(object obj)
        {
            AbsenceDataEntry absenceDataEntry = new AbsenceDataEntry();
            Absence absence = new Absence();

            absenceDataEntry.DataContext = absence;

            if(absenceDataEntry.ShowDialog() == true)
            {
                ListOfData.Add(absence);
            }
        }

        private bool CanEditAbsence(object obj)
        {
            return true;
        }

        private void EditAbsence(object obj)
        {
            if (SelectedData != null)
            {
                AbsenceDataEntry dataEntry = new AbsenceDataEntry();
                dataEntry.DataContext = SelectedData;
                dataEntry.ShowDialog();
            }
            else
            {
                MessageBox.Show("Sélectionner une absence", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private bool CanDeleteAbsence(object obj)
        {
            return true;
        }

        private void DeleteAbsence(object obj)
        {
            if (SelectedData != null)
            {
                ListOfData.Remove(SelectedData);
            }
            else
            {
                MessageBox.Show("Sélectionner une absence", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
