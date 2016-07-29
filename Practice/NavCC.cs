using System;

using Xamarin.Forms;

namespace Practice
{
	public class NavCC : StackLayout
	{
		private const int size = 30;

		public NavCC()
		{

			Button search = new Button {VerticalOptions = LayoutOptions.Center, Image = "searchicon.png" ,WidthRequest=size,HeightRequest=size, BackgroundColor = Color.Transparent };
			Button stak = new Button { VerticalOptions = LayoutOptions.Center, Image = "navcategoryicon.png",WidthRequest = size+4,HeightRequest = size, BackgroundColor=Color.Transparent};
			Button master = new Button { Image = "sidepanelicon.png",WidthRequest = size,BackgroundColor = Color.Transparent };
			this.HeightRequest = 40;
			this.BackgroundColor = Color.White;
			this.Padding = new Thickness(0,0,2,0);
			this.Orientation = StackOrientation.Horizontal;
			this.BackgroundColor = Color.FromRgb(6, 153, 230);
			this.Children.Add(new StackLayout {Padding = new Thickness(5,0,0,0),Children = {master} });
			this.Children.Add(new Label {HorizontalOptions=LayoutOptions.CenterAndExpand,VerticalOptions = LayoutOptions.Center,Text = "COUPONS",TextColor=Color.White,FontSize=11});
			this.Children.Add(new StackLayout {Padding = new Thickness(0, 0, 0, 0),Orientation=StackOrientation.Horizontal,Spacing=0,Children = { search,stak} });

			//master.Clicked += (sender, e) => {
			//	 Navigation.PushModalAsync(new MasterPage());

		}

	}
}

