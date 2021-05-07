using Caixa.Data.Interface;
using Caixa.Domain;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Caixa.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContaCorrenteController : ControllerBase
    {
        private readonly IContaCorrenteRepository _repo;

        public ContaCorrenteController(IContaCorrenteRepository repo)
        {
            _repo = repo;

        }

        [HttpGet]
        public IEnumerable<ContaCorrente> Get()
        {
            return _repo.SelecionarTudo();
        }

        [HttpGet("{id}")]
        public ContaCorrente Get(int id)
        {
            return _repo.Selecionar(id);
        }

        [HttpPost]
        public IEnumerable<ContaCorrente> Post([FromBody] ContaCorrente contaCorrente)
        {
            _repo.Incluir(contaCorrente);
            return _repo.SelecionarTudo();
        }

        [HttpPut]
        public IEnumerable<ContaCorrente> Put([FromBody] ContaCorrente contaCorrente)
        {
            _repo.Alterar(contaCorrente);
            return _repo.SelecionarTudo();
        }

        [HttpDelete]
        public IEnumerable<ContaCorrente> Delete(int id)
        {
            _repo.Excluir(id);
            return _repo.SelecionarTudo();
        }
    }
}