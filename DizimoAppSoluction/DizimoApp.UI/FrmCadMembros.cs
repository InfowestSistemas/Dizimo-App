using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DizimoApp.Aplicacao;
using DizimoApp.Dominio;

namespace DizimoApp.UI
{
    public partial class FrmCadMembros : Form
    {
        Pessoa pessoaEdit = new Pessoa();

        public FrmCadMembros()
        {
            InitializeComponent();

        }
        public FrmCadMembros(int IdPessoa)
        {
            InitializeComponent();
             if ( IdPessoa > 0 )
            {
                pessoaEdit.ID = IdPessoa;
                listarPorID( IdPessoa );
            }
        }

        private void textBox1_TextChanged( object sender, EventArgs e )
        {

        }

        private void tableLayoutPanel1_Paint( object sender, PaintEventArgs e )
        {

        }

        private void groupBox1_Enter( object sender, EventArgs e )
        {

        }

        private void flowLayoutPanel1_Paint( object sender, PaintEventArgs e )
        {

        }

        private void panel1_Paint( object sender, PaintEventArgs e )
        {

        }

        private void FrmCadMembros_Load( object sender, EventArgs e )
        {

        }

        private void btnCadastrar_Click( object sender, EventArgs e )
        {
            if(pessoaEdit.ID > 0 )
            {
                Editar();
            }
            else
            {
                Salvar();
            }
        }
 
        private void Salvar()
        {
            var pessoaReturn = new Pessoa();
            var enderecoReturn = new Endereco();
            var pessoa = new Pessoa();
            pessoa.Nome = txbNome.Text;
            pessoa.Email = txbEmail.Text;
            pessoa.Telefone = txbTelefone.Text;
            if ( checkBoxStatus.Checked == true )
            {
                pessoa.Status = true;
            }
            else
            {
                pessoa.Status = false;
            }
            var pessoaApp = new PessoaApp();
            try
            {
                if ( !string.IsNullOrEmpty( pessoa.Nome ) && !string.IsNullOrEmpty( pessoa.Email ) )
                    pessoaReturn = pessoaApp.Create( pessoa );
                else
                    MessageBox.Show( "Atenção ! Preencha os campos Nome e Email antes de gravar" );
            }
            catch ( Exception ex )
            {
                MessageBox.Show( "Erro ao cadastrar tentar cadastrar na tabela Pessoa" + ex );
            }

            if ( pessoaReturn != null )
            {
                var endereco = new Endereco();
                endereco.IdPessoa = pessoaReturn.ID;
                endereco.Rua = txbRua.Text;
                endereco.Numero = txbNumero.Text;
                endereco.Bairro = txbBairro.Text;
                endereco.Cep = txbCep.Text;
                endereco.Cidade = txbCidade.Text;

                var enderecoApp = new EnderecoApp();
                try
                {
                    enderecoReturn = enderecoApp.Create( endereco );
                }
                catch ( Exception ex )
                {
                    MessageBox.Show( "Erro ao cadastrar tentar cadastrar na tabela Pessoa" + ex );
                }

            }
            if ( pessoaReturn.ID > 0 && enderecoReturn.ID > 0 )
            {
                dataGridView_FrmCadastro.DataSource = pessoaApp.ListarPessoaPorID( pessoaReturn.ID );
                MessageBox.Show( "Dados Cadastrados com Sucesso" );
                LimparCampos();
            }
        }

        private void Editar()
        {
            var pessoaReturn = new Pessoa();
            var enderecoReturn = new Endereco();
            var enderecoEdit = new Endereco();
            var pessoa = new Pessoa();
            pessoa.ID = pessoaEdit.ID;
            pessoa.Nome = txbNome.Text;
            pessoa.Email = txbEmail.Text;
            pessoa.Telefone = txbTelefone.Text;
            if ( checkBoxStatus.Checked == true )
            {
                pessoa.Status = true;
            }
            else
            {
                pessoa.Status = false;
            }
            var pessoaApp = new PessoaApp();
            try
            {
                if ( !string.IsNullOrEmpty( pessoa.Nome ) && !string.IsNullOrEmpty( pessoa.Email ) )
                    pessoaReturn = pessoaApp.Update( pessoa );
                else
                    MessageBox.Show( "Atenção ! Preencha os campos Nome e Email antes de gravar" );
            }
            catch ( Exception ex )
            {
                MessageBox.Show( "Erro ao cadastrar tentar cadastrar na tabela Pessoa" + ex );
            }

            if ( pessoaReturn != null )
            {
                var enderecoApp = new EnderecoApp();
                enderecoEdit = enderecoApp.ListaEnderecoPorIDPessoa( pessoaEdit.ID );

                var endereco = new Endereco();
                endereco.ID = enderecoEdit.ID;
                endereco.IdPessoa = pessoaReturn.ID;
                endereco.Rua = txbRua.Text;
                endereco.Numero = txbNumero.Text;
                endereco.Bairro = txbBairro.Text;
                endereco.Cep = txbCep.Text;
                endereco.Cidade = txbCidade.Text;


                try
                {
                    enderecoReturn = enderecoApp.Update( endereco );
                }
                catch ( Exception ex )
                {
                    MessageBox.Show( "Erro ao cadastrar tentar cadastrar na tabela Pessoa" + ex );
                }

            }
            if ( pessoaReturn.ID > 0 && enderecoReturn.ID > 0 )
            {
                dataGridView_FrmCadastro.DataSource = pessoaApp.ListarPessoaPorID( pessoaReturn.ID );
                dataGridView_FrmCadastro.Refresh();
                MessageBox.Show( "Dados Atualizados com Sucesso !" );
                LimparCampos();
            }
        }

        private void btn_Voltar_Click( object sender, EventArgs e )
        {
            if ( pessoaEdit.ID > 0 )
            {
                this.Close();
            }else
            {
                FrmMenuPrincipal frmPrincipal = new FrmMenuPrincipal();
                frmPrincipal.Show();
                this.Close();
            }

        }

        private void btnCadastrar_Enderecos_Click( object sender, EventArgs e )
        {
            FrmCadEnderecos frmEnderecos = new FrmCadEnderecos();
            frmEnderecos.Show();
            this.Close();
        }

        private void label1_Click( object sender, EventArgs e )
        {

        }

        private void label1_Click_1( object sender, EventArgs e )
        {

        }

        private void btnListarUsuarios_Click( object sender, EventArgs e )
        {
            var login = new LoginApp();
            dataGridView_FrmCadastro.DataSource = login.ListaUsuarios();


        }

        private void label3_Click( object sender, EventArgs e )
        {

        }

        private void btnExcluir_Click( object sender, EventArgs e )
        {

        }

        private void dataGridView_FrmCadastro_CellContentClick( object sender, DataGridViewCellEventArgs e )
        {
            
        }

        #region [ Métodos Auxiliares ]
        public void LimparCampos()
        {
            txbNome.Text = string.Empty;
            txbEmail.Text = string.Empty;
            txbTelefone.Text = string.Empty;
            checkBoxStatus.Checked = false;
            txbRua.Text = string.Empty;
            txbNumero.Text = string.Empty;
            txbBairro.Text = string.Empty;
            txbCep.Text = string.Empty;
            txbCidade.Text = string.Empty;
        }

        public void listarPorID(int IdPessoa)
        {
            var pessoaApp = new PessoaApp();
            dataGridView_FrmCadastro.DataSource = pessoaApp.ListarPessoaPorID( IdPessoa );
        }
        #endregion

        private void dataGridView_FrmCadastro_CellClick( object sender, DataGridViewCellEventArgs e )
        {
            string ID = dataGridView_FrmCadastro.CurrentRow.Cells[ 0 ].Value.ToString();
            string Nome = dataGridView_FrmCadastro.CurrentRow.Cells[ 1 ].Value.ToString();
            string Telefone = dataGridView_FrmCadastro.CurrentRow.Cells[ 2 ].Value.ToString();
            string Email = dataGridView_FrmCadastro.CurrentRow.Cells[ 3 ].Value.ToString();
            string Status = dataGridView_FrmCadastro.CurrentRow.Cells[ 4 ].Value.ToString();
            string dataCadastro = dataGridView_FrmCadastro.CurrentRow.Cells[ 5 ].Value.ToString();
            string Rua = dataGridView_FrmCadastro.CurrentRow.Cells[ 6 ].Value.ToString();
            string Numero = dataGridView_FrmCadastro.CurrentRow.Cells[ 7 ].Value.ToString();
            string Bairro = dataGridView_FrmCadastro.CurrentRow.Cells[ 8 ].Value.ToString();
            string Cep = dataGridView_FrmCadastro.CurrentRow.Cells[ 9 ].Value.ToString();
            string Cidade = dataGridView_FrmCadastro.CurrentRow.Cells[ 10 ].Value.ToString();

            lblID.Text = ID;
            txbNome.Text = Nome;
            txbEmail.Text = Email;
            txbTelefone.Text = Telefone;

            checkBoxStatus.Checked = Convert.ToBoolean( Status );
            txbRua.Text = Rua;
            txbNumero.Text = Numero;
            txbBairro.Text = Bairro;
            txbCep.Text = Cep;
            txbCidade.Text = Cidade;
        }
    }
}
