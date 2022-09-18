using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WebViewCinmana
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WebView : ContentPage
    {             
        /// <summary>
        /// Bindable property for <see cref="IsLoading" />.
        /// </summary>
        public static readonly BindableProperty IsLoadingProperty = BindableProperty.Create(
            nameof(IsLoading),
            typeof(bool),
            typeof(MainPage),
            defaultValue: true);
        public WebView()
        {
            InitializeComponent();
            BindingContext = this;
            var current = Connectivity.NetworkAccess;

            if (current == NetworkAccess.Internet)
            {
                src.Source = "https://www.iraqi.net/Cinemana.htm?fbclid=IwAR1PbwGLEHdf6vktjhYZbA4wUw9xTvEysSHqhVzbHizfEGglaALLo2nPTLo";
            }
            else
            {

                App.Current.MainPage.DisplayAlert("تنبيه", "لا يوجد اتصال بالانترنت", "نعم");
            }
        }
        /// <summary>
        /// Gets or sets a value indicating whether the web viewer is loading.
        /// </summary>
        public bool IsLoading
        {
            get => (bool)GetValue(IsLoadingProperty);
            set => SetValue(IsLoadingProperty, value);
        }

        private void OnWebViewNavigated(object sender, EventArgs eventArgs)
        {
            IsLoading = false;
        }
        protected override  bool OnBackButtonPressed()
        {
            if (src.CanGoBack)
                src.GoBack();
            else
                 Navigation.PopAsync();
            return true;
        }
    }
}