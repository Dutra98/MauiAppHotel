namespace MauiAppHotel.Views;

public partial class HospedagemContratada : ContentPage
{
	public HospedagemContratada()
	{
		InitializeComponent();
	}

    private void Button_Voltar(object sender, EventArgs e)
    {
        try
        {
            Navigation.PopAsync();

        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "OK");
        }
    }

    private async void Button_Finalizar(object sender, EventArgs e)
    {
        string suite = "Suíte Super Luxo";
        int adultos = 2;
        int criancas = 1;
        DateTime checkin = new DateTime(2024, 5, 27);
        DateTime checkout = new DateTime(2024, 5, 30);
        double valor = 750.00;

        await Navigation.PushAsync(new ResumoHospedagem(suite, adultos, criancas, checkin, checkout, valor));
    }
}