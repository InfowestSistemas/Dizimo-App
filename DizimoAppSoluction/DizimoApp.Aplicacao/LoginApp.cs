using DizimoApp.Dominio;
using DizimoApp.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DizimoApp.Aplicacao
{
    public class LoginApp
    {

        // ---- Implementar os metodos CRUD  - Create | Update | Select | Delete
        DizimoDB dbDizimo = new DizimoDB ( );
        public bool AutenticarAcesso(Login login)
        {
			try
			{
                var loginDto = new Login ( );
                dbDizimo.LimparParametros ( );
                dbDizimo.AdicionarParametros ( "@Usuario", login.Usuario );
                dbDizimo.AdicionarParametros ( "@Senha", login.Senha );
                dbDizimo.AdicionarParametros ( "@Status", "1" );
                DataTable dataTable = dbDizimo.ExecutaConsulta ( CommandType.Text,
                "   SELECT * FROM Usuario " +
                "   WHERE Usuario=@Usuario AND Senha=@Senha AND Status=@Status " );

                //Percorrer o DataTable 
                //Cada linha do datatable é um Registro
                //for = para  each cada

                foreach ( DataRow item in dataTable.Rows )
				{
                    //colocar dados da linha nele
                    loginDto.ID = Convert.ToInt32 ( item [ "ID" ] );
                }
                bool EAutenticado = false;
                EAutenticado = ( dataTable.Rows.Count > 0 ? true : false );

                return EAutenticado;
            }
            catch ( Exception ex )
			{

                Console.WriteLine ( "Erro : " + ex );
			}

			return false;
		}

		public string Create( Login login )
		{
			try
			{
				dbDizimo.LimparParametros ( );

				dbDizimo.AdicionarParametros ( "@IdPessoa", 1 );
				dbDizimo.AdicionarParametros ( "@Usuario", login.Usuario );
				dbDizimo.AdicionarParametros ( "@Senha", login.Senha );
				dbDizimo.AdicionarParametros ( "@DataCadastro", DateTime.Now );
				dbDizimo.AdicionarParametros ( "@Status", true );

				string IdProcessamento = Convert.ToString(dbDizimo.ExecutarManipulacao ( CommandType.Text,
				"   INSERT INTO USUARIO  " +
				"   (IdPessoa,Usuario,Senha,DataCadastro,Status) " +
				"   VALUES (@IdPessoa,@Usuario,@Senha,@DataCadastro,@Status) " ));


				return IdProcessamento;
			}
			catch ( Exception exception )
			{

				return exception.Message;
			}
		}

		public string Update( Login login )
		{
			try
			{
				dbDizimo.LimparParametros ( );

				dbDizimo.AdicionarParametros ( "@ID", login.ID );
				dbDizimo.AdicionarParametros ( "@IdPessoa", login.IdPessoa );
				dbDizimo.AdicionarParametros ( "@Usuario", login.Usuario );
				dbDizimo.AdicionarParametros ( "@Senha", login.Senha );
				dbDizimo.AdicionarParametros ( "@DataCadastro", DateTime.Now );
				dbDizimo.AdicionarParametros ( "@Status", login.Status );

				string IdProcessamento = Convert.ToString ( dbDizimo.ExecutarManipulacao ( CommandType.Text,
				"   UPDATE USUARIO  " +
				"   SET IdPessoa=@IdPessoa,Usuario=@Usuario,Senha=@Senha,DataCadastro=GETDATE(),Status=@Status " +
				"   WHERE ID=@ID " ) );


				return IdProcessamento;
			}
			catch ( Exception exception )
			{

				return exception.Message;
			}
		}

		public string Delete( Login login )
		{
			try
			{
				dbDizimo.LimparParametros ( );

				dbDizimo.AdicionarParametros ( "@ID", login.ID );
				string IdProcessamento = Convert.ToString ( dbDizimo.ExecutarManipulacao ( CommandType.Text,
				"   DELETE Usuario WHERE ID=@ID" ) );


				return IdProcessamento;
			}
			catch ( Exception exception )
			{

				return exception.Message;
			}
		}

		public Login.LoginCollection ListaUsuarios()
		{
			try
			{
				dbDizimo.LimparParametros ( );
				Login.LoginCollection listaUsuariosColection = new Login.LoginCollection ( );
				DataTable dataTable = dbDizimo.ExecutaConsulta ( CommandType.Text,
				" SELECT * FROM  USUARIO ORDER BY Usuario ASC " );

				//Percorrer o DataTable 
				//Cada linha do datatable é um Registro
				//for = para  each cada

				foreach ( DataRow item in dataTable.Rows )
				{
					var usuario = new Login ( );
					//colocar dados da linha nele
					usuario.ID = Convert.ToInt32 ( item [ "ID" ] );
					usuario.IdPessoa = Convert.ToInt32 ( item [ "IdPessoa" ] );
					usuario.Usuario = Convert.ToString ( item [ "Usuario" ] );
					usuario.Senha = Convert.ToString ( item [ "Senha" ] );
					usuario.DataCadastro = Convert.ToDateTime ( item [ "DataCadastro" ] );
					usuario.Status = Convert.ToBoolean ( item [ "Status" ] );

					listaUsuariosColection.Add ( usuario );
				}
				return listaUsuariosColection;
			}
			catch ( Exception exception )
			{
				Console.WriteLine("Erro "+ exception.Message);
			}

			return null;
		}

	}
}
