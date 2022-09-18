using Com.OneSignal;
using Com.OneSignal.Abstractions; using System;
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
                OneSignal.Current.StartInit("ffb1188e-3d8c-41ad-9f58-0cea1882f269").HandleNotificationOpened(HandleNotificationOpened)
              .HandleNotificationReceived(HandleNotificationReceived)
              .Settings(new Dictionary<string, bool>() {
                { IOSSettings.kOSSettingsKeyAutoPrompt, false },
                { IOSSettings.kOSSettingsKeyInAppLaunchURL, false } })
              .InFocusDisplaying(OSInFocusDisplayOption.Notification)
              .EndInit();

                OneSignal.Current.RegisterForPushNotifications();
            }
            catch(Exception ex)
            {

            }
            MainPage = new NavigationPage(new MainPage());
        }

        private async void HandleNotificationReceived(OSNotification notification)
        {
            try
            {
                string str1 = notification.payload.title;
                string str2 = notification.payload.body;

                await App.Current.MainPage.DisplayAlert(str1, str2, "نعم");
            }
            catch (Exception ex)
            { }
        }

        private async void HandleNotificationOpened(OSNotificationOpenedResult result)
        {
            try
            {
                string str1 = result.notification.payload.title;
                string str2 = result.notification.payload.body;

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
