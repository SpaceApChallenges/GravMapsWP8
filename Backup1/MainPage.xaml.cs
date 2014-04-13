using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

using Microsoft.Phone.Controls.Maps;
using System.Device.Location;

using System.Windows.Media.Imaging;

namespace NokiaMaps
{
    public partial class MainPage : PhoneApplicationPage
    {        
        // Costruttore
        public MainPage()
        {
            InitializeComponent();

            MapLayer m_PushpinLayer = new MapLayer();
            map.Children.Add(m_PushpinLayer);

            // Reasonable stab at center of Seattle metro area
            map.SetView(new GeoCoordinate(41.89001, 12.495346), 10);

            // Create and Add a few push pins
            Pushpin pushpin1 = new Pushpin();
            pushpin1.Background = new SolidColorBrush(Colors.Red);
            pushpin1.Location = new GeoCoordinate(45.463983, 9.187946);    // Milan

            Pushpin pushpin2 = new Pushpin();
            pushpin2.Background = new SolidColorBrush(Colors.Green);
            pushpin2.Location = new GeoCoordinate(37.066684, 15.282555);       // Siracusa

            Pushpin pushpin3 = new Pushpin();
            pushpin3.Background = new SolidColorBrush(Colors.Blue);
            pushpin3.Location = new GeoCoordinate(37.102357, 15.124986);    // Solarino

            m_PushpinLayer.AddChild(pushpin1, pushpin1.Location);
            m_PushpinLayer.AddChild(pushpin2, pushpin2.Location);
            m_PushpinLayer.AddChild(pushpin3, pushpin3.Location);

            map.ZoomLevel = 6;
        }

        private void buttonZoomIn_Click(object sender, RoutedEventArgs e)
        {
            double zoom;
            zoom = map.ZoomLevel;
            map.ZoomLevel = ++zoom;
        }

        private void buttonZoomOut_Click(object sender, RoutedEventArgs e)
        {
            double zoom;
            zoom = map.ZoomLevel;
            map.ZoomLevel = --zoom;
        }
    }

}