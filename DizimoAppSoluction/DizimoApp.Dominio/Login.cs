using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DizimoApp.Dominio
{
    public class Login
    {
        public int ID { get; set; }
        public int IdPessoa { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Status { get; set; }

        public class LoginCollection : List<Login>
        {

        }
    }
}
