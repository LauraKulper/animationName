using Android.App;
using Android.Widget;
using Android.OS;
using Android.Graphics.Drawables;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

namespace animationName
{
    [Activity(Label = "animationName", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
           /* SetContentView(Resource.Layout.Main);
            AppCenter.Start("bf13c198-9a20-4140-955b-52ebf2ceb707",
                   typeof(Analytics), typeof(Crashes));*/
        }

        /*public override void OnWindowFocusChanged(bool hasFocus)
        {
            if (hasFocus)
            {
                ImageView imageView = FindViewById<ImageView>(Resource.Id.animated_android);
                AnimationDrawable animation = (AnimationDrawable)imageView.Drawable;
                animation.Start();
            }
        }*/
    }
}

