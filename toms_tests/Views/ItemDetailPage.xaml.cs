using System;
using System.Collections.Generic;
using toms_tests.Models;
using toms_tests.Services;
using Xamarin.Forms;

namespace toms_tests.Views
{
    public partial class ItemDetailPage : ContentPage
    {

        public Item Item { get; set; }

		/// <summary>
		/// Get the azure service instance
		/// </summary>
		public IDataStore<Item> DataStore => DependencyService.Get<IDataStore<Item>>();

        public ItemDetailPage(Item item = null)
        {

            Item = item;

            InitializeComponent();

            BindingContext = this;
        }

		int quantity = 1;
		public int Quantity
		{
			get { return quantity; }
            // Commenting out because SetProperty was causing an error and I don't have time to fix
			//set { SetProperty(ref quantity, value); }
		}
    }
}
