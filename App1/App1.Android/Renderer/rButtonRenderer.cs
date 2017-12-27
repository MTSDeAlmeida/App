
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
[assembly: ExportRenderer(typeof(Button), typeof(App1.Droid.Renderer.rButtonRenderer))]
namespace App1.Droid.Renderer
{
    public class rButtonRenderer : ButtonRenderer
    {
        protected override void OnDraw(Android.Graphics.Canvas canvas)
        {
            base.OnDraw(canvas);
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);
        }
    }
}