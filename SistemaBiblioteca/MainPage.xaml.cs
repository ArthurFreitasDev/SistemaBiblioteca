using SistemaBiblioteca.Resources.Banco;
using SistemaBiblioteca.Views;

namespace SistemaBiblioteca
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            
        }

        private void ContentPage_Loaded(object sender, EventArgs e)
        {
            Banco.CriarBanco();
        }

        private async void CadastroFuncionario(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CadastroFuncionario());
        }

        private async void CadastroAutor(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CadastrarAutor());
        }

        private async void CadastroCategoria(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CadastroCategoria());
        }
        private async void CadastroEditora(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CadastroEditora());
        }

        private async void CadastroPessoa(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CadastroPessoa());
        }

        private async void CadastroLivro(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CadastroLivro());
        }
    }

}
