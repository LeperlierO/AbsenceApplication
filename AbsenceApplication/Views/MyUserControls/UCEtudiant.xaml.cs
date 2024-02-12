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
            StudentDataEntry dataEntry = new StudentDataEntry();
            Etudiant etudiant = new Etudiant();

            dataEntry.DataContext = etudiant;

            //dataEntry.Show(); // Pas bien parce que ça ne bloque pas, on peut ouvrir plusieurs même fenêtre, le code continue

            if (dataEntry.ShowDialog() == true) // Mieux à utiliser
            {
                UCEtudiantBusiness bs = (UCEtudiantBusiness)this.DataContext;
                bs.Students.Add(etudiant);
            }

        }
    }
}
