using System;
using Xamarin.Forms;

namespace HolaMundo
{
	public class App
	{
		public static Page GetMainPage ()
		{	
			return new ContentPage { 
				Content = new Label {
					Text = " Amuchastegui Peñafiel Leticia Numero de cuenta 413071161  ",
					VerticalOptions = LayoutOptions.CenterAndExpand,
					HorizontalOptions = LayoutOptions.CenterAndExpand,
				},
			};
		}
	}
}

