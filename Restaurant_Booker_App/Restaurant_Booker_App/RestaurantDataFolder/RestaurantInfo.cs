using System;
using System.Collections.Generic;
using System.Text;
using Xamarin;
using Xamarin.Forms;

namespace Restaurant_Booker_App.RestaurantDataFolder
{
    class RestaurantInfo
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public double OpeningTimes { get; set; }
        public double ClosedTimes { get; set; }
        public string Cuisine { get; set; }
        public string Availability { get; set; }
        public string imageUrl { get; set; }
        public string[] menuList { get; set; }

        public ImageSource Image
        {
            get { return ImageSource.FromResource(string.Format($"Restaurant_Booker_App.images.{0}", imageUrl)); }
        }
    }
}
