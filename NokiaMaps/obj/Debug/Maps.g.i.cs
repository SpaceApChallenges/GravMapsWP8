﻿#pragma checksum "C:\Users\Alessandro\Desktop\NokiaMaps\NokiaMaps\Maps.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "AFA1D9941F909832EA15DA6665878A2D"
//------------------------------------------------------------------------------
// <auto-generated>
//     Il codice è stato generato da uno strumento.
//     Versione runtime:4.0.30319.34011
//
//     Le modifiche apportate a questo file possono provocare un comportamento non corretto e andranno perse se
//     il codice viene rigenerato.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using Microsoft.Phone.Controls.Maps;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace NokiaMaps {
    
    
    public partial class MainPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel TitlePanel;
        
        internal System.Windows.Controls.TextBlock PageTitle;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal Microsoft.Phone.Controls.Maps.Map map;
        
        internal Microsoft.Phone.Controls.Maps.MapTileLayer street;
        
        internal Microsoft.Phone.Controls.Maps.MapTileLayer wateroverlay;
        
        internal Microsoft.Phone.Controls.Maps.MapTileLayer hybrid;
        
        internal Microsoft.Phone.Controls.Maps.MapTileLayer satellite;
        
        internal Microsoft.Phone.Controls.Maps.MapTileLayer physical;
        
        internal System.Windows.Controls.Button buttonZoomIn;
        
        internal System.Windows.Controls.Button buttonZoomOut;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/NokiaMaps;component/Maps.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TitlePanel = ((System.Windows.Controls.StackPanel)(this.FindName("TitlePanel")));
            this.PageTitle = ((System.Windows.Controls.TextBlock)(this.FindName("PageTitle")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.map = ((Microsoft.Phone.Controls.Maps.Map)(this.FindName("map")));
            this.street = ((Microsoft.Phone.Controls.Maps.MapTileLayer)(this.FindName("street")));
            this.wateroverlay = ((Microsoft.Phone.Controls.Maps.MapTileLayer)(this.FindName("wateroverlay")));
            this.hybrid = ((Microsoft.Phone.Controls.Maps.MapTileLayer)(this.FindName("hybrid")));
            this.satellite = ((Microsoft.Phone.Controls.Maps.MapTileLayer)(this.FindName("satellite")));
            this.physical = ((Microsoft.Phone.Controls.Maps.MapTileLayer)(this.FindName("physical")));
            this.buttonZoomIn = ((System.Windows.Controls.Button)(this.FindName("buttonZoomIn")));
            this.buttonZoomOut = ((System.Windows.Controls.Button)(this.FindName("buttonZoomOut")));
        }
    }
}

