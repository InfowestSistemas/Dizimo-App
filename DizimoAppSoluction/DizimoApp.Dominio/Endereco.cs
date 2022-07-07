using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DizimoApp.Dominio
{
    public class Endereco
    {
        public int ID { get; set; }
        public int IdPessoa { get; set; }
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Cep { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public DateTime DataCadastro { get; set; }

        public class EnderecoCollection : List<Endereco>
        {

        }
    }
}
