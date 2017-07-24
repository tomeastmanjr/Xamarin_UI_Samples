using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Input;
using toms_tests.Helpers;
using Xamarin.Forms;

namespace toms_tests.Views
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();

			SignInCommand = new Command(async () => await SignIn());
			NotNowCommand = new Command(App.GoToMainPage);
        }

		string message = string.Empty;
		public string Message
		{
			get { return message; }
			set { message = value; OnPropertyChanged(); }
		}

		public ICommand NotNowCommand { get; }
		public ICommand SignInCommand { get; }

		async Task SignIn()
		{
			try
			{
				IsBusy = true;
				Message = "Signing In...";

				// Log the user in
				await TryLoginAsync();
			}
			finally
			{
				Message = string.Empty;
				IsBusy = false;

				if (Settings.IsLoggedIn)
					App.GoToMainPage();
			}
		}

		public static async Task<bool> TryLoginAsync()
		{
			return true;
		}
    }
}
