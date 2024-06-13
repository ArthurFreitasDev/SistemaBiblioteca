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

        private void PaginaPessoas(object sender, EventArgs e)
        {

        }

        private void PaginaLivros(object sender, EventArgs e)
        {

        }

        private async void PaginaCadastros(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Cadastros());
        }
    }

}
