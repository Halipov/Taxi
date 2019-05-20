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
        private List<PointLatLng> points;
        public RouteUC()
        {
            InitializeComponent();
            points = new List<PointLatLng>();
        }

        private void Route_Load(object sender, EventArgs e)
        {

        }

        private void PanelStatus_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButtonClose_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
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
            map.SetPositionByKeywords("Беларусь, Минск, Свердлова 13а");
        }

        private void ButtonRoute_Click(object sender, EventArgs e)
        {
            if (!TextBoxFrom.Text.Trim().Equals(""))
            {
                string str1 = "Беларусь, Минск" + TextBoxFrom.Text.Trim();
                GeoCoderStatusCode statusCode;
                var pointLatLng1 = GoogleMapProvider.Instance.GetPoint(str1, out statusCode);
                if (statusCode == GeoCoderStatusCode.OK)
                {
                    points.Insert(0, new PointLatLng(pointLatLng1.Value.Lat, pointLatLng1.Value.Lng));
                }
                else
                {
                    MessageBox.Show("Uncorrect address. Returned status:" + statusCode);
                }
            }
            else
            {
                MessageBox.Show("Invalid");
            }

            if (!TextBoxTo.Text.Trim().Equals(""))
            {
                GeoCoderStatusCode statusCode;
                string str2 = "Беларусь, Минск" + TextBoxTo.Text.Trim();
                var pointLatLng2 = GoogleMapProvider.Instance.GetPoint(str2, out statusCode);
                if (statusCode == GeoCoderStatusCode.OK)
                {
                    points.Insert(1, new PointLatLng(pointLatLng2.Value.Lat, pointLatLng2.Value.Lng));
                }
                else
                {
                    MessageBox.Show("Uncorrect address. Returned status:" + statusCode);
                }
            }
            else
            {
                MessageBox.Show("Invalid");
            }

            var route = GoogleMapProvider.Instance.GetRoute(points[0], points[1], false, false, 14);
            var r = new GMapRoute(route.Points, "My Route");
            var routes = new GMapOverlay("routes");
            routes.Routes.Add(r);
            map.Overlays.Add(routes);
            map.ZoomAndCenterRoutes("routes");
        }

        private void TextBoxFrom_OnValueChanged(object sender, EventArgs e)
        {
            
        }

        private void TextBoxFrom_Click(object sender, EventArgs e)
        {
            TextBoxFrom.Text = "";
            
        }

        private void TextBoxTo_Click(object sender, EventArgs e)
        {
            //TextBoxFrom.ForeColor = System.Drawing.Color.White;
            TextBoxTo.Text = "";
        }

        private void TextBoxTo_MouseCaptureChanged(object sender, EventArgs e)
        {
           
        }

        private void TextBoxTo_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
