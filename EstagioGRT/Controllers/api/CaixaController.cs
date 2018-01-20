using EstagioGRT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;
using System.Web.Mvc;

namespace EstagioGRT.Controllers.api
{
    public class CaixaController : ApiController
    {
        // GET: api/Caixa
        public IHttpActionResult Get()
        {
            return Ok(GlobalVar.FluxoCaixa);
        }

        // POST: api/Caixa/Editar
       
        // POST: api/Caixa
        public IHttpActionResult Post([FromBody]Caixa caixa)
        {
            if (caixa == null)
            {
                return BadRequest("Preencha os campos.");
            }

            if (string.IsNullOrEmpty(caixa.Nome))
            {
                return BadRequest("Nome é obrigatório.");
            }

            if (caixa.Valor == 0)
            {
                return BadRequest("Valor é obrigatório.");
            }

            if (!(caixa.Operacao == 'E' || caixa.Operacao == 'S'))
            {
                return BadRequest("Operação é obrigatório.");
            }

            GlobalVar.FluxoCaixa.Add(caixa);
            return Ok(caixa);
        }

        // GET: api/Caixa/5
        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("api/Caixa/Delete/{id}")]
        public void Delete(int id)//id = 3
        {
            var lista = GlobalVar.FluxoCaixa;
            for (int i = 0; i < lista.Count; i++)
            {
                if (id == lista[i].Id)
                {
                    lista.Remove(lista[i]);                    
                }                
            }
        }
    }
}
