namespace MauiAppHotel.Views;

public partial class ContratacaoHospedagem : ContentPage
{
    App PropriedadesApp; //Variável App para acessar as propriedades(lisra de quarros) criadas na classe App.xaml.cs

    public ContratacaoHospedagem()
	{
		InitializeComponent();

        PropriedadesApp = (App)Application.Current; // Atribui a instância(especifica) atual do aplicativo à variável PropriedadesApp para acessar suas propriedades

        pck_quarto.ItemsSource = PropriedadesApp.Lista_quartos; // Define de onde virá a lista de quartos para o Picker "pck_quarto"

        dtpck_checkin.MinimumDate = DateTime.Now;
        dtpck_checkin.MaximumDate = DateTime.Now.AddMonths(1);

        dtpck_checkout.MinimumDate = DateTime.Now.AddDays(1);
        dtpck_checkout.MaximumDate = DateTime.Now.AddMonths(6);
    }

    private async void Button_Clicked(object sender, EventArgs e) // Evento de clique do botão "Sobre"
    {
		await Navigation.PushAsync(new Sobre()); // Navega para a página "Sobre" quando o botão for clicado
    }

    [Obsolete]
    private void Button_Clicked_1(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new HospedagemContratada());

        } catch (Exception ex)
            {
                DisplayAlertAsync("Ops",ex.Message, "OK");
            }
    }

    private void dtpck_checkin_DateSelected(object sender, DateChangedEventArgs e)
    {
        DatePicker elemento = sender as DatePicker;

        DateTime data_selecionada_checkin = (DateTime)elemento.Date;

        dtpck_checkout.MinimumDate = data_selecionada_checkin.AddDays(1);
        dtpck_checkout.MaximumDate = data_selecionada_checkin.AddMonths(6);


    }
}