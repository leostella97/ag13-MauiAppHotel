using MauiAppHotel.Views; // namespace das páginas de navegação

namespace MauiAppHotel
{
    public partial class MainPage : ContentPage
    {
        // constructor da página inicial
        public MainPage()
        {
            InitializeComponent(); // inicia os componentes XAML
        }

        // navega para a tela de contratação de reserva
        private async void OnReservarClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ContratacaoHospedagem()); // empilha a página de reserva
        }

        // navega para a tela de reserva contratada
        private async void OnReservaClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Aviso", "Faça uma reserva primeiro!", "OK"); // alerta
        }

        // navega para a tela "Sobre" onde tem as info
        private async void OnSobreClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Sobre()); // empilha a página sobre
        }

        // exibe informações de contato do hotel
        private async void OnContatoClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Contato",
                "📞 (11) 4002-8922\n📧 contato@hotelmaui.com",
                "OK"); // exibe alerta com dados de contato com o telefone do yudi que vai dar playstation 2
        }
    }
}
