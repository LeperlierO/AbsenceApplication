using AbsenceApplication.Models;
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
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            List<Etudiant> etudiants = new List<Etudiant>
            {
                new Etudiant("Le boss", "Junior", "111", "222", new DateTime(1999,12,09))
            };

            dgStudent.ItemsSource = etudiants;
        }
    }
}