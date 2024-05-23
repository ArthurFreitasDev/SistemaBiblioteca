using MySql.Data.MySqlClient;
using SistemaBiblioteca.Resources.Banco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBiblioteca.Models
{
    public class Pessoa
    {
        public int idPessoa { get; set; }
        public int RmRg { get; set; }
        public string Nome { get; set; }
        public bool Condicao { get; set; }
        public string TempoBanimento { get; set; }
        public int QuantidadeLivrosRestantes { get; set; }

        public void AdicionarPessoa()
        {
            try
            {
                Banco.AbrirConexao();
                Banco.Comando = new MySqlCommand("INSERT INTO Funcionario (RMRG, Nome, Condicao, TempoBanimento, QuantidadeLivrosRestantes) VALUES (@RmRg, @Nome, @Condicao, @TempoBanimento, @QuantidadesLivrosRestantes)", Banco.Conexao);
                Banco.Comando.Parameters.AddWithValue("@RmRg", RmRg);
                Banco.Comando.Parameters.AddWithValue("@Nome", Nome);
                Banco.Comando.Parameters.AddWithValue("@Condicao", Condicao);
                Banco.Comando.Parameters.AddWithValue("@TempoBanimento", TempoBanimento);
                Banco.Comando.Parameters.AddWithValue("@QuantidadeLivrosRestantes", QuantidadeLivrosRestantes);
                Banco.Comando.ExecuteNonQuery();
                Banco.FecharConexao();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Erro!==========" + ex.Message);
            }
        }
    }
}
