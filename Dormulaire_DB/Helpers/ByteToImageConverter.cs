using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Windows.Data;
using System.IO;
using System.Windows.Media.Imaging;

namespace Dormulaire_DB.Helpers
{
    public class ByteToImageConverter: IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter,System.Globalization.CultureInfo culture)
        {           
            BitmapImage BI = new BitmapImage();
            BI.SetSource(new MemoryStream(value as byte[]));
            return BI;
        }


        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }

    }
}
