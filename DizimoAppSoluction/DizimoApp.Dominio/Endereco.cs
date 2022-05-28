using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DizimoApp.Dominio
{
    public class Endereco
    {
        public string Rua { get; set; }
        public int Numero { get; set; }
        public int Cep { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
        public int Telefone { get; set; }
        public object ID { get; set; }
        public int DataCadastro { get; set; }

        public class EnderecoCollection : List<Endereco>
        {

        }
    }
}
