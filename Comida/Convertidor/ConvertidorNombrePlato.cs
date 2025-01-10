using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace Comida.Convertidor
{
    class ConvertidorNombrePlato : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            
            switch (value.ToString())
            {
                case "China":
                    return new FontFamily("Chinese Wok Food St");
                case "Mexicana":
                    return new FontFamily("Taco Salad");
                case "Americana":
                    return new FontFamily("Slim Summer");
            }
            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
