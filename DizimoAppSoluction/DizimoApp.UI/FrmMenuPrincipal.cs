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
                lblContatoSelecionado.Visible = false;
                lblContato.Visible = false;
                ListaContatos();
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
         
        private void dataGridView_ListaCadastros_CellContentClick( object sender, DataGridViewCellEventArgs e )
        {


        }

        private void btnExcluir_Click( object sender, EventArgs e )
        {
            string Id = lblID.Text;
            int IdPessoa = 0;

            if ( !string.IsNullOrEmpty( Id ) && Id != "ID" )
            {
                IdPessoa = Convert.ToInt32( Id );

                var pessoaApp = new PessoaApp();

                string retorno = pessoaApp.Delete(IdPessoa);
                if(!string.IsNullOrEmpty( retorno ) )
                {
                    MessageBox.Show( "Contato ID : "+ retorno + " excluido com sucesso !!!" );
                    ListaContatos();                    
                }
            }
            else
            {
                MessageBox.Show( "Atenção ! Selecione um contato para exclusão " );
            }
             
        }

        private void dataGridView_ListaCadastros_CellClick( object sender, DataGridViewCellEventArgs e )
        {
            string ID = dataGridView_ListaCadastros.CurrentRow.Cells[ 0 ].Value.ToString();
            string Nome = dataGridView_ListaCadastros.CurrentRow.Cells[ 1 ].Value.ToString();
            lblID.Text = ID;
            lblContato.Text = Nome;
            lblID.Refresh();
            lblContato.Refresh();

            lblContatoSelecionado.Visible = true;
            lblContato.Visible = true;
            dataGridView_ListaCadastros.Refresh();
        }

        #region [ Métodos Auxiliares ]
        public void ListaContatos()
        {
            var pessoa = new PessoaApp();
            dataGridView_ListaCadastros.DataSource = pessoa.ListarPessoas();
            dataGridView_ListaCadastros.Refresh();
        }
 
        #endregion

        private void btnEditar_Click( object sender, EventArgs e )
        {
            string Id = lblID.Text;
            int IdPessoa = 0;

            if ( !string.IsNullOrEmpty( Id ) && Id != "ID" )
            {
                IdPessoa = Convert.ToInt32( Id );

                FrmCadMembros frmCadMembros = new FrmCadMembros(IdPessoa);
                frmCadMembros.Show();
            }
            else
            {
                MessageBox.Show( "Atenção ! Selecione um contato para editar " );
            }

            
        }

        private void txbPesquisa_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLancamentos_Click(object sender, EventArgs e)
        {
            

            string Id = lblID.Text;
            int IdPessoa = 0;

            if ( !string.IsNullOrEmpty( Id ) && Id != "ID" )
            {
                IdPessoa = Convert.ToInt32( Id );

                FrmContribuicao frmContribuicao = new FrmContribuicao(IdPessoa);
                frmContribuicao.Show();
            }
            else
            {
                MessageBox.Show( "Atenção ! Selecione um contato para lançamento " );
            }
         


        }

        private void lblContato_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            FrmCadMembros frmCadMembros = new FrmCadMembros();
            frmCadMembros.Show();
            this.Close();
        }
    }
    
}
