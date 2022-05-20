using Crud.Domain.Entities;
using Crud.Domain.Interfaces.Repository;
using Crud.Shared;
using Dapper;
using System.Data.SqlClient;
using System.Linq;

namespace Crud.Infra.Data.Repository
{
    public class TesteRepository:ITesteRepository
    {
        public int Criar(Teste teste)
        {
            var query = @"insert into Teste (Nome, SobreNome, Email, Idade, DtCadastro)
                         values(@Nome, @SobreNome, @Email, @idade, GetDate())
                        select SCOPE_IDENTITY() ";

            using (var conn = new SqlConnection(Settings.ConnectionString))
            {
                conn.Open();

                return conn.Query<int>(query,
                    new
                    {
                        Nome = teste.Nome,
                        Sobrenome = teste.SobreNome,
                        Email = teste.Email,
                        Idade = teste.Idade
                    }).FirstOrDefault();
            }


        }
        public int Deletar(Teste teste)
        {
            var query = @"Delete from Teste Where id =(Select id from Teste where nome = @Nome and sobrenome = @sobrenome and email = @email )
                        select SCOPE_IDENTITY() ";

            using (var conn = new SqlConnection(Settings.ConnectionString))
            {
                conn.Open();

                return conn.Query<int>(query,
                    new
                    {
                        Nome = teste.Nome,
                        Sobrenome = teste.SobreNome,
                        Email = teste.Email
                    }).FirstOrDefault();
            }


        }
        public int Alterar(Teste teste)
        {
            var query = @"update Teste set nome = @NovoNome, sobrenome = @NovoSobrenome, email = @NovoEmail, idade = @Novaidade
                        Where nome = @Nome and sobrenome = @sobrenome 
                        select SCOPE_IDENTITY() ";

            using (var conn = new SqlConnection(Settings.ConnectionString))
            {
                conn.Open();

                return conn.Query<int>(query,
                    new
                    {
                        Nome = teste.Nome,
                        Sobrenome = teste.SobreNome,
                        Email = teste.Email,
                        Idade = teste.Idade
                    }).FirstOrDefault();
            }


        }
        public int Visualizar(Teste teste)
        {
            var query = @"select Nome, SobreNome, Email, Idade, DtCadastro
                          where nome = @Nome, sobrenome = @sobrenome, email = @email, idade - @idade
                        select SCOPE_IDENTITY() ";

            using (var conn = new SqlConnection(Settings.ConnectionString))
            {
                conn.Open();

                return conn.Query<int>(query,
                    new
                    {
                        Nome = teste.Nome,
                        Sobrenome = teste.SobreNome,
                        Email = teste.Email,
                        Idade = teste.Idade
                    }).FirstOrDefault();
            }


        }
    }
}
