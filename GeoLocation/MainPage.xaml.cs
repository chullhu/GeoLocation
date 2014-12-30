using System;
//using System.Collections.Generic;
//using System.IO;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.Devices.Geolocation;

namespace GeoLocation
{
    public sealed partial class MainPage : Page
    {
        Geolocator geo = null;
        public MainPage()
        {
            this.InitializeComponent();

            this.NavigationCacheMode = NavigationCacheMode.Required;
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            if (geo == null)
            {
                geo = new Geolocator();
            }

            Geoposition pos = await geo.GetGeopositionAsync();
            latitude.Text = "Широта:" + pos.Coordinate.Point.Position.Latitude.ToString();
            lohgitue.Text = "Долгота:" + pos.Coordinate.Point.Position.Longitude.ToString();
            accuracy.Text = "Точность" + pos.Coordinate.Accuracy.ToString();
        }
    }
}
