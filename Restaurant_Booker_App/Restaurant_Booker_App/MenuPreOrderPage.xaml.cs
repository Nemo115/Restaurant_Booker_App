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
    public partial class MenuPreOrderPage : ContentPage
    {
        string[] orderedFood;
        int totalCost;

        const string seperatorString = "##";
        public MenuPreOrderPage(string[] menuList)
        {
            InitializeComponent();
            /*List<string> sampleMenu = new List<string>();
            foreach (string i in menuList)
            {
                sampleMenu.Add(i);
            }*/

            foreach (string i in menuList)
            {
                string[] foodAndPrice = i.Split(seperatorString.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                menuScrollStack.Children.Add(new StackLayout 
                {
                    Children = { 
                            new Label { Text = $"{foodAndPrice[0]}", VerticalOptions = LayoutOptions.Center, HorizontalOptions = LayoutOptions.Center, FontFamily = "Times New Roman"},
                            new Label{ Text = $"{foodAndPrice[1]}", VerticalOptions = LayoutOptions.Center, HorizontalOptions = LayoutOptions.Center, FontFamily = "Times New Roman"},
                            new StackLayout{ Children = 
                                { new Button{Text = "add", HorizontalOptions = LayoutOptions.EndAndExpand, FontFamily = "Times New Roman"} ,
                                  new Button{ Text = "remove",HorizontalOptions = LayoutOptions.EndAndExpand, FontFamily = "Times New Roman"}
                                }, Orientation = StackOrientation.Horizontal, HorizontalOptions = LayoutOptions.EndAndExpand } 
                    }, 
                    Orientation = StackOrientation.Horizontal, HorizontalOptions = LayoutOptions.FillAndExpand, VerticalOptions = LayoutOptions.Center, Margin = new Thickness(10,0,10,0)
                });
            }
        }

        private void yButton_Clicked(object sender, EventArgs e)
        {
            menuOrderQuestion.IsVisible = false;
            menuGrid.IsVisible = true;
        }

        private void nButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TableBookingRegistrationPage());
        }

        private void orderButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RegistrationPage());
        }
    }
}