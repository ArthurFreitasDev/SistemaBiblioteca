using SistemaBiblioteca.Models;

namespace SistemaBiblioteca.Views;

public partial class CadastroEditora : ContentPage
{
    Editora d;
	public CadastroEditora()
	{
		InitializeComponent();
	}

    private void btnCadastroEditora(object sender, EventArgs e)
    {
        try
        {
            if (txtNome.Text == null)
            {
                DisplayAlert("Ops", "Preencha todos os campos!", "OK");
            }
            else
            {
                d = new Editora()
                {
                    Nome = txtNome.Text
                };
                d.AdicionarEditora();
                txtNome.Text = "";
            }
        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "OK");
        }
    }
}