using System;
using Practice;
using Practice.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;


[assembly: ExportRenderer(typeof(TransparentButton), typeof(CustomTransparentButton))]
namespace Practice.Droid
{
	public class CustomTransparentButton : ButtonRenderer
	{
		protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
		{
			base.OnElementChanged(e);
			if (Control != null)
			{
				Control.SetBackgroundColor(global::Android.Graphics.Color.Transparent);
				Control.SetBackgroundResource(Resource.Drawable.CC);
			}
		}
	}
}

