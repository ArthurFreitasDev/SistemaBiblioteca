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
                Comando = new MySqlCommand("create database if not exists Biblioteca;", Conexao);
                Comando.ExecuteNonQuery();
                Comando = new MySqlCommand("use Biblioteca;", Conexao);
                Comando.ExecuteNonQuery();

                Comando = new MySqlCommand("create table if not exists Funcionario(idFuncionario int auto_increment,Nome varchar(40),Senha varchar(40),primary key (idFuncionario));", Conexao);
                Comando.ExecuteNonQuery();
                Comando = new MySqlCommand("create table if not exists Autor(idAutor int auto_increment,Nome varchar(40),primary key (idAutor));", Conexao);
                Comando.ExecuteNonQuery();
                Comando = new MySqlCommand("create table if not exists Categoria(idCategoria int auto_increment,Nome varchar(40),primary key (idCategoria));", Conexao);
                Comando.ExecuteNonQuery();
                Comando = new MySqlCommand("create table if not exists Pessoa(idPessoa  int auto_increment,RMRG int,Nome varchar(40),Condicao boolean,TempoBanimento date,QuantidadeLivrosRestantes int,primary key (idPessoa));", Conexao);
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
