using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace DizimoApp.Dominio
{
    public class FluxoCaixa
    {
        public int ID { get; set; }

        public int IdPessoa { get; set; }

        public string DizimoCategoria { get; set; }

        public decimal Valor { get; set; }

        public DateTime DataCadastro { get; set; }

        public class FluxocaixaCollection : List<FluxoCaixa>
        {

        }
    }
} 
