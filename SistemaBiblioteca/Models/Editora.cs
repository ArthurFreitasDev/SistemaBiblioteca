using MySql.Data.MySqlClient;
using SistemaBiblioteca.Resources.Banco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBiblioteca.Models
{
    public class Editora
    {
        public int idEditora { get; set; }
        public string Nome { get; set; }

        public void AdicionarEditora()
        {
            try
            {
                Banco.AbrirConexao();
                Banco.Comando = new MySqlCommand("INSERT INTO Editora (Nome) VALUES (@Nome)", Banco.Conexao);
                Banco.Comando.Parameters.AddWithValue("@Nome", Nome);
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
