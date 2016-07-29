using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Practice
{
	public class VerticalScroll : ScrollView
	{
		public VerticalScroll()
		{

			Random rnd = new Random();
			var shorty = new List<string> { "Die Today", "Die Tomorrow", "Died Yesterday", "Just Die" };
			var longty = new List<string> { "Are You Sure .Realy Sure ?", "Worms Might  Love You", "Did SomeOne  care for you ?", "Mama wont  like it", "Have Some Respect", "Internet will  miss your sarcasm", "No one  really cares  No One", "Do it ... your helping  Earth's Demography" };
			var imagety = new List<string> { "s1.png", "s2.png" };

			StackLayout mainStack = new StackLayout();
			mainStack.Spacing = 12;
			mainStack.BackgroundColor = Color.White;
			mainStack.Orientation = StackOrientation.Vertical;

			for (int i = 0; i < 5; i++)
			{

				StackLayout Vstack1 = new StackLayout()
				{
					Orientation = StackOrientation.Horizontal,
					HeightRequest = 133,
					HorizontalOptions = LayoutOptions.FillAndExpand,
					BackgroundColor = Color.FromHex("E6E6E6"),
					Children =
				{
					new Image
					{
						HeightRequest = 133,
						WidthRequest = 133,
						BackgroundColor=Color.White,
							Source = imagety[rnd.Next(imagety.Count)]
					},
					new StackLayout
					{
						Orientation = StackOrientation.Vertical,
						Padding = new Thickness(10, 10, 10, 10),
						Spacing =20,
						Children =
						{
							new StackLayout
							{
								Orientation = StackOrientation.Vertical,
									HeightRequest=80,
								Children =
								{
									new Label
									{
											TextColor = Color.FromRgb(95,177,219),
										FontSize = 17,
											Text = longty[rnd.Next(longty.Count)]
									},
									new Label
									{
										TextColor = Color.Black,
										FontSize = 10,
										Text = shorty[rnd.Next(shorty.Count)]
									}
								}
							},
							new StackLayout
							{
								Orientation = StackOrientation.Horizontal,
								HorizontalOptions= LayoutOptions.FillAndExpand,

								Children =
								{
									new StackLayout
									{
										Orientation = StackOrientation.Vertical,
										HorizontalOptions=LayoutOptions.Start,
										Children =
										{
											new StackLayout
											{
												Orientation=StackOrientation.Horizontal,
													WidthRequest=170,
												Children =
												{
													new Image
													{
														Source = "coupondownloads.png"
													},
													new Label
													{
														TextColor = Color.Black,
														FontSize = 10,
														Text = shorty[rnd.Next(shorty.Count)]
													}
												}
											},
											new StackLayout
											{
												Orientation=StackOrientation.Horizontal,
													WidthRequest=170,
												Children =
												{
													new Image
													{
														Source = "couponexpiry.png"
													},
													new Label
													{
														TextColor = Color.Black,
														FontSize = 10,
														Text = shorty[rnd.Next(shorty.Count)]
													}
												}
											}
										}
									},
										new StackLayout
										{
											//BackgroundColor=Color.Blue,
											HorizontalOptions=LayoutOptions.End,
											Children =
											{
												new CirlcleImage()
											}
										}

								},
							}

						}

					}
				}
				};
				mainStack.Children.Add(Vstack1);
			}

			Content = mainStack;

		}
	}
}


