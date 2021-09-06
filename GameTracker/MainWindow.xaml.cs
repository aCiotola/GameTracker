using GameTracker.Classes;
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
            GameRequest gameRequest = new GameRequest();
            string site = gameRequest.GetGameInfo("kingdom-hearts-iii").background_image;

            //Get pictures of a game.
            Platform platform = pReq.GetPlatformDetails(9);
            MessageBox.Show(platform.ToString());
            if (platform.image != null)
            {
                Uri uri = new Uri(platform.image, UriKind.Absolute);
                ImageSource imgSource = new BitmapImage(uri);
                gamePic.Source = imgSource;
            }

            Uri uri2 = new Uri(platform.image_background, UriKind.Absolute);
            ImageSource imgSource2 = new BitmapImage(uri2);
            gamePic2.Source = imgSource2;
        }
    }
}
