using System;
using System.Reflection;
using Android.Widget;
using Practice;
using Practice.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;


[assembly: ExportRenderer(typeof(HorizontalScroll), typeof(HorizontalCustom))]
namespace Practice.Droid
{
	public class HorizontalCustom : ScrollViewRenderer
	{
		HorizontalScrollView sad;
		 
		protected override void OnElementChanged(VisualElementChangedEventArgs e)
		{
			base.OnElementChanged(e);
			if (e.NewElement == null)
				return;
			e.NewElement.PropertyChanged +=  HandlePropertyChangedEventHandler;

		}


		void HandlePropertyChangedEventHandler(object sender, System.ComponentModel.PropertyChangedEventArgs e)
		{
			if (e.PropertyName == "Renderer")
			{
				sad = (HorizontalScrollView)typeof(ScrollViewRenderer)
					.GetField("hScrollView", BindingFlags.NonPublic | BindingFlags.Instance)
					.GetValue(this);
				sad.HorizontalScrollBarEnabled = false;

			}
		}
	}
}

