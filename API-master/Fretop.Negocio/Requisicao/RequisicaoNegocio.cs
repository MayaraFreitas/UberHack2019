using Fretop.Dados.Requisicao;
using Fretop.Infraestrutura.Classes;

namespace Fretop.Negocio.Requisicao
{
    public class RequisicaoNegocio : IRequisicaoNegocio
    {
        private IRequisicaoDados _requisicaoDados = null;

        public RequisicaoNegocio(IRequisicaoDados requisicaoDados)
        {
            _requisicaoDados = requisicaoDados;
        }

        public ViewRotaOnibus ObterRotaApartirDaLocalização(LocalizacaoFiltro localizacaoFiltro)
        {
            return _requisicaoDados.ObterRotaApartirDaLocalização(localizacaoFiltro);
        }
    }
}
