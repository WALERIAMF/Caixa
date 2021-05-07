using Caixa.Data.Interface;
using Caixa.Data.Repository;
using Caixa.Domain.Model;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Caixa.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContaCorrenteClienteController : ControllerBase
    {
        private readonly IContaCorrenteClienteRepository _repo;

        public ContaCorrenteClienteController(IContaCorrenteClienteRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IEnumerable<ContaCorrenteCliente> Get()
        {
            return _repo.SelecionarTudo();
        }

        [HttpGet("{id}")]
        public ContaCorrenteCliente Get(int id)
        {
            return _repo.Selecionar(id);
        }

        [HttpPost]
        public IEnumerable<ContaCorrenteCliente> Post([FromBody] ContaCorrenteCliente contaCorrenteCliente)
        {
            _repo.Incluir(contaCorrenteCliente);
            return _repo.SelecionarTudo();
        }

        [HttpPut]
        public IEnumerable<ContaCorrenteCliente> Put([FromBody] ContaCorrenteCliente contaCorrenteCliente)
        {
            _repo.Alterar(contaCorrenteCliente);
            return _repo.SelecionarTudo();
        }

        [HttpDelete]
        public IEnumerable<ContaCorrenteCliente> Delete(int id)
        {
            _repo.Excluir(id);
            return _repo.SelecionarTudo();
        }
    }
}
