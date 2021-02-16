using BlazorApp1.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DashboardController : ControllerBase
    {
      

        private readonly ILogger<FacturesController> _logger;

        private readonly IBusinessData _data;

        public DashboardController(ILogger<FacturesController> logger, IBusinessData data)
        {
            _logger = logger;
            _data = data;
        }

        [HttpGet]
        public IEnumerable<Facture> Get()
        {

            return _data.Factures;

        }
        [HttpGet("{Nfacture}")]

        public ActionResult<Facture> Get(string Nfacture)
        {
            var facture = _data.Factures.Where(fact => fact.NumeroFacture == Nfacture).FirstOrDefault();

            if (facture != null)
            {
                return facture;

            }
            else
            {
                return NotFound();
            }


        }
        [HttpPost]
        public ActionResult<Facture> Post([FromQuery] Facture newFacture)
        {
            if(ModelState.IsValid)
            {

                

                return Created($"factures/{newFacture.NumeroFacture}", newFacture);
               

            }
            else
            {
                return BadRequest(ModelState.Values);
            }


        }
    }
}
