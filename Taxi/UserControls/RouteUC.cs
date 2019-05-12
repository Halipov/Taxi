using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.MapProviders;

namespace Taxi.UserControls
{
    public partial class RouteUC : UserControl
    {
        public RouteUC()
        {
            InitializeComponent();
            
        }

        private void Route_Load(object sender, EventArgs e)
        {

        }

        private void map_Load(object sender, EventArgs e)
        {
            GMapProviders.GoogleMap.ApiKey = @"AIzaSyBGVo5Pr11kzS7On3LIm3AkgTiZc6c300E";
            GMaps.Instance.Mode = AccessMode.ServerAndCache;
            map.CacheLocation = @"cache";
            map.MapProvider = GMapProviders.GoogleMap;

            GMaps.Instance.Mode = AccessMode.ServerAndCache;

            map.DragButton = MouseButtons.Left;
            map.GrayScaleMode = true;
            map.CanDragMap = true;
            map.MarkersEnabled = true;
            map.MouseWheelZoomType =
                GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            map.NegativeMode = false;
            map.PolygonsEnabled = true;
            map.RoutesEnabled = true;
            map.MaxZoom = 18;
            map.Zoom = 16;
            map.NegativeMode = false;
            map.SetPositionByKeywords("Беларусь, Минск, Свердлова 13");
        }
    }
}
