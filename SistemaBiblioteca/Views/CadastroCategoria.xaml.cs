using SistemaBiblioteca.Models;

namespace SistemaBiblioteca.Views;

public partial class CadastroCategoria : ContentPage
{
    Categoria c;
	public CadastroCategoria()
	{
		InitializeComponent();
	}

    private void btnCadastoCategoria(object sender, EventArgs e)
    {
        try
        {
            if (txtNome.Text == null)
            {
                DisplayAlert("Ops", "Preencha todos os campos!", "OK");
            }
            else
            {
                c = new Categoria()
                {
                    Nome = txtNome.Text
                };
                c.AdicionarCategoria();
                txtNome.Text = "";
            }
        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "OK");
        }
    }
}