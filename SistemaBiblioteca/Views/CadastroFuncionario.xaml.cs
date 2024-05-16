namespace SistemaBiblioteca.Views;

using SistemaBiblioteca.Models;
using SistemaBiblioteca.Resources.Banco;

public partial class CadastroFuncionario : ContentPage
{
    Funcionarios f;
	public CadastroFuncionario()
	{
		InitializeComponent();
        Banco.CriarBanco();
    }

    private async void AdicionarFuncionario(object sender, EventArgs e)
    {
        try
        {
            if (txtNome.Text == null || txtSenha == null || txtConfirmarSenha == null)
            {
                DisplayAlert("Ops", "Preencha todos os campos!", "OK");
            }
            else
            {
                if(txtSenha.Text == txtConfirmarSenha.Text)
                {
                    f = new Funcionarios()
                    {
                        Nome = txtNome.Text,
                        Senha = txtSenha.Text,

                    };
                    f.AdicionarFuncionario();
                }
            }
        }
        catch(Exception ex)
        {
            await DisplayAlert("ERRO!", ex.Message, "OK");
        }
    }
}