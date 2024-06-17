using SistemaBiblioteca.Models;
using SistemaBiblioteca.Resources.Banco;

namespace SistemaBiblioteca.Views;

public partial class CadastroLivro : ContentPage
{

	
	public CadastroLivro()
	{
		InitializeComponent();

		Banco.getAllGeneros();
	}


}