using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Webkit;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Essentials;
using static Android.Webkit.WebChromeClient;

namespace WebViewCinmana.Droid.Renderers
{
    public class FullScreenClient : WebChromeClient
    {
        readonly FrameLayout.LayoutParams matchParentLayout = new FrameLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent,
                                                                                                         ViewGroup.LayoutParams.MatchParent);
        readonly ViewGroup content;
        readonly ViewGroup parent;
        View customView;

        public FullScreenClient(ViewGroup parent, ViewGroup content)
        {
            this.parent = parent;
            this.content = content;

        }


        public override void OnShowCustomView(View view, ICustomViewCallback callback)
        {
            customView = view;
            view.LayoutParameters = matchParentLayout;
            parent.AddView(view);
            content.Visibility = ViewStates.Gone;
            MainActivity hideBar = (MainActivity)Platform.CurrentActivity;
            hideBar.Window.AddFlags(WindowManagerFlags.Fullscreen);


        }
    }
}