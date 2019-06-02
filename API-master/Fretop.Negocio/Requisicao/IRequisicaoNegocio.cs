using Fretop.Infraestrutura.Classes;
using System.Collections.Generic;

namespace Fretop.Negocio.Requisicao
{
    public interface IRequisicaoNegocio
    {
        List<Localizacao> ObterRotaApartirDaLocalização(Localizacao localizacaoFiltro);
    }
}
