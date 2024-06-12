using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Mysqlx;
using SistemaBiblioteca.Models;
using SistemaBiblioteca.Views;

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

                Comando = new MySqlCommand("create table if not exists Autor(idAutor int auto_increment,Nome varchar(40),primary key (idAutor)\r\n);\r\n\r\ncreate table if not exists Editora(\r\nidEditora int auto_increment,\r\nNome varchar(40),\r\nprimary key(idEditora)\r\n);\r\n\r\ncreate table if not exists Categoria(\r\nidCategoria int auto_increment,\r\nNome varchar(40),\r\nprimary key (idCategoria)\r\n);\r\n\r\ncreate table if not exists Livro(\r\nidLivro int auto_increment,\r\nTitulo varchar(40),\r\nDisponibilidade boolean,\r\nSinopse varchar(40),\r\nidEditora int,\r\nidAutor int,\r\nidCategoria int,\r\nprimary key (idLivro),\r\nforeign key (idEditora) references Editora(idEditora),\r\nforeign key (idAutor) references Autor(idAutor),\r\nforeign key (idCategoria) references Categoria(idCategoria)\r\n);\r\n\r\ncreate table if not exists Pessoa(\r\nidPessoa  int auto_increment,\r\nRMRG int,\r\nNome varchar(40),\r\nCondicao boolean,\r\nTempoBanimento date,\r\nQuantidadeLivrosRestantes int,\r\nprimary key (idPessoa)\r\n);\r\n\r\ncreate table if not exists Retirada(\r\nidRetirada int auto_increment,\r\nTempo date,\r\nDataRetirada date,\r\nidPessoa int,\r\nidLivro int,\r\nprimary key (idRetirada),\r\nforeign key (idPessoa) references Pessoa(idPessoa),\r\nforeign key (idLivro) references Livro(idLivro)\r\n);\r\n\r\ncreate table if not exists Funcionario(\r\nidFuncionario int auto_increment,\r\nNome varchar(40),\r\nSenha varchar(40),\r\nprimary key (idFuncionario) \r\n);", Conexao);
                Comando.ExecuteNonQuery();
                FecharConexao();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Erro!" + ex.Message);
            }
        }

        public async static void getAllGeneros()
        {
            try
            {
                AbrirConexao();
                Comando = new MySqlCommand("SELECT * FROM Categoria;");

                using (var result = Comando.ExecuteReader())
                {
                    Categoria c = new Categoria();
                    c.idCategoria = result.GetInt32("idCategoria");
                    c.Nome = result.GetString("Nome");
                    Debug.WriteLine("Aqui: "+ result.GetInt32("idCategoria") + ":" + result.GetString("Nome"));
                    Categoria.list_cat.Add(c);
                }
            }
            catch (MySqlException e)
            {
                Debug.WriteLine(e.Message);
            }
        }
    }
}
