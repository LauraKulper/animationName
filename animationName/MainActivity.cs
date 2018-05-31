using Android.App;
using Android.Widget;
using Android.OS;
using Android.Graphics.Drawables;

namespace animationName
{
    [Activity(Label = "animationName", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);
        }

        public override void OnWindowFocusChanged(bool hasFocus)
        {
            if (hasFocus)
            {
                ImageView imageView = FindViewById<ImageView>(Resource.Id.animated_android);
                AnimationDrawable animation = (AnimationDrawable)imageView.Drawable;
                animation.Start();
            }
        }
    }
}

