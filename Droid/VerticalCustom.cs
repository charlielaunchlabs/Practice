using System;
using System.Reflection;
using Android.Widget;
using Practice;
using Practice.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;


[assembly: ExportRenderer(typeof(VerticalScroll), typeof(VerticalCustom))]
namespace Practice.Droid
{
	public class VerticalCustom : ScrollViewRenderer
	{

		Android.Widget.ScrollView sad;

		protected override void OnElementChanged(VisualElementChangedEventArgs e)
		{
			base.OnElementChanged(e);
			if (e.NewElement == null)
				return;
		
			this.VerticalScrollBarEnabled = false;
		}

	}
}

