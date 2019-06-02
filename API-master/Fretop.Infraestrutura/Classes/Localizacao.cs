using System.Collections.Generic;

namespace Fretop.Infraestrutura.Classes
{
    public class Localizacao
    {
        public string address { get; set; }
        public string lat { get; set; }
        public string lng { get; set; }

        public Localizacao()
        {
            this.address = address;
            this.lat = lat;
            this.lng = lng;
        }
        public Localizacao(string address, string lat, string lng)
        {
            this.address = address;
            this.lat = lat;
            this.lng = lng;
        }
    }
}
