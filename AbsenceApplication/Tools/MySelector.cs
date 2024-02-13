using AbsenceApplication.Models;
using System.Windows;
using System.Windows.Controls;

namespace AbsenceApplication.Tools
{
    public class MySelector : DataTemplateSelector // Hérite de la classe qui est responsable de la sélection pour affecter la bonne data template
    {
        // Fonction qui permet de selec le bon data template car on a un seul user control pour deux objets(etudiant absence)
        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            FrameworkElement element = container as FrameworkElement;

            if(item is Etudiant)
            {
                return element.FindResource("StudentDataTemplate") as DataTemplate;
            }

            return element.FindResource("AbsenceDataTemplate") as DataTemplate;
        }
    }
}
