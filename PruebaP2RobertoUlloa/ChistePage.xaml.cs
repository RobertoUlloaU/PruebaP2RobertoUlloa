using global::PruebaP2RobertoUlloa.Model;
using System.Net.Http;
using System.Text.Json;

namespace PruebaP2RobertoUlloa;

public partial class ChistePage : ContentPage
{
    private readonly HttpClient _httpClient = new HttpClient();

    public ChistePage()
    {
        InitializeComponent();
        ObtenerChiste(); // Cargar uno automaticamente
    }

    private async void OnObtenerChisteClicked(object sender, EventArgs e)
    {
        await ObtenerChiste();
    }

    private async Task ObtenerChiste()
    {
        try
        {
            string url = "https://official-joke-api.appspot.com/jokes/random";
            var respuesta = await _httpClient.GetAsync(url);

            
        }
        catch (Exception ex)
        {
            await DisplayAlert("Error", ex.Message, "OK");
        }
    }
}
