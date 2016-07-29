using System;

using Xamarin.Forms;

namespace Practice
{
	public class AnimatedButton : ContentView
	{
		private Image _textLabel;
		private StackLayout _layout;

		/// <summary>
		/// Creates a new instance of the animation button
		/// </summary>
		/// <param name="text">the text to set</param>
		/// <param name="callback">action to call when the animation is complete</param>
		public AnimatedButton( Action callback = null)
		{
			// create the layout
			_layout = new StackLayout
			{
				VerticalOptions = LayoutOptions.Center,
				Orientation = StackOrientation.Horizontal,
				Padding = 5,
			};

			// create the label
			_textLabel = new Image
			{
				
				Source ="sidepanelicon.png",

			
			};

			_layout.Children.Add(_textLabel);

			// add a gester reco
			this.GestureRecognizers.Add(new TapGestureRecognizer
			{
				Command = new Command(async (o) =>
				{
					await this.ScaleTo(0.95, 50, Easing.CubicOut);
					await this.ScaleTo(1, 50, Easing.CubicIn);
					if (callback != null)
						callback.Invoke();
				})
			});

			// set the content
			this.Content = _layout;
		}

		///// <summary>
		///// Gets or sets the font size for the text
		///// </summary>
		//public virtual double FontSize
		//{
		//	get { return this._textLabel.FontSize; }
		//	set
		//	{
		//		this._textLabel.FontSize = value;
		//	}
		//}

		///// <summary>
		///// Gets or sets the text color for the text
		///// </summary>
		//public virtual Color TextColor
		//{
		//	get
		//	{
		//		return _textLabel.TextColor;
		//	}
		//	set
		//	{
		//		_textLabel.TextColor = value;
		//	}
		//}
	}
}


