using Crud.Domain.Entities;

namespace Crud.Domain.Interfaces.Repository
{
    public interface ITesteRepository
    {
        int Criar(Teste teste);
        int Deletar(Teste teste);
        int Alterar(Teste teste);
        int Visualizar(Teste teste);

    }
}
