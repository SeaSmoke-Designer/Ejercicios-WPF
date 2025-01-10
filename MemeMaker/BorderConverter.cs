using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace MemeMaker
{
    class BorderConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // Lo que me llega en value es un IsChecked, entonces es un boolean, pero aqui es un objeto
            // Entonces no sabe lo que es, por eso hay que castearlo a bool
            // Tambien podemos devoler solamente un numero. return 2 || return 0. Y se lo traga
            bool res = (bool)value;
            if (res)
               return new Thickness(2);
            else
               return new Thickness(0);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
