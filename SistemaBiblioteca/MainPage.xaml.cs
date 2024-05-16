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

        private async void Funcionario(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CadastroFuncionario());
            Banco.CriarBanco();
        }

        private async void Autor(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CadastrarAutor());
            Banco.CriarBanco();
        }

        private void Categoria(object sender, EventArgs e)
        {

        }
        private void Editora(object sender, EventArgs e)
        {

        }
    }

}
