using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyOrder.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyOrder.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WareHouseDetailPage : ContentPage
    {
        public WareHouseDetailPage(WareHouse item)
        {
            InitializeComponent();
            

            Label titleLabel = new Label()
            {
                Text = item.WarehouseName,
                FontSize = 40
            };

            Label descLabel = new Label()
            {
                Text = item.Id + " " + item.WarehouseName,
                FontSize = 30
            };

            StackLayout stackLayout = new StackLayout()
            {
                Children =
                {
                    titleLabel,
                    descLabel
                }
            };

            this.Content = stackLayout;

        }
    }
}
