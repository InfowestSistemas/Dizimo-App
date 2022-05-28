using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DizimoApp.Dominio
{
    public class Dizimo
    {
        public double Valor { get; set; }
        public object Id { get; set; }
        public object ID { get; set; }
        public object DizimoCategoria { get; set; }
        public object IdPessoa { get; set; }
        public int DataCadastro { get; set; }

        public class DizimoCollection : List<Dizimo>
        {

        }






    }
}
