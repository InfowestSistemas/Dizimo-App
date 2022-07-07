using DizimoApp.Dominio;
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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            bool LoginValido;
            login.Usuario = txbUsuario.Text;
            login.Senha = txbSenha.Text;
 
            var appLogin = new LoginApp();
            LoginValido = appLogin.AutenticarAcesso(login);
 
            // Executa se validado
            if(LoginValido == true)
            {
 
                FrmMenuPrincipal menuPrincipal = new FrmMenuPrincipal();
                menuPrincipal.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Atenção !!! , Usuário ou Senha inválidos");
            }


        }

        private void FrmLogin_Load( object sender, EventArgs e )
        {
            txbUsuario.Text = "Admin";
            txbSenha.Text = "010203";
        }
    }
}
