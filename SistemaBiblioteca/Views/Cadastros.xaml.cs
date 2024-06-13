namespace SistemaBiblioteca.Views;

public partial class Cadastros : ContentPage
{
	public Cadastros()
	{
		InitializeComponent();
	}

    private async void AdicionarLivro(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CadastroLivro());
    }

    private async void AdicionarEditora(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CadastroEditora());
    }

    private async void AdicionarCategoria(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CadastroCategoria());
    }

    private async void AdicionarPessoa(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CadastroPessoa());
    }

    private async void AdicionarAutor(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CadastrarAutor());
    }
}