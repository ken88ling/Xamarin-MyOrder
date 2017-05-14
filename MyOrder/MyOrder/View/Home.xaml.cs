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
    public partial class Home : ContentPage
    {
        private Button btnHome;
        public Home()
        {
            
            InitializeComponent();

           
            

            Title = "Hierarchical Navigation";

            Label homeLabel = new Label()
            {
                Text = "Home Page",
                FontSize = 30
            };

            btnHome = new Button()
            {
                Text = "Select Ware house...",
                FontSize = 25,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };

            btnHome.Clicked += async (sender, args) => 
            await Navigation.PushAsync(new WareHousePage());

            StackLayout stackLayout = new StackLayout()
            {
                Children =
                {
                    homeLabel,
                    btnHome
                }
            };
            
            this.Content = stackLayout;
        }

       
    }
}
