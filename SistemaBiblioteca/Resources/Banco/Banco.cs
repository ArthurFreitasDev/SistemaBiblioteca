using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.OS;
using Android.Views;
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

        public static void DisplayAlert(string v1, string message, string v2)
        {
            throw new NotImplementedException();
        }

        public static void AbrirConexao()
        {
            try
            {
                Conexao = new MySqlConnection("server=localhost;port=3307;uid=root,pwd=etecjau");
            }
            catch(Exception ex)
            {
                DisplayAlert("Erro", ex.Message, "OK");
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
                DisplayAlert("Erro", ex.Message, "OK");
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
            }
            catch (Exception ex)
            {
                DisplayAlert("Erro", ex.Message, "OK");
            }
        }
    }
}
