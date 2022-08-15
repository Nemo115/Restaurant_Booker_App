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
    }
}