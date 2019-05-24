using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taxi.UserControls
{
    public partial class PriceUC : UserControl
    {
        public PriceUC()
        {
            InitializeComponent();
            
        }

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
            label_Distance.Text = $"{RouteUC.distance}";
            label_Class.Text = SelectAutoUC._class;
            price_count();
            labelTotalPrice.Text = $"{sum}";
        }
    }
}
