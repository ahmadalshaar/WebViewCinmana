using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebViewCinmana.Droid;
using Xamarin.Forms;

[assembly: Dependency(typeof(DeviceSpecificService))]
namespace WebViewCinmana.Droid
{
    public class DeviceSpecificService : IDeviceSpecificService
    {
        public void ClearCookies()
        {
            Android.Webkit.CookieManager.Instance.RemoveAllCookie();
        }
    }
}