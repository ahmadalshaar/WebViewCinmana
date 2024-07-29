using OneSignalSDK.Xamarin;
using OneSignalSDK.Xamarin.Core;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WebViewCinmana
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            try
            {
                OneSignal.Default.Initialize("ffb1188e-3d8c-41ad-9f58-0cea1882f269");

                OneSignal.Default.PromptForPushNotificationsWithUserResponse();
            }
            catch(Exception ex)
            {

            }
            MainPage = new NavigationPage(new MasterDetail());
        }

        private async void HandleNotificationReceived(Notification notification)
        {
            try
            {
                string str1 = notification.title;
                string str2 = notification.body;

                await App.Current.MainPage.DisplayAlert(str1, str2, "نعم");
            }
            catch (Exception ex)
            { }
        }

        private async void HandleNotificationOpened(NotificationOpenedResult result)
        {
            try
            {
                string str1 = result.notification.title;
                string str2 = result.notification.body;

                await App.Current.MainPage.DisplayAlert(str1, str2, "نعم");
            }
            catch (Exception ex)
            { }
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
