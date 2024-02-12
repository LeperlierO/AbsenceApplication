using AbsenceApplication.Business;
using AbsenceApplication.Models;
using AbsenceApplication.Views.MyUserControls;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AbsenceApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        UCEtudiant uCEtudiant;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnStudent_Click(object sender, RoutedEventArgs e)
        {
            grContent.Children.Clear();
            uCEtudiant = new UCEtudiant();
            uCEtudiant.DataContext = new UCEtudiantBusiness();
            grContent.Children.Add(uCEtudiant);
        }

        private void btnAbsence_Click(object sender, RoutedEventArgs e)
        {
            uCEtudiant.DataContext = new UCAbsenceBusiness();

            //grContent.Children.Clear();
            //grContent.Children.Add(new UCAbsence { DataContext = new UCAbsenceBusiness()});
        }
    }
}