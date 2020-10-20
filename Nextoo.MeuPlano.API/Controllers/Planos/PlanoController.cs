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

    }
}
