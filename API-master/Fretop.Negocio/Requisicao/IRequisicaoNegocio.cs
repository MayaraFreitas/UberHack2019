using Fretop.Infraestrutura.Classes;

namespace Fretop.Negocio.Requisicao
{
    public interface IRequisicaoNegocio
    {
        ViewRotaOnibus ObterRotaApartirDaLocalização(LocalizacaoFiltro localizacaoFiltro);
    }
}
