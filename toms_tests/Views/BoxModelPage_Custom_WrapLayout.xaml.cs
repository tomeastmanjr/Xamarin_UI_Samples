using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using toms_tests.Models;
using Xamarin.Forms;

namespace toms_tests.Views
{
    public partial class BoxModelPage_Custom_WrapLayout : ContentPage
    {
        public BoxModelPage_Custom_WrapLayout()
        {
            InitializeComponent();
        }

		protected override async void OnAppearing()
		{
			base.OnAppearing();

			var images = await GetImageListAsync();
			foreach (var photo in images.Photos)
			{
				var image = new Image
				{
					Source = ImageSource.FromUri(new Uri(photo + string.Format("?width={0}&height={0}&mode=max", Device.OnPlatform(240, 240, 120))))
				};
				wrapLayout.Children.Add(image);
			}
		}

		async Task<ImageList> GetImageListAsync()
		{
			var requestUri = "https://docs.xamarin.com/demo/stock.json";
			using (var client = new HttpClient())
			{
				var result = await client.GetStringAsync(requestUri);
				return JsonConvert.DeserializeObject<ImageList>(result);
			}
		}
    }
}
