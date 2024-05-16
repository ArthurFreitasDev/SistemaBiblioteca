using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Mysqlx;

namespace SistemaBiblioteca.Resources.Banco
{
    public class Banco
    {
        public static MySqlConnection Conexao;
        public static MySqlCommand Comando;
        public static MySqlDataAdapter Adaptador;
        public static DataTable datTable;

        public static async void AbrirConexao()
        {
            try
            {
                Conexao = new MySqlConnection("server=localhost;port=3307;uid=root;pwd=etecjau");

                Conexao.Open();
            }
            catch(Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Erro!==========" + ex.Message);
            }
        }

        public static void FecharConexao()
        {
            try
            {
                Conexao.Close();
            }
            catch(Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Erro!" + ex.Message);
            }
        }

        public static void CriarBanco()
        {
            try
            {
                AbrirConexao();
                Comando = new MySqlCommand("create database if not exists Biblioteca;use Biblioteca;", Conexao);
                Comando.ExecuteNonQuery();

                Comando = new MySqlCommand("create table if not exists Funcionario(idFuncionario int auto_increment,Nome varchar(40),Senha varchar(40),primary key (idFuncionario));", Conexao);
                Comando.ExecuteNonQuery();
                FecharConexao();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Erro!" + ex.Message);
            }
        }
    }
}
