using Android.App;
using Android.Content;
using Android.Content.Res;
using Android.Graphics;
using Android.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using CustomRender.android;
using System.Reflection;
using HealthMinder;
using Android.Graphics.Drawables;

[assembly: ExportRenderer(typeof(CustomEntry), typeof(CustomEntryRender))]

namespace CustomRender.android
{
    public class CustomEntryRender : EntryRenderer
    {
        public CustomEntryRender(Context context) : base(context)
        {

        }
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                GradientDrawable gradientDrawable = new GradientDrawable();
                gradientDrawable.SetColor(global::Android.Graphics.Color.Transparent);
                Control.SetBackground(gradientDrawable);
                this.Control.SetRawInputType(InputTypes.TextFlagNoSuggestions);
                Control.SetHintTextColor(global::Android.Graphics.Color.Black);
            }
        }
    }
}