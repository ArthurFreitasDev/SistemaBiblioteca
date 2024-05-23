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
            if (txtNome.Text == null || txtNome.Text == "" || txtQuantidadeLivros.Text == null || txtQuantidadeLivros.Text == "" || txtRMRG.Text == null || txtRMRG.Text == "")
            {
                DisplayAlert("Ops", "Preencha todos os campos!", "OK");
            }
            else
            {
                p = new Pessoa()
                {
                    RmRg = int.Parse(txtRMRG.Text),
                    Nome = txtNome.Text,
                    QuantidadeLivrosRestantes = int.Parse(txtQuantidadeLivros.Text),
                    Condicao = true,
                    TempoBanimento = DateTimeKind(20,10,2000)
                };
                p.AdicionarPessoa();
                txtNome.Text = "";
                txtQuantidadeLivros.Text = "";
                txtRMRG.Text = "";
            }
        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "OK");
        }
    }
}