using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DizimoApp.Dominio
{
    public class PessoaCategoria
    {
        public int ID { get; set; }

        public string Descricao { get; set; }

        public class PessoaCategoriaCollection : List<PessoaCategoria>
        {

        }
    }
}
