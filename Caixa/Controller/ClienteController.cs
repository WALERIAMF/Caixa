using Caixa.Data.Interface;
using Caixa.Data.Repository;
using Caixa.Domain;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Caixa.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteRepository _repo;

        public ClienteController(IClienteRepository repo)
        {
            _repo = repo;

        }

        [HttpGet]
        public IEnumerable<Cliente> Get()
        {
            return _repo.SelecionarTudo();
        }

        [HttpGet("{id}")]
        public Cliente Get(int id)
        {
            return _repo.Selecionar(id);
        }

        [HttpPost]
        public IEnumerable<Cliente> Post([FromBody] Cliente cliente)
        {
            _repo.Incluir(cliente);
            return _repo.SelecionarTudo();
        }

        [HttpPut]
        public IEnumerable<Cliente> Put([FromBody] Cliente cliente)
        {
            _repo.Alterar(cliente);
            return _repo.SelecionarTudo();
        }

        [HttpDelete]
        public IEnumerable<Cliente> Delete(int id)
        {
            _repo.Excluir(id);
            return _repo.SelecionarTudo();
        }
    }
}
