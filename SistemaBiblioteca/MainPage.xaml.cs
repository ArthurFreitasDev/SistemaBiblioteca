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

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CadastroFuncionario());
            Banco.CriarBanco();
        }
    }

}
