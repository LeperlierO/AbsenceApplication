using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace AbsenceApplication.Tools
{
    // Convertisseurs qui vont permettre de modifier les données à afficher au binding sur les template
    public class MyConverters : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // Du code vers l'interface
            if(value != null && value is string)
            {
                string name = value as string;
                return name.ToUpper();
            }

            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // Interface vers le code
            return value;
        }
    }
}
