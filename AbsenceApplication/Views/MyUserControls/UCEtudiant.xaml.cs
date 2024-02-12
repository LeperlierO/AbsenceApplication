using AbsenceApplication.Business;
using AbsenceApplication.Models;
using AbsenceApplication.Views.DataEntry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AbsenceApplication.Views.MyUserControls
{
    /// <summary>
    /// Logique d'interaction pour UCEtudiant.xaml
    /// </summary>
    public partial class UCEtudiant : UserControl
    {
        public UCEtudiant()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if(this.DataContext is UCEtudiantBusiness)
            {
                StudentDataEntry dataEntry = new StudentDataEntry();
                Etudiant etudiant = new Etudiant();

                dataEntry.DataContext = etudiant;

                //dataEntry.Show(); // Pas bien parce que ça ne bloque pas, on peut ouvrir plusieurs même fenêtre, le code continue

                if (dataEntry.ShowDialog() == true) // Mieux à utiliser
                {
                    UCEtudiantBusiness bs = (UCEtudiantBusiness)this.DataContext;
                    bs.ListOfData.Add(etudiant);
                }
            }
            else if(this.DataContext is UCAbsenceBusiness)
            {
                AbsenceDataEntry absenceDataEntry = new AbsenceDataEntry();
                absenceDataEntry.ShowDialog();
            }

        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            UCEtudiantBusiness bs = (UCEtudiantBusiness)this.DataContext;

            if(bs.SelectedStudent != null)
            {
                StudentDataEntry dataEntry = new StudentDataEntry();
                dataEntry.DataContext = bs.SelectedStudent;

                if(dataEntry.ShowDialog() == true)
                {

                }
            }
            else
            {
                MessageBox.Show("Sélectionner un étudiant", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            UCEtudiantBusiness bs = (UCEtudiantBusiness)this.DataContext;

            if (bs.SelectedStudent != null)
            {
                bs.ListOfData.Remove(bs.SelectedStudent);
            }
            else
            {
                MessageBox.Show("Sélectionner un étudiant", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
