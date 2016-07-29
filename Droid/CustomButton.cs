using System;
using Practice;
using Practice.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;


[assembly: ExportRenderer(typeof(CCButton), typeof(CustomButton))]
namespace Practice.Droid
{
	public class CustomButton : ButtonRenderer
	{
		protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
		{
			base.OnElementChanged(e);
			if (Control != null)
			{
				Control.SetBackgroundColor(global::Android.Graphics.Color.Transparent);
				Control.SetBackgroundResource(Resource.Drawable.Layout);
			}
		}

	}
}


