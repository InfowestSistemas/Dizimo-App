using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DizimoApp.Dominio
{
    public class Pessoa
    {
        public static DateTime DataCadastro;
        public object IdPessoa;

        public string Nome{ get; set; }
        public int DataDeNascimento { get; set; }
        public string Email { get; set; }
        public int Telefone { get; set; }
        public string TipoDePessoa { get; set; }
        public int DataDeCadastro{ get; set; }
        public string Status { get; set; }
        public object ID { get; set; }

        public class PessoaCollection : List<Pessoa>
        {
        }
    }
}
