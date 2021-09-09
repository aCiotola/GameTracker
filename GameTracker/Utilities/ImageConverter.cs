using System;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Windows.Data;

namespace GameTracker.Utilities
{
    /// <summary>
    /// Responsible for converting an image to be used in the datagrid.
    /// Taken from: https://girishzalke.com/2017/01/12/display-images-in-wpf-data-grid/
    /// </summary>
    [ValueConversion(typeof(System.Drawing.Image), typeof(System.Windows.Media.ImageSource))]
    public sealed class ImageConverter : IValueConverter
    {
        /// <summary>
        /// Method responsible for converting the image.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null) return null;

            var image = (System.Drawing.Image)value;
            var bitmap = new System.Windows.Media.Imaging.BitmapImage();

            bitmap.BeginInit();
            MemoryStream memoryStream = new MemoryStream();
            image.Save(memoryStream, ImageFormat.Png);
            memoryStream.Seek(0, SeekOrigin.Begin);
            bitmap.StreamSource = memoryStream;
            bitmap.EndInit();

            return bitmap;
        }

        /// <summary>
        /// Method responsible for converting the image back to its original form.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
