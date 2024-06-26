namespace SistemaBiblioteca.Views;

using SistemaBiblioteca.Models;
using SistemaBiblioteca.Resources.Banco;

public partial class CadastroFuncionario : ContentPage
{
    Funcionarios f;
	public CadastroFuncionario()
	{
		InitializeComponent();
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
                    txtNome.Text = "";
                    txtSenha.Text = "";
                    txtConfirmarSenha.Text = "";
                }
                else
                {
                    DisplayAlert("Senhas diferentes", "As senhas est�o diferentes", "OK");
                }
            }
        }
        catch(Exception ex)
        {
            await DisplayAlert("ERRO!", ex.Message, "OK");
        }
    }
}