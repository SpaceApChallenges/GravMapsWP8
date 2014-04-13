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
using Windows.Devices.Geolocation;
using Newtonsoft.Json;
using System.Diagnostics;

namespace NokiaMaps
{
    public partial class MainPage : PhoneApplicationPage
    {
        public MapLayer m_PushpinLayer;
        public static Double latitude;
        public static Double longitude;
        public static Double altitude;
        public static Double gravity;
        public static String gravity_final;
        private GeoCoordinate mapCenter;
        MapLayer imgLayer;

        // Costruttore
        public MainPage()
        {
            InitializeComponent();

            m_PushpinLayer = new MapLayer();
            map.Children.Add(m_PushpinLayer);



            imgLayer = new MapLayer();
            map.Children.Add(imgLayer);


            // Reasonable stab at center of Seattle metro area
        

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


        void webClient_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            Double altitude = 0;
            try
            {
                var rootObject = JsonConvert.DeserializeObject<RootObject>(e.Result);


                foreach (var blog in rootObject.results)
                {
                    altitude = blog.elevation;
                    String b = Convert.ToString(altitude);

                calculateGravity(altitude, latitude);
                }
            }
            catch (Exception f)
            {

            }
            //provaText.Text = altitude + "";
        }

        public void calculateGravity(double altitude, double latitude)
        {
            Double gravity = (9.780327 * (1 + 0.0053024 * Math.Pow(Math.Sin(latitude), 2) - 0.0000058 * Math.Pow(Math.Sin(2 * latitude), 2))
                - 0.000003086 * altitude);

            gravity_final = Convert.ToString(gravity);
            //provaText.Text = s;
        }


        public void Button_Click(object sender, RoutedEventArgs e)
        {
            GetLocation();
            calculate(latitude, longitude);
            calculateGravity(latitude, altitude);
            // MessageBox.Show(Convert.ToString(latitude));
        }

        public void calculate(Double lat, Double lon)
        {
            WebClient webClient = new WebClient();
            webClient.DownloadStringCompleted += new DownloadStringCompletedEventHandler(webClient_DownloadStringCompleted);
            String prova = "http://maps.googleapis.com/maps/api/elevation/" + "json?locations=" + lon + "," + lat + "&sensor=true";
            webClient.DownloadStringAsync(new Uri(prova));
        }


        async private void GetLocation()
        {

            var geolocator = new Geolocator();

            Geoposition position = await geolocator.GetGeopositionAsync();

            Geocoordinate coordinate = position.Coordinate;
            latitude = coordinate.Latitude;
            longitude = coordinate.Longitude;
            calculate(latitude, longitude);

            // MessageBox.Show("Latitude = " + coordinate.Latitude + " Longitude = " + coordinate.Longitude);

        }

        async void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
            Pushpin pin = null;   
             var geolocator = new Geolocator();

            Geoposition position = await geolocator.GetGeopositionAsync();

            Geocoordinate coordinate = position.Coordinate;
            latitude = coordinate.Latitude;
            longitude = coordinate.Longitude;
            
            calculate(latitude, longitude);
            map.Center = new GeoCoordinate(latitude, longitude);
            calculateGravity(latitude, altitude);
            Pushpin geo = new Pushpin();
            geo.Location = new GeoCoordinate(latitude, longitude);
            m_PushpinLayer.AddChild(geo, geo.Location);
           
            //geo.MouseLeftButtonUp += new MouseButtonEventHandler(pushpintap);
            geo.MouseLeftButtonUp += new MouseButtonEventHandler(pushpintap);
            


            





        }

        private void pushpintap(object sender, MouseButtonEventArgs e)    
        {
      //Messagebox are what ever    
            MessageBox.Show("The gravity here is: " + gravity_final);    
         }

        private void MouseLeftButtonUpss(object sender, MouseButtonEventArgs e)
        {

            Point p = e.GetPosition(this.map);
            GeoCoordinate geo = new GeoCoordinate();
            geo = map.ViewportPointToLocation(p);
            map.ZoomLevel = 100;
            map.Center = geo;
            //---create a new pushpin---
            Pushpin pin = new Pushpin();

            //---set the location for the pushpin---
            pin.Location = geo;

            //---add the pushpin to the map---
            map.Children.Add(pin);
        }

        private void street_Tap(object sender, GestureEventArgs e)
        {

        }

       
 
        public void voidwatcher_PositionChanged(object sender, 
        GeoPositionChangedEventArgs<GeoCoordinate> e)
        {
         Debug.WriteLine("({0},{1})", 
            e.Position.Location.Latitude, e.Position.Location.Longitude);
 
            map.Center = new GeoCoordinate(
             e.Position.Location.Latitude, e.Position.Location.Longitude);
}
    }

}