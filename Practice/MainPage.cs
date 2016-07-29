using System;
using Xamarin.Forms;
namespace Practice
{
	public class MainPage : ContentPage
	{

		public MainPage()
		{
			NavCC top = new NavCC();
			SecondNav sec = new SecondNav();
			HorizontalScroll scroll = new HorizontalScroll();
			VerticalScroll vscroll = new VerticalScroll();

			StackLayout Main = new StackLayout();
			Main.Spacing = 0;
			Main.Orientation = StackOrientation.Vertical;
			Main.BackgroundColor = Color.White;
			StackLayout topV = new StackLayout();
			topV.Orientation = StackOrientation.Vertical;
			topV.Spacing = 0;
			topV.Padding = new Thickness(0, 20, 0, 0);
			topV.BackgroundColor = Color.FromRgb(6, 153, 230);
			topV.Children.Add(top);
			topV.Children.Add(scroll);
			topV.Children.Add(sec);
			Main.Children.Add(topV);
			Main.Children.Add(vscroll);

			RelativeLayout x = new RelativeLayout();
			x.VerticalOptions = LayoutOptions.FillAndExpand;
			x.HorizontalOptions = LayoutOptions.FillAndExpand;
			x.Children.Add(Main,
						   Constraint.RelativeToParent((p) => { return p.X; }),
			               Constraint.RelativeToParent((p) => { return p.Y; }),
			               Constraint.RelativeToParent((p) => { return p.Width;}),
			               Constraint.RelativeToParent((p) => { return p.Height; })
			              );
			CCircle cir = new CCircle();


			x.Children.Add(cir,
			               Constraint.RelativeToParent((p) => { return p.X + 260; }),
			               Constraint.RelativeToParent((p) => { return p.Y + 465; })
			              );
			
			Content = x;




		}


	}
}

