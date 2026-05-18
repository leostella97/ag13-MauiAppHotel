using MauiAppHotel.Models; // modelo de dados dos quartos

namespace MauiAppHotel
{
    public partial class App : Application
    {
        // lista de quartos disponíveis no hotel (compartilhada entre páginas)
        public List<Quarto> lista_quartos = new List<Quarto>
        {
            // suíte mais luxuosa com maior valor de diária
            new Quarto()
            {
                Descricao = "Suíte Super Luxo",
                ValorDiariaAdulto = 110.0,
                ValorDiariaCrianca = 55.0
            },
            // suíte luxo com valores intermediários
            new Quarto()
            {
                Descricao = "Suíte Luxo",
                ValorDiariaAdulto = 80.0,
                ValorDiariaCrianca = 40.0
            },
            // suíte individual para uma pessoa
            new Quarto()
            {
                Descricao = "Suíte Single",
                ValorDiariaAdulto = 50,
                ValorDiariaCrianca = 25
            },
            // suíte econômica com menor valor
            new Quarto()
            {
                Descricao = "Suíte Crise",
                ValorDiariaAdulto = 25,
                ValorDiariaCrianca = 12.5
            }
        };

        // construtor do App, ele define a página inicial
        public App()
        {
            InitializeComponent(); // inicializa recursos e estilos do app

            // define a MainPage (a index) como página inicial com navegação
            // NavigationPage permite navegação por pilha (Push/Pop)
            MainPage = new NavigationPage(new MainPage());
        }

        // cria a janela do aplicativo com dimensões fixas
        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState); // Cria janela base

            window.Width = 400;  // largura fixa da janela
            window.Height = 600; // altura fixa da janela

        /* tá aí uma coisa que passei mais tempo que resolvendo os bugs, achar a palavra correta, withd, witdh, heitgh, hetgh*/

            return window; // retorna janela configurada
        }
    }
}
