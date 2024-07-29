using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WebViewCinmana
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterDetail : MasterDetailPage
    {
        public MasterDetail()
        {
            InitializeComponent();

            IsPresented = false;
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var otherPage = new provicyapp(); // Create the page with translate 600 to animate later
            otherPage.TranslationY = 1000;
            await Navigation.PushAsync(otherPage, false); // Push the new page, as the current page is already with 0 opacity, without animation
            await otherPage.TranslateTo(0, 0, 700, Easing.Linear); // Animate the fade of the next page   
            IsPresented = false;
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            var otherPage = new aboutapp(); // Create the page with translate 600 to animate later
            otherPage.TranslationY = 1000;
            await Navigation.PushAsync(otherPage, false); // Push the new page, as the current page is already with 0 opacity, without animation
            await otherPage.TranslateTo(0, 0, 700, Easing.Linear); // Animate the fade of the next page   
            IsPresented = false;

        }

        private async void Button_Clicked_2(object sender, EventArgs e)
        {
            var otherPage = new Contant(); // Create the page with translate 600 to animate later
            otherPage.TranslationY = 1000;
            await Navigation.PushAsync(otherPage, false); // Push the new page, as the current page is already with 0 opacity, without animation
            await otherPage.TranslateTo(0, 0, 700, Easing.Linear); // Animate the fade of the next page   
            IsPresented = false;
        }
    }
}