using Fretop.Infraestrutura.Classes;

namespace Fretop.Dados.Requisicao
{
    public interface IRequisicaoDados
    {
        ViewRotaOnibus ObterRotaApartirDaLocalização(LocalizacaoFiltro localizacaoFiltro);
    }
}
