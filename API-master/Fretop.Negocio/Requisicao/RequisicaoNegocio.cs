using Fretop.Dados.Requisicao;
using Fretop.Infraestrutura.Classes;
using System.Collections.Generic;

namespace Fretop.Negocio.Requisicao
{
    public class RequisicaoNegocio : IRequisicaoNegocio
    {
        private IRequisicaoDados _requisicaoDados = null;

        public RequisicaoNegocio(IRequisicaoDados requisicaoDados)
        {
            _requisicaoDados = requisicaoDados;
        }

        public List<Localizacao> ObterRotaApartirDaLocalização(Localizacao localizacaoFiltro)
        {
            return _requisicaoDados.ObterRotaApartirDaLocalização(localizacaoFiltro);
        }
    }
}
