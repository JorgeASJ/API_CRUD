using System;

namespace Crud.Domain.Entities
{
    public class Teste
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string NovoNome { get; set; }
        public string SobreNome { get; set; }
        public string NovoSobreNome { get; set; }
        public string Email { get; set; }
        public string NovoEmail { get; set; }
        public int Idade { get; set; }
        public int NovaIdade { get; set; }
        public DateTime DtCadastro { get; set; }
    }
}
