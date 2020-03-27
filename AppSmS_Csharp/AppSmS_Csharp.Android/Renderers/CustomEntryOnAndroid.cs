using AppSmS_Csharp.Droid.Renderers;
using Xamarin.Forms;
using AppSmS_Csharp.Render;
using Xamarin.Forms.Platform.Android;
using Android.Content;
using Android.Graphics.Drawables;

[assembly: ExportRenderer(typeof(CustomEntry), typeof(CustomEntryOnAndroid))]
namespace AppSmS_Csharp.Droid.Renderers
{
    public class CustomEntryOnAndroid:EntryRenderer
    {
        public CustomEntryOnAndroid(Context context)
            :base(context)
        {
        }
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (Context != null)
                Control.Background = new ColorDrawable(Android.Graphics.Color.Transparent);
        }
    }

}