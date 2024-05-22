using SistemaBiblioteca.Models;

namespace SistemaBiblioteca.Views;

public partial class CadastroPessoa : ContentPage
{
	public CadastroPessoa()
	{
		InitializeComponent();
	}

    private void btnAdicionarPessoa(object sender, EventArgs e)
    {
        Pessoa p;
        try
        {
            if (txtNome.Text == null)
            {
                DisplayAlert("Ops", "Preencha todos os campos!", "OK");
            }
            else
            {
                p = new Pessoa()
                {
                    RmRg = int.Parse(txtRMRG.Text),
                    Nome = txtNome.Text,
                    QuantidadeLivrosRestantes = int.Parse(txtQuantidadeLivros.Text)
                };
                p.AdicionarPessoa();
                txtNome.Text = "";
            }
        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "OK");
        }
    }
}