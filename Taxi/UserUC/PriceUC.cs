using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Taxi.BLL;
using Taxi.DLL;

using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.MapProviders;

namespace Taxi.UserControls
{
    public delegate void NextHandlerWR();
    public partial class PriceUC : UserControl
    {
        
        public PriceUC()
        {
            InitializeComponent();
            FormMainUser fmu = new FormMainUser();
        }
        OrderBLL order = new OrderBLL();
        OrderDAL orderdal = new OrderDAL();
        public event NextHandlerWR click;
        private void label1_Click(object sender, EventArgs e)
        {

        }
        public double sum = 0;
        public void price_count()
        {
            double coeff = 0.5;
            if (label_Class.Text.Trim() == "A")
            {
                coeff += 0.5;
            }
            if (label_Class.Text.Trim() == "B")
            {
                coeff += 0.3;
            }
            if (label_Class.Text.Trim() == "C")
            {
                coeff += 0.2;
            }
            sum = RouteUC.distance * coeff;
        }

        private void Price_Load(object sender, EventArgs e)
        {
            
            label_From.Text = RouteUC.from;
            label_To.Text = RouteUC.to;
            label_Distance.Text = $"{RouteUC.distance} km";
            label_Class.Text = SelectAutoUC._class;
            price_count();
            labelTotalPrice.Text = $"{sum} BYN";
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
            map.SetPositionByKeywords("Беларусь, Минск, Свердлова 13а");

            RouteUC.routes2.Routes.Add(RouteUC.r2);
            map.Overlays.Add(RouteUC.routes2);
            map.ZoomAndCenterRoutes("routes");
            //routes.Routes.Add(r);
            //map.Overlays.Add(routes);
        }

        private void labelTotalPrice_Click(object sender, EventArgs e)
        {

        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButtonCreateOrder_Click(object sender, EventArgs e)
        {

            order.contact = FormLogin.contact;
            order.status = "true";
            bool success = orderdal.StatusChange(order);
            if (success)
            {
                click.Invoke();
            }
            else
            {
                MessageBox.Show("Error");
            }
            
        }

        private void PanelM_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label_Price_Click(object sender, EventArgs e)
        {

        }

        private void labelFrom_Click(object sender, EventArgs e)
        {

        }

        private void labelDistance_Click(object sender, EventArgs e)
        {

        }

        private void labelClass_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label_From_Click(object sender, EventArgs e)
        {

        }

        private void label_To_Click(object sender, EventArgs e)
        {

        }

        private void label_Distance_Click(object sender, EventArgs e)
        {

        }

        private void label_Class_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void PanelBar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
