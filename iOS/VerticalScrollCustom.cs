using System;
using Practice;
using Practice.iOS;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;


[assembly: ExportRenderer(typeof(VerticalScroll), typeof(VerticalScrollCustom))]
namespace Practice.iOS
{
	public class VerticalScrollCustom : ScrollViewRenderer
	{
		public VerticalScrollCustom()
		{
			ShowsHorizontalScrollIndicator = false;
			ShowsVerticalScrollIndicator = false;
		}
	}
}


