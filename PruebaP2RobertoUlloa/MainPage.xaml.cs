namespace PruebaP2RobertoUlloa
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
        }



        private async void OnChistesClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ChistePage());
        }

        private async void OnAboutClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GridLayout());
        }

    }
}


