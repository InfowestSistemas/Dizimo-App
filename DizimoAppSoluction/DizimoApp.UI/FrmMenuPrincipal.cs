using DizimoApp.Aplicacao;
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
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void cadMembros_Click( object sender, EventArgs e )
        {
            FrmCadMembros frmMembros = new FrmCadMembros();
            frmMembros.Show();
            this.Hide();
        }

        private void cadMovimentos_Click( object sender, EventArgs e )
        {

        }

        private void Relatorios_Click( object sender, EventArgs e )
        {

        }

        private void lblPesquisar_Click( object sender, EventArgs e )
        {

        }

        private void FrmMenuPrincipal_Load( object sender, EventArgs e )
        {
            try
            {
                var pessoa = new PessoaApp();
                dataGridView_ListaCadastros.DataSource = pessoa.ListarPessoas();
            }
            catch ( Exception ex)
            {

                MessageBox.Show("Erro ao tentar listar os dados : "+ex);
            }


        }

        private void btnPesquisar_Click( object sender, EventArgs e )
        {
            string termoPesquisado = txbPesquisa.Text;
            var pessoa = new PessoaApp();
            var resultado = pessoa.ListarPessoasPesquisa( termoPesquisado );
            dataGridView_ListaCadastros.DataSource = resultado;
        }
    }
}
