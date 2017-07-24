using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace toms_tests.Views
{
    public partial class BoxModelsPage : ContentPage
    {
        public BoxModelsPage()
        {
            InitializeComponent();
        }

		void Clicked_Stack(object sender, EventArgs e)
		{
			Navigation.PushAsync(new BoxModelPage_Stack());
		}
		void Clicked_Absolute(object sender, EventArgs e)
		{
			Navigation.PushAsync(new BoxModelPage_Absolute());
		}
		void Clicked_Relative(object sender, EventArgs e)
		{
			Navigation.PushAsync(new BoxModelPage_Relative());
		}
		void Clicked_Grid(object sender, EventArgs e)
		{
			Navigation.PushAsync(new BoxModelPage_Grid());
		}
		void Clicked_Scroll(object sender, EventArgs e)
		{
			Navigation.PushAsync(new BoxModelPage_ScrollView());
		}
		void Clicked_Custom(object sender, EventArgs e)
		{
			Navigation.PushAsync(new BoxModelPage_Custom_WrapLayout());
		}
		void Clicked_ImpactDetailLayout(object sender, EventArgs e)
		{
			Navigation.PushAsync(new ImpactDetailLayoutPage());
		}
		void Clicked_LoginLayout(object sender, EventArgs e)
		{
			Navigation.PushAsync(new LoginLayoutPage());
		}
		void Clicked_Bluetooth(object sender, EventArgs e)
		{
			Navigation.PushAsync(new BluetoothPage());
		}
		void Clicked_Carousel(object sender, EventArgs e)
		{
			Navigation.PushAsync(new CarouselViewPage());
		}
		void Clicked_Picker(object sender, EventArgs e)
		{
			Navigation.PushAsync(new PickerDemoPage());
		}
		void Clicked_HorizontalScrollView(object sender, EventArgs e)
		{
			Navigation.PushAsync(new HorizontalScrollViewPage());
		}
    }
}
