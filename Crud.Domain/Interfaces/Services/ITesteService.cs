using Crud.Domain.Entities;

namespace Crud.Domain.Interfaces.Services
{
    public interface ITesteService
    {
        Teste Criar(Teste teste);
        Teste Deletar(Teste teste);
        Teste Visualizar(Teste teste);
        Teste Alterar(Teste teste);

    }
}
