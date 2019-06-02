using Fretop.Infraestrutura.Classes;
using Fretop.Negocio.Requisicao;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web;
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
                Localizacao localizacao = new Localizacao(address, lat, lng);
                List<Localizacao> lstLocalizacaoDB = _requisicaoNegocio.ObterRotaApartirDaLocalização(localizacao);

                // Processando os dados para traçar a rota
                RunAsync2(localizacao, lstLocalizacaoDB).Wait();

                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { erro = "Houve um erro ao localizar um ônibus disponível. Erro: " + e.ToString() });
            }
        }

        public static async Task RunAsync2(Localizacao localizacao, List<Localizacao> lstLocalizacaoDB)
        {
            string url = "https://api.routexl.com/blog/api";
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(url);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            // Convertendo localizacao para json
            string json = JsonConvert.SerializeObject(localizacao);

            // Espera o resultado
            HttpResponseMessage response = await client.PostAsync("/tour", new StringContent(json, Encoding.UTF8, "application/json"));

        }

        public static async Task RunAsync(Localizacao localizacao, List<Localizacao> lstLocalizacaoDB)
        {
            string url = "https://api.routexl.com";
            using (var client = new HttpClient())
            {
                client.BaseAddress = new System.Uri(url);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // Unindo localizações encontradas com a do usuário para gerar matriz de convergência
                List<Localizacao> lstLocalizacao = new List<Localizacao>();
                lstLocalizacao.Add(localizacao);
                lstLocalizacao.AddRange(lstLocalizacaoDB);

                // Convertendo localizacao para json
                string json = JsonConvert.SerializeObject(localizacao);

                //POST
                HttpResponseMessage response = await client.PostAsJsonAsync("/distances", localizacao);
                
                response = await client.GetAsync("/distances");
                if (response.IsSuccessStatusCode)
                {  //GET
                    localizacao = await response.Content.ReadAsAsync<Localizacao>();
                }

                // A partir da matriz formada identificar grupo e traçar rota....
                //return localizacao;
            }
        }

        /*
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
        */
    }
}