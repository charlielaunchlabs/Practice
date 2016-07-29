using System;

using Xamarin.Forms;

namespace Practice
{
	public class NavButton : ContentView
	{
		private const int size = 30;
		public NavButton() { }
		public NavButton(string s)
		{
			Image image = new Image
			{
				HorizontalOptions = LayoutOptions.FillAndExpand,
				VerticalOptions = LayoutOptions.FillAndExpand,
				Source = s,

			};
			Button button = new Button
			{
				HorizontalOptions = LayoutOptions.FillAndExpand,
				VerticalOptions = LayoutOptions.FillAndExpand,
				BackgroundColor = Color.Red,
				HeightRequest = size,
				WidthRequest = size,

			};
			button.Clicked += delegate
			{
				button.Opacity = .5;
				button.FadeTo(1);
			};
			AbsoluteLayout.SetLayoutFlags(image, AbsoluteLayoutFlags.PositionProportional);
			AbsoluteLayout.SetLayoutBounds(image, new Rectangle(0, 0, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));
			AbsoluteLayout.SetLayoutFlags(button, AbsoluteLayoutFlags.PositionProportional);
			AbsoluteLayout.SetLayoutBounds(button, new Rectangle(0, 0, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));
			Content = new AbsoluteLayout
			{
				Children = {
					button,
					image
				},
			};
		}
	}
}


