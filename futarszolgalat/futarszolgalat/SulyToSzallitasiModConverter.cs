using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace futarszolgalat
{
    public class SulyToSzallitasiModConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int suly = (int)value;
            if (suly < 5000)
                return "biciklis futár";
            else if (suly < 50000)
                return "autós futár";
            return "teherautó";
            
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
