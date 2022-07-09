using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DizimoApp.Dominio
{
    public class FluxoTipo
    {
        public int ID { get; set; }

        public string Descricao { get; set; }

        public class FluxoTipoCollection : List<FluxoTipo>
        {

        }

    }
}
