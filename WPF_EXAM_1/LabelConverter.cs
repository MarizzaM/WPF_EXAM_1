using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace WPF_EXAM_1
{
    class LabelConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            double value = System.Convert.ToDouble(values[0]);
            double maximum = System.Convert.ToDouble(values[1]);
            double minimum = System.Convert.ToDouble(values[2]);

            double distanceFromMin = value - minimum;
            double sliderSize = maximum - minimum;

            if ((distanceFromMin / sliderSize * 100) < 25)
                return "SMALL";
            if ((distanceFromMin / sliderSize * 100) < 50)
                return "MEDIUM";
            if ((distanceFromMin / sliderSize * 100) < 75)
                return "LARGE";
            else 
                return "EXTRA LARGE";
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
