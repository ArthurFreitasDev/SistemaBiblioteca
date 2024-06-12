using MySql.Data.MySqlClient;
using SistemaBiblioteca.Resources.Banco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBiblioteca.Models
{
    public class Categoria
    {
        public int idCategoria {  get; set; }
        public string Nome { get; set; }

        public static List<Categoria> list_cat = new List<Categoria>();


        public void AdicionarCategoria()
        {
            try
            {
                Banco.AbrirConexao();
                Banco.Comando = new MySqlCommand("INSERT INTO Categoria (Nome) VALUES (@Nome)", Banco.Conexao);
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
