using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using toms_tests.Helpers;
using toms_tests.Models;
using toms_tests.Services;
using Xamarin.Forms;

namespace toms_tests.Views
{
    public partial class ItemsPage : ContentPage
    {

		public ObservableRangeCollection<Item> Items { get; set; }
		public Command LoadItemsCommand { get; set; }

		/// <summary>
		/// Get the azure service instance
		/// </summary>
		public IDataStore<Item> DataStore => DependencyService.Get<IDataStore<Item>>();

		public ItemsPage()
		{

			Title = "Browse";
			Items = new ObservableRangeCollection<Item>();
			LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());

			MessagingCenter.Subscribe<NewItemPage, Item>(this, "AddItem", async (obj, item) =>
			{
				var _item = item as Item;
				Items.Add(_item);
				await DataStore.AddItemAsync(_item);
			});

			InitializeComponent();

			BindingContext = this;
		}

		async void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
		{
			var item = args.SelectedItem as Item;
			if (item == null)
				return;

			await Navigation.PushAsync(new ItemDetailPage(item));

			// Manually deselect item
			ItemsListView.SelectedItem = null;
		}

		async void AddItem_Clicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new NewItemPage());
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();

			if (Items.Count == 0)
				LoadItemsCommand.Execute(null);
		}

		async Task ExecuteLoadItemsCommand()
		{
			if (IsBusy)
				return;

			IsBusy = true;

			try
			{
				Items.Clear();
				var items = await DataStore.GetItemsAsync(true);
				Items.ReplaceRange(items);
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex);
				MessagingCenter.Send(new MessagingCenterAlert
				{
					Title = "Error",
					Message = "Unable to load items.",
					Cancel = "OK"
				}, "message");
			}
			finally
			{
				IsBusy = false;
			}
		}
    }
}
