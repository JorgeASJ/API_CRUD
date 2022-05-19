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
    }
}
