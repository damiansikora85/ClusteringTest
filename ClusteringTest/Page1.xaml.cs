using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ClusteringTest
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        private int _pointId;

        public Page1()
        {
            InitializeComponent();
        }

        private void Map_MapClicked(object sender, Xamarin.Forms.GoogleMaps.MapClickedEventArgs e)
        {
            Map.Pins.Add(new Xamarin.Forms.GoogleMaps.Pin
            {
                Position = new Xamarin.Forms.GoogleMaps.Position(e.Point.Latitude, e.Point.Longitude),
                Label = $"Pin: {_pointId}"
            });
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Map.Pins.Clear();
        }
    }
}