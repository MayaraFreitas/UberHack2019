using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fretop.Infraestrutura.Classes
{
    public partial class Usuario
    {
        public int codUsuario { get; set; }
        public string nome { get; set; }
        public string usuario { get; set; }
        public string senha { get; set; }
        public Nullable<System.DateTime> dataCadastro { get; set; }
        public Nullable<bool> ativo { get; set; }
        public string cpf { get; set; }
    }
}
