using System;

using Xamarin.Forms;

namespace Practice
{
	public class CirlcleImage : ContentView
	{
		private const int size = 30;
		public CirlcleImage()
		{
			Image image = new Image
			{
				HorizontalOptions = LayoutOptions.FillAndExpand,
				VerticalOptions = LayoutOptions.FillAndExpand,
				Source = ImageSource.FromFile("downloadbutton.png"),
				HeightRequest = size,
				WidthRequest = size
			};
			TransparentButton button = new TransparentButton
			{
				HorizontalOptions = LayoutOptions.FillAndExpand,
				VerticalOptions = LayoutOptions.FillAndExpand,
				BackgroundColor = Color.Transparent,
				HeightRequest = size,
				WidthRequest = size,
				BorderRadius = size / 2 + 1,
				BorderColor = Color.Red,
				BorderWidth = 0.7,

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


