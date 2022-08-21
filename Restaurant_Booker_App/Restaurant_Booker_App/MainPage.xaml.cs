using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Restaurant_Booker_App.RestaurantDataFolder;

namespace Restaurant_Booker_App
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            List<RestaurantInfo> sampleList = new List<RestaurantInfo>
            {
                new RestaurantInfo{ Name = "Ching's Seafood", Location = "Kew", OpeningTimes = 8.15, ClosedTimes = 9.10, Cuisine = "Seafood", imageUrl = "Gimlet_2.png", 
                    menuList = new string[] {"Fish and Chips##9", "Salmon##12", "Fish Burger##14" } },
                new RestaurantInfo{ Name = "Deli 4 U", Location = "Camberwell", OpeningTimes = 9, ClosedTimes = 9.10, Cuisine = "Deli", 
                menuList = new string[] {"Ham##8", "Cheese##10", "avacado and shrimp##12", "sardines##5"} },
                new RestaurantInfo{ Name = "Meal Thai", Location = "Warrandyte", OpeningTimes = 11.30, ClosedTimes = 8, Cuisine = "Thai", 
                    menuList = new string[]{ "Thai Noodles##12", "human corpse##50", "Thai Beef##13", "homeless man (1209 calories, vegan, halal)##6"} },
                new RestaurantInfo{ Name = "Woo's Noodles", Location = "Sydney", OpeningTimes = 12, ClosedTimes = 11, Cuisine = "Chinese"},
                new RestaurantInfo{ Name = "The Godfather", Location = "Belgrave", OpeningTimes = 12, ClosedTimes = 9, Cuisine = "Italian"},
            };
            restaurantList.ItemsSource = sampleList;
        }

        private void restaurantList_ItemSelected(object sender, ItemTappedEventArgs e)
        {
            var selectedRestaurant = e.Item as RestaurantInfo;
            Navigation.PushAsync(new MapPage(selectedRestaurant.Name, selectedRestaurant.menuList));
        }
    }
}