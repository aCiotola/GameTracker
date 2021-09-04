using GameTracker.Requests;
using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace GameTracker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            PlatformRequest pReq = new PlatformRequest();
            GenreRequest gReq = new GenreRequest();

            //Get picture of a platform.
            Uri uri = new Uri(pReq.GetPlatformDetails(8).GetBackgroundImage(), UriKind.Absolute);
            ImageSource imgSource = new BitmapImage(uri);
            gamePic.Source = imgSource;
        }
    }
}
