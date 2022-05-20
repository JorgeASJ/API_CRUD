using Crud.Domain.Entities;
using Crud.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace Crud.API.Controllers
{
    [ApiController]
    [Route("v1/[controller]")]
    public class TesteController : Controller
    {
        private readonly ITesteService _testeService;

        public TesteController(ITesteService testeService)
        {
            _testeService = testeService;
        }

        [HttpPost]
        [Route("criar")]
        public Teste Criar([FromBody] Teste teste)
        {
            return _testeService.Criar(teste);
        }

        [HttpGet]
        [Route("Visualizar")]
        public Teste Visualizar([FromBody] Teste teste)
        {
            return _testeService.Visualizar(teste);
        }

        [HttpPost]
        [Route("Alterar")]
        public Teste Alterar([FromBody] Teste teste)
        {
            return _testeService.Alterar(teste);
        }

        [HttpPost]
        [Route("Deletar")]
        public Teste Deletar([FromBody] Teste teste)
        {
            return _testeService.Deletar(teste);
        }
    }
}
