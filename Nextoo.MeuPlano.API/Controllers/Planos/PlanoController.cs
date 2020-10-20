using Microsoft.AspNetCore.Mvc;
using Nextoo.MeuPlano.DAL.Repository.Planos.IRepository;
using Nextoo.MeuPlano.Dominio.Planos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Nextoo.MeuPlano.API.Controllers.Planos
{
    [Route("api/planos/v1")]
    public class PlanoController : Controller
    {
        private readonly IPlanoRepository _planoRepository;

        public PlanoController(IPlanoRepository planoRepository)
        {
            _planoRepository = planoRepository;
        }

        [Route("BuscarTodos")]
        [HttpGet]
        public IEnumerable<Plano> BuscarTodos()
        {
            return _planoRepository.BuscarTodos();
        }

        [HttpPost]
        [Consumes("application/json")]
        [Route("Adicionar")]
        public void Adicionar([FromBody]Plano plano)
        {
            _planoRepository.Adicionar(plano);
        }

        [HttpPost]
        [Consumes("application/json")]
        [Route("Atualizar")]
        public void Atualizar([FromBody]Plano plano)
        {
            _planoRepository.Atualizar(plano);
        }

        [HttpDelete]
        [Consumes("application/json")]
        [Route("Remover")]
        public void Remover([FromBody]decimal id)
        {
            _planoRepository.Remover(id);
        }

        [Route("BuscarOperadora")]
        [Consumes("application/json")]
        [HttpGet]
        public IEnumerable<Plano> BuscaPorOperadora([FromBody]string operadora)
        {
            return _planoRepository.Buscar(x => x.Operadora == operadora);
        }

        [Route("BuscarTipo")]
        [Consumes("application/json")]
        [HttpGet]
        public IEnumerable<Plano> BuscaPorTipo([FromBody]string tipo)
        {
            return _planoRepository.Buscar(x => x.Tipo == tipo);
        }

        [Route("BuscarDDD")]
        [Consumes("application/json")]
        [HttpGet]
        public IEnumerable<Plano> BuscaPorDDD([FromBody]string DDD)
        {
            return _planoRepository.Buscar(x => x.DDD == DDD);
        }

    }
}
