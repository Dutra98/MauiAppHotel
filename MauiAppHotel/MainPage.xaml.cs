namespace MauiAppHotel
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnSobreClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SobrePage());
        }
    }

}
