namespace MauiAppHotel.Views;

public partial class ContratacaoHospedagem : ContentPage
{
	public ContratacaoHospedagem()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e) // Evento de clique do botão "Sobre"
    {
		await Navigation.PushAsync(new Sobre()); // Navega para a página "Sobre" quando o botão for clicado
    }
}