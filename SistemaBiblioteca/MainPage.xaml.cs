﻿using SistemaBiblioteca.Resources.Banco;
using SistemaBiblioteca.Views;

namespace SistemaBiblioteca
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            
        }

        private void ContentPage_Loaded(object sender, EventArgs e)
        {
            Banco.CriarBanco();
        }

        private async void Funcionario(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CadastroFuncionario());
        }

        private async void Autor(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CadastrarAutor());
        }

        private async void Categoria(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CadastroCategoria());
        }
        private void Editora(object sender, EventArgs e)
        {

        }
    }

}
