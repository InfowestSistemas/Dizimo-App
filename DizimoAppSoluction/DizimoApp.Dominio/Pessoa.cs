using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DizimoApp.Dominio
{
    public class Pessoa
    {
       
        public int ID { get; set; }
        public string Nome{ get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }

        public bool Status { get; set; }

        public DateTime DataCadastro { get; set; }

        #region [ Endereço ]
        public string E_Rua { get; set; }
        public string E_Numero { get; set; }
        public string E_Cep { get; set; }
        public string E_Bairro { get; set; }
        public string E_Cidade { get; set; }
        #endregion

        public class PessoaCollection : List<Pessoa>
        {
        }
    }
}
