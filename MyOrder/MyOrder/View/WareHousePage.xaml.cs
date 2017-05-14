using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyOrder.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyOrder.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WareHousePage : ContentPage
    {
        //ObservableCollection<WareHouse>wareHouses = new ObservableCollection<WareHouse>();

        public WareHousePage()
        {
            //InitializeComponent();


            Title = "Hierarchical Navigation";

            Label homeLabel = new Label()
            {
                Text = "Warehouse Page",
                FontSize = 30
            };

            ListView listView = new ListView();
            
            listView.ItemsSource = new WareHouse[]
            {
                new WareHouse(){ Id = 1, WarehouseName = "Malaysia WH"},
                new WareHouse(){Id = 2, WarehouseName = "Singapore WH"},
                new WareHouse(){Id = 3,WarehouseName = "Thailand"}
            };

            listView.ItemTemplate = new DataTemplate(typeof(TextCell));
            listView.ItemTemplate.SetBinding(TextCell.TextProperty, "Id");
            listView.ItemTemplate.SetBinding(TextCell.TextProperty, "WarehouseName");

            // event click
            listView.ItemTapped += async (sender, args) =>
            {
                var item = args.Item as WareHouse;
                if(item ==null)return;
                await Navigation.PushAsync(new WareHouseDetailPage(item));
                listView.SelectedItem = null;
            };

            StackLayout stackLayout = new StackLayout()
            {
                Children =
                {
                    homeLabel,
                    listView
                }
            };

            this.Content = stackLayout;
        }
    }
}
