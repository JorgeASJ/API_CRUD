using Crud.Domain.Entities;
using System.Collections.Generic;

namespace Crud.Domain.Interfaces.Services
{
    public interface ITesteService
    {
        Teste Criar(Teste teste);
        void Deletar(int id);
        Teste Visualizar(int id);
        Teste Alterar(Teste teste);
        List<Teste> Listar();
    }
}
