using Fretop.Infraestrutura.Classes;
using System.Collections.Generic;

namespace Fretop.Dados.Requisicao
{
    public interface IRequisicaoDados
    {
        List<Localizacao> ObterRotaApartirDaLocalização(Localizacao localizacaoFiltro);
    }
}
