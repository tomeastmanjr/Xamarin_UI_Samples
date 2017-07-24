using System;
using System.Collections;
using System.Collections.Generic;
using toms_tests.Models;

using Xamarin.Forms;

namespace toms_tests.Views
{
    public partial class HorizontalScrollViewPage : ContentPage
    {

		public bool IsVisible
		{
            get; set;
		}

		public Item SelectedItem
		{
			get; set;
		}

		public IEnumerable Items
		{
            get; set;
		}

		public void ItemSelected_ExecuteCommand(object args)
		{
			SelectedItem = args as Item;
		}


        public HorizontalScrollViewPage()
        {
            InitializeComponent();


			//this.IsVisible = false;
			Items = new Item_HSV[] {
				new Item_HSV{Image = "http://www.clubparadiso.it/upload/CONF66/20150909/Green_Island_Resort_Barriera_corallina-tSa-80X80.jpg", Name="Barriera Corallina" },
				new Item_HSV{Image = "http://www.clubparadiso.it/upload/CONF66/20150515/Vahine_Island_Resort-tSa-80X80.jpg", Name="Barriera Corallina 1"},
				new Item_HSV{Image = "http://neckeropen.com/wp-content/uploads/2015/04/necker-island-810x320-80x80.jpg", Name="Barriera Corallina 2"},
				new Item_HSV{Image = "http://media.apkseeker.com/apps/personalization/76119/w80-76119.jpg", Name="Barriera Corallina 3"},
				new Item_HSV{Image = "http://4everstatic.com/immagini/80x80/natura/barriera-corallina,-pesci-colorati-148311.jpg", Name="Barriera Corallina 4"},
				new Item_HSV{Image = "http://www.clubparadiso.it/upload/CONF66/20150729/Yasawa_Islands_Resort_e_SPA_giardino-tSa-80X80.jpg", Name="Barriera Corallina 5"},
				new Item_HSV{Image = "http://thailandluxe.net/wp-content/uploads/2015/06/Bamboo-Island1-e1434357108153-80x80.jpg", Name="Barriera Corallina 6"},
				new Item_HSV{Image = "http://www.amando.it/imagesdyn/gallery_plus/80x80/12/80/la-grande-barriera-corallina-dellaustralia_128073.jpg", Name="Barriera Corallina 7"},
				new Item_HSV{Image = "http://tartapedia.it/wp-content/themes/arthemia-premium/scripts/timthumb.php?src=/http://tartapedia.it/wp-content/uploads/2013/06/PROTEGGIAMO-LA-BARRIERA-CORALLINA.jpg&w=80&h=80&zc=1&q=100", Name="Barriera Corallina 7"},
				new Item_HSV{Image = "http://www.amando.it/imagesdyn/gallery_plus/80x80/12/80/belize-blue-hole_128072.jpg", Name="Barriera Corallina 7"}
			};

			BindingContext = this;

		}


		protected override void OnAppearing()
		{
			base.OnAppearing();

			//Entry1.NextView = Entry2;
			//Entry1.ReturnButton = ReturnButtonType.Next;

			//Entry2.NextView = Entry3;
			//Entry2.ReturnButton = ReturnButtonType.Next;

			//Entry3.NextView = Entry1;
			//Entry3.ReturnButton = ReturnButtonType.Next;

			//this.Body.Children.Add(Entry1);
			//this.Body.Children.Add(Entry2);
			//this.Body.Children.Add(Entry3);
		}

		void Handle_ItemSelected(object sender, Xamarin.Forms.ItemTappedEventArgs e)
		{
			DisplayAlert("Item Selezionato", (e.Item as Item_HSV).Name, "cancel");
		}
	}




}
