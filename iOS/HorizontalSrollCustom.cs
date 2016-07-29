using System;
using Practice;
using Practice.iOS;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;


[assembly: ExportRenderer(typeof(HorizontalScroll), typeof(HorizontalSrollCustom))]
namespace Practice.iOS
{
	public class HorizontalSrollCustom : ScrollViewRenderer
	{
		public HorizontalSrollCustom()
		{
			ShowsHorizontalScrollIndicator = false;
			ShowsVerticalScrollIndicator = false;
		}
	}
}


