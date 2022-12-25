using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace WebViewCinmana
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            //img1.Source = new UriImageSource
            //{
            //    Uri = new Uri("https://shstore.com/assets/img/shabakaty_logo.png?fbclid=IwAR0-JsGSqi0U4PTUkGpIW3H8PM4Wi5-2yWTvF2aRUYKcbbUJhjrBhd4rIhE"),
            //    CachingEnabled = true,
            //    CacheValidity = new TimeSpan(0, 0, 1, 0)
            //};
           // DependencyService.Get<IDeviceSpecificService>().ClearCookies();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new WebView(), true);
        }

        private async void ImageButton_Clicked(object sender, EventArgs e)
        {
            await Browser.OpenAsync("https://iraqi.net/gobb", new BrowserLaunchOptions
            {
                LaunchMode = BrowserLaunchMode.SystemPreferred,
                TitleMode = BrowserTitleMode.Show,
                PreferredToolbarColor = Color.FromHex("4F92C9"),
                PreferredControlColor = Color.Violet,
            });
        }

    }
}
