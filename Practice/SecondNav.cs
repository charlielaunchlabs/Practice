using System;

using Xamarin.Forms;

namespace Practice
{
	public class SecondNav : StackLayout
	{
		public SecondNav()
		{
			this.HeightRequest = 30;
			this.Padding = new Thickness(10, 10, 0, 10);
			this.Orientation = StackOrientation.Horizontal;
			this.BackgroundColor = Color.White;
			this.VerticalOptions = LayoutOptions.Center;
			this.Children.Add(new Image {VerticalOptions=LayoutOptions.Center, Source = "coupondownloads.png" });
			StackLayout stack2 = new StackLayout();
			VerticalOptions = LayoutOptions.Center;
			stack2.Spacing = 0;
			stack2.BackgroundColor = Color.White;
			stack2.Orientation = StackOrientation.Horizontal;
			Label az = new Label { VerticalOptions = LayoutOptions.Center, TextColor = Color.FromRgb(244, 128, 36), FontSize = 11, Text = "A to Z", BackgroundColor = Color.White };
			Label newest = new Label { VerticalOptions = LayoutOptions.Center, TextColor = Color.FromRgb(244, 128, 36), FontSize = 11, Text = "Newest", BackgroundColor = Color.White };
			StackLayout stack3 = new StackLayout();
			stack3.BackgroundColor = Color.Gray;
			stack3.VerticalOptions = LayoutOptions.CenterAndExpand;
			stack3.Orientation = StackOrientation.Horizontal;
			stack3.Spacing = 0.9;
			stack3.Children.Add(new StackLayout { Padding = new Thickness(10, 0, 10, 0), BackgroundColor = Color.White, VerticalOptions = LayoutOptions.Fill, Children = { az } });
			stack3.Children.Add(new StackLayout { Padding = new Thickness(10, 0, 10, 0), BackgroundColor = Color.White, VerticalOptions = LayoutOptions.Fill, Children = { newest } });
			stack2.Children.Add(stack3);
			this.Children.Add(stack2);

		}
	}
}


