namespace PruebaP2RobertoUlloa;

public partial class GridLayout : ContentPage
{
    public GridLayout()
    {
        InitializeComponent();

    }

    private async void OnBackButtonClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///ChistePage");
    }

}