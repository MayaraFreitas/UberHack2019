using Fretop.Infraestrutura.Classes;
using System.Collections.Generic;

namespace Fretop.Dados.Requisicao
{
    public class RequisicaoDados : IRequisicaoDados
    {
        public List<Localizacao> ObterRotaApartirDaLocalização(Localizacao localizacaoFiltro)
        {
            ViewRotaOnibus rota = new ViewRotaOnibus();
            return MockBuscarLocalizacoesProximas(localizacaoFiltro); // Mockando dado de uma rota para o usuario
        }
        private List<Localizacao> MockBuscarLocalizacoesProximas(Localizacao localizacaoFiltro)
        {
            List<Localizacao> lstLocalizacao = new List<Localizacao>();

            lstLocalizacao.Add(new Localizacao()
            {
                address = "The Hague, The Netherlands",
                lat = "52.05429",
                lng = "4.248618"
            });
            lstLocalizacao.Add(new Localizacao()
            {
                address = "The Hague, The Netherlands",
                lat = "52.076892",
                lng = "4.26975"
            });
            lstLocalizacao.Add(new Localizacao()
            {
                address = "Uden, The Netherlands",
                lat = "51.669946",
                lng = "5.61852"
            });
            lstLocalizacao.Add(new Localizacao()
            {
                address = "Sint-Oedenrode, The Netherlands",
                lat = "51.589548",
                lng = "5.432482"
            });

            return lstLocalizacao;
        }
    }
}
