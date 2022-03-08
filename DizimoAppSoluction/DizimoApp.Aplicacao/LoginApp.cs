using DizimoApp.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DizimoApp.Aplicacao
{
    public class LoginApp
    {
       
        public bool AutenticarAcesso(Login login)
        {
            bool EAutenticado = false;
            string User = "Xavier";
            string Senha = "123456";

            if(login.Usuario == User && login.Senha == Senha)
            {
                EAutenticado = true;
            }

            return EAutenticado;
        }

    }
}
