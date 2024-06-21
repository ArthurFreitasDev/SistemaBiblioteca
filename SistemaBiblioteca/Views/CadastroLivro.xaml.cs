using SistemaBiblioteca.Models;
using SistemaBiblioteca.Resources.Banco;
using SistemaBiblioteca.Models;
using SistemaBiblioteca.Views;

namespace SistemaBiblioteca.Views;

public partial class CadastroLivro : ContentPage
{
	Editora e;
	
	public CadastroLivro()
	{
		InitializeComponent();

		Banco.getAllGeneros();
	}

    private void ContentPage_Loaded(object sender, EventArgs e)
    {
		e = new Editora()
		{
			
		}
    }
}