using Fretop.Infraestrutura.Classes;

namespace Fretop.Dados.Requisicao
{
    public class RequisicaoDados : IRequisicaoDados
    {
        public ViewRotaOnibus ObterRotaApartirDaLocalização(LocalizacaoFiltro localizacaoFiltro)
        {
            ViewRotaOnibus rota = new ViewRotaOnibus();
            rota.MockandoDado(); // Mockando dado de uma rota para o usuario
            return rota;
        }
    }
}
