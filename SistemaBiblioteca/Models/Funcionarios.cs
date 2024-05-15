using Android.Views;
using MySql.Data.MySqlClient;
using SistemaBiblioteca.Resources.Banco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBiblioteca.Models
{
    public class Funcionarios
    {
        public int idFuncionario { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }


        public async void AdicionarFuncionario()
        {
            try
            {
                Banco.AbrirConexao();
                Banco.Comando = new MySqlCommand("INSERT IN TO Funcionario (Nome) VALUES (@Nome)", Banco.Conexao);
                Banco.Comando.Parameters.AddWithValue("@Nome", Nome);
                Banco.Comando.ExecuteNonQuery();
                Banco.FecharConexao();
            }
            catch(Exception ex)
            {
                DisplayAlert("Erro", ex.Message, "OK");
            }
        }

        public static void DisplayAlert(string v1, string message, string v2)
        {
            throw new NotImplementedException();
        }
    }
}
