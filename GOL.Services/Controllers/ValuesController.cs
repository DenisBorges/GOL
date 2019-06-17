using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using GOL.Application;
using GOL.Application.IApplication;
using Microsoft.AspNetCore.Mvc;

namespace GOL.Services.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        public IAirplaneApplication _repository;
        public ValuesController(IAirplaneApplication repository)
        {
            _repository = repository;
        }

        //public readonly IAirplaneApplication _repository;
        //public ValuesController(IAirplaneApplication repository)
        //{
        //    _repository = repository;
        //}

        // GET api/values
        [HttpGet]
        public ActionResult<ObjetoServidor> ListarTodos()
        {
            var response = new ObjetoServidor()
            {
                status = "200",
                message = "sucess"
            };

            try
            {
                var lista = _repository.Listar();
                response.data = lista;
            }
            catch (Exception ex)
            {
                response.status = "400";
                response.message = ex.Message;
            }

            return response;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<ObjetoServidor> Get(int id)
        {
            var response = new ObjetoServidor()
            {
                status = "200",
                message = "sucess"
            };

            try
            {
                var lista = _repository.PesquisarPorId(id);
                response.data = lista;
            }
            catch (Exception ex)
            {
                response.status = "400";
                response.message = ex.Message;
            }

            return response;
        }

        // POST api/values
        [HttpPost]
        public void Inserir(AirplaneViewModel registro)
        {
            registro.dt_criacao_registro = DateTime.Now;
            _repository.Inserir(registro);
        }

        // POST api/values/5
        [HttpPost]
        public void Atualizar(AirplaneViewModel registro)
        {
            //var item = _repository.PesquisarPorId(registro.id);
            //item.codigo_do_aviao = registro.codigo_do_aviao;
            //item.modelo = registro.modelo;
            //item.qtd_passageiros = registro.qtd_passageiros;

            _repository.Atualizar(registro);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Apagar(int id)
        {
           var obj =  _repository.PesquisarPorId(id);
            if (obj != null)
                _repository.Apagar(obj);
        }
    }
}
