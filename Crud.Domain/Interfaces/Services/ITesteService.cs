using Crud.Domain.Entities;

namespace Crud.Domain.Interfaces.Services
{
    public interface ITesteService
    {
        Teste Criar(Teste teste);
        void Deletar(int id);
        Teste Visualizar(int id);
        Teste Alterar(Teste teste);

    }
}
