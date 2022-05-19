using Crud.Domain.Entities;

namespace Crud.Domain.Interfaces.Repository
{
    public interface ITesteRepository
    {
        int Criar(Teste teste);
    }
}
