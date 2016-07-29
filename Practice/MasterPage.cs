using System;

using Xamarin.Forms;

namespace Practice
{
	public class MasterPage : ContentPage
	{

		protected override void OnAppearing()
		{
			base.OnAppearing();
			this.Animate("SlideInLeft", (s) => Layout(new Rectangle(-1 * ((1 - s) * Width), Y, Width, Height)), 0, 600, Easing.SpringIn, null, null);
		}

		protected override void OnDisappearing()
		{
			base.OnDisappearing();

			this.Animate("", (s) => Layout(new Rectangle((s * Width) * -1, Y, Width, Height)), 16, 600, Easing.Linear, null, null);
		}
		public MasterPage()
		{
			Button btn = new Button();
			btn.Text = "ssss";
			Content = new StackLayout
			{
				
				Padding = new Thickness(10,10,10,10),
				BackgroundColor=Color.Silver,
				Children = {
					new Label { Text = "Hello ContentPage" },btn
				}
			};
			btn.Clicked += async (sender, e) => {
				await Navigation.PopAsync();
			};
		}
	}
}


