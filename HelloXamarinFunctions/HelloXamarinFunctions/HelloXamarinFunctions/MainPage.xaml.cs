using System.Net.Http;
using Xamarin.Forms;

namespace HelloXamarinFunctions
{
    public partial class MainPage : ContentPage
	{
        private const string Url = "YOUR URL HERE";

        public MainPage()
		{
			InitializeComponent();

            GoButton.Clicked += async (s, e) =>
            {
                ResultText.Text = "Please wait";

                var client = new HttpClient();

                var result = await client.GetStringAsync(
                    Url.Replace("{name}", FirstNameText.Text));

                ResultText.Text = result;
            };
		}
	}
}
