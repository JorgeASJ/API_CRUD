using Crud.Domain.Entities;
using Crud.Domain.Interfaces.Repository;
using Crud.Domain.Interfaces.Services;

namespace Crud.Domain.Services
{
    public class TesteService: ITesteService
    {
        private readonly ITesteRepository _testeRepository;

        public TesteService(ITesteRepository testeRepository)
        {
            _testeRepository = testeRepository;
        }

        public Teste Criar(Teste teste)
        {
            _testeRepository.Criar(teste);
            return teste;
        }

    }
}
