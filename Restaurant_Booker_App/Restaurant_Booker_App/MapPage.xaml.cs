using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Restaurant_Booker_App
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MapPage : ContentPage
    {
        private string[] menuListPasser;
        public MapPage(string name, string[] menuList)
        {
            InitializeComponent();
            menuListPasser = menuList;
            RestaurantMap1(name);
        }

        private void infoButton_Clicked(object sender, EventArgs e)
        {
            if (tableKey.IsVisible == false)
            {
                tableKey.IsVisible = true;
            }
            else if (tableKey.IsVisible == true)
            {
                tableKey.IsVisible = false;
            }
        }

        private void BookButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MenuPreOrderPage(menuListPasser));
        }

        private void RestaurantMap1(string mapName)
        {
            switch (mapName)
            {
                case "Ching's Seafood":
                    mapImage.Source = ImageSource.FromResource("Restaurant_Booker_App.images.tableMaps.Pmap2.jpg");
                    break;
                case "Deli 4 U":
                    mapImage.Source = ImageSource.FromResource("Restaurant_Booker_App.images.tableMaps.Pmap3.jpg");
                    break;
                case "Meal Thai":
                    mapImage.Source = ImageSource.FromResource("Restaurant_Booker_App.images.tableMaps.1Pmap1.jpg");
                    break;
            }
        }
    }
}