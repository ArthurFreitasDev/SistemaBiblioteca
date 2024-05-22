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


        public void AdicionarFuncionario()
        {
            try
            {
                Banco.AbrirConexao();
                Banco.Comando = new MySqlCommand("INSERT INTO Funcionario (Nome, Senha) VALUES (@Nome, @Senha)", Banco.Conexao);
                Banco.Comando.Parameters.AddWithValue("@Nome", Nome);
                Banco.Comando.Parameters.AddWithValue("@Senha", Senha);
                Banco.Comando.ExecuteNonQuery();
                Banco.FecharConexao();
            }
            catch(Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Erro!==========" + ex.Message);
            }
        }
    }
}