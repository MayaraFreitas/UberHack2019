using Fretop.Infraestrutura.Classes;
using Fretop.Negocio.Requisicao;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Fretop.WebAPI.Controllers
{
    public class RequisicaoController : ApiController
    {
        #region Propriedades e Construtor

        IRequisicaoNegocio _requisicaoNegocio;

        public RequisicaoController(IRequisicaoNegocio requisicaoNegocio)
        {
            _requisicaoNegocio = requisicaoNegocio;
        }
        #endregion

        [HttpGet]
        [ActionName("requisicaoOnibus")]
        public HttpResponseMessage Index(string address, string lat, string lng)
        {
            try
            {
                LocalizacaoFiltro localizacao = new LocalizacaoFiltro(address, lat, lng);
                var rota = _requisicaoNegocio.ObterRotaApartirDaLocalização(localizacao);

                return Request.CreateResponse(HttpStatusCode.OK, rota);
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { erro = "Houve um erro ao localizar um ônibus disponível. Erro: " + e.ToString() });
            }
        }
    }
}