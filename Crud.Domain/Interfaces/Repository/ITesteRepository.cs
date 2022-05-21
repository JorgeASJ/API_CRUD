using Crud.Domain.Entities;

namespace Crud.Domain.Interfaces.Repository
{
    public interface ITesteRepository
    {
        int Criar(Teste teste);
        int Deletar(int id);
        Teste Alterar(Teste teste);
        Teste Visualizar(int id);

    }
}
