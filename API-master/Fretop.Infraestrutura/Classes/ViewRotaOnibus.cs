using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fretop.Infraestrutura.Classes
{
    public class ViewRotaOnibus
    {
        public int IdOnubus { get; set; }
        public string PlacaOnibus { get; set; }
        public int IdMotorista { get; set; }
        public string NomeMotorista { get; set; }
        public string HoraInicio { get; set; }
        public string HoraFIm { get; set; }
        public string LatInicio { get; set; }
        public string LngInicio { get; set; }
        public string LatFim { get; set; }
        public string LngFim { get; set; }
    }
}
