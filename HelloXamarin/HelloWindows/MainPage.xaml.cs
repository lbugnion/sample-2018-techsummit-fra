using HelloXamarin.Data;
using System;
using Windows.UI.Xaml.Controls;

namespace HelloWindows
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();

            RefreshButton.Click += async (s, e) =>
            {
                try
                {
                    MyText.Text = "Please wait";
                    var service = new YoutubeService();
                    MyText.Text = await service.Refresh();
                }
                catch (Exception ex)
                {
                    MyText.Text = ex.Message;
                }
            };
        }
    }
}
