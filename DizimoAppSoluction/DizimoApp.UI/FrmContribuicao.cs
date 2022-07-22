using DizimoApp.Aplicacao;
using DizimoApp.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DizimoApp.UI
{
    public partial class FrmContribuicao : Form
    {
        Pessoa pessoaEdit = new Pessoa();

        public FrmContribuicao(int idPessoa)
        {
            InitializeComponent();
            if (idPessoa > 0)
            {
                pessoaEdit.ID = idPessoa;
                listarPorID(idPessoa);
            }
        }



        public void listarPorID(int IdPessoa)
        {
            var pessoaApp = new PessoaApp();
            var pessoaList = new List<Pessoa>();

            pessoaList = pessoaApp.ListarPessoaPorID(IdPessoa);
            foreach (var item in pessoaList)
            {
                lblCodigoDizimista.Text = item.ID.ToString();
                lblNomeDizimista.Text = item.Nome;
            }
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbTipoContribuição_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmContribuicao_Load(object sender, EventArgs e)
        {

        }

        private void txbNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
