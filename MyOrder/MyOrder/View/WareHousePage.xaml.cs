using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyOrder.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WareHousePage : ContentPage
    {
        public WareHousePage()
        {
            InitializeComponent();

            Title = "Hierarchical Navigation";

            Label homeLabel = new Label()
            {
                Text = "Warehouse Page",
                FontSize = 30
            };

            StackLayout stackLayout = new StackLayout()
            {
                Children =
                {
                    homeLabel
                }
            };
            this.Content = stackLayout;
        }
    }
}
