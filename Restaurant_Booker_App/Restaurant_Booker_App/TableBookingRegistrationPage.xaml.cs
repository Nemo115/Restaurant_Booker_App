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
    public partial class TableBookingRegistrationPage : ContentPage
    {
        public TableBookingRegistrationPage()
        {
            InitializeComponent();
        }

        private void bookingButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new NavigationPage(new MainPage()));
        }

        private void cancelButton_Clicked(object sender, EventArgs e)
        {

        }
    }
}