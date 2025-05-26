namespace MauiAppHotel.Views;

public partial class ResumoHospedagem : ContentPage
{
    public ResumoHospedagem(string suite, int adultos, int criancas, DateTime checkin, DateTime checkout, double valor)
    {
        InitializeComponent();

        int noites = (checkout - checkin).Days;

        lblSuite.Text = $"Suíte: {suite}";
        lblHospedes.Text = $"Adultos: {adultos} | Crianças: {criancas}";
        lblCheckin.Text = $"Check-in: {checkin:dd/MM/yyyy}";
        lblCheckout.Text = $"Check-out: {checkout:dd/MM/yyyy}";
        lblNoites.Text = $"Total de noites: {noites}";
        lblValor.Text = $"Valor Total: R$ {valor:F2}";
    }

    private async void OnFinalizarClicked(object sender, EventArgs e)
    {
        await DisplayAlert("Reserva Confirmada", "Sua hospedagem foi registrada com sucesso!", "OK");
        await Navigation.PopToRootAsync();
    }
}
