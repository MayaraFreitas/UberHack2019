using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fretop.Infraestrutura.Classes
{
    public class LocalizacaoFiltro
    {
        public string Endereco { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }

        public LocalizacaoFiltro(string address, string lat, string lng)
        {
            Endereco = address;
            Latitude = lat;
            Longitude = lng;
        }
    }
}
