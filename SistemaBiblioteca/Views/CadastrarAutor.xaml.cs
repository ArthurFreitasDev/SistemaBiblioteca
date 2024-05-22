using SistemaBiblioteca.Models;

namespace SistemaBiblioteca.Views;

public partial class CadastrarAutor : ContentPage
{
    Autores a;
	public CadastrarAutor()
	{
		InitializeComponent();
	}

    private void btnAdicionarAutor(object sender, EventArgs e)
    {
		try
		{
            if (txtNome.Text == "" || txtNome.Text == null)
            {
                DisplayAlert("Ops", "Preencha todos os campos!", "OK");
            }
            else
            {
                a = new Autores()
                {
                    Nome = txtNome.Text,
                };
                a.AdicionarAutor();
                txtNome.Text = "";
            }
        }
        catch(Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "OK");
        }
    }
}