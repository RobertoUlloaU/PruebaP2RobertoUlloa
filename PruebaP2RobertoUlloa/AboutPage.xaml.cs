namespace PruebaP2RobertoUlloa;

public partial class AboutPage : ContentPage
{
	public AboutPage()
	{
		InitializeComponent();
	}
	private async void OnBackButtonClicked(object sender, EventArgs e)
{
    await Shell.Current.GoToAsync("///MainPage");
}
}