using Crud.Domain.Entities;
using Crud.Domain.Interfaces.Repository;
using Crud.Domain.Interfaces.Services;
using System.Collections.Generic;

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
            var idTeste = _testeRepository.Criar(teste);

            var consulta = _testeRepository.Visualizar(idTeste);

            return consulta;
        }
        public void Deletar(int id)
        {
            _testeRepository.Deletar(id);
         
        }
        public Teste Alterar(Teste teste)
        {
            _testeRepository.Alterar(teste);
            return teste;
        }
        public Teste Visualizar(int id)
        {
            return  _testeRepository.Visualizar(id);
        }
        public List<Teste> Listar()
        {
            return _testeRepository.Listar();
        }
    }
}
