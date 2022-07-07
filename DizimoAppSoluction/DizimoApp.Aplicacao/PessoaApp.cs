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
	public class PessoaApp
	{
		DizimoDB dbDizimo = new DizimoDB();

		public Pessoa Create( Pessoa pessoa )
		{
			try
			{
				dbDizimo.LimparParametros();
				dbDizimo.AdicionarParametros( "@ID ", "" );
				dbDizimo.AdicionarParametros( "@Nome", pessoa.Nome );
				dbDizimo.AdicionarParametros( "@Email", pessoa.Email );
				dbDizimo.AdicionarParametros( "@Telefone", pessoa.Telefone );
				dbDizimo.AdicionarParametros( "@Status", pessoa.Status );
				dbDizimo.AdicionarParametros( "@DataCadastro", DateTime.Now );

				string IdProcessamento = Convert.ToString( dbDizimo.ExecutarManipulacao( CommandType.Text,
				"   INSERT INTO PESSOA  " +
				"   (Nome,Email,Telefone,Status,DataCadastro) " +
				"   VALUES (@Nome,@Email,@Telefone,@Status,@DataCadastro) "+
				"    SET @ID = @@IDENTITY; " +
				"    SELECT (@ID) AS Retorno  "
				) );
				if (!string.IsNullOrEmpty( IdProcessamento ) )
			    {
					pessoa.ID = Convert.ToInt32( IdProcessamento );

				}
				return pessoa;
			}
			catch ( Exception exception )
			{

				Console.WriteLine("Erro"+ exception);

			}

            return pessoa;
        }

		public Pessoa Update( Pessoa pessoa )
		{
			try
			{
				dbDizimo.LimparParametros();


				dbDizimo.AdicionarParametros( "@ID", pessoa.ID );
				dbDizimo.AdicionarParametros( "@Nome", pessoa.Nome );
				dbDizimo.AdicionarParametros( "@Email", pessoa.Email );
				dbDizimo.AdicionarParametros( "@Telefone", pessoa.Telefone );
				dbDizimo.AdicionarParametros( "@DataCadastro", DateTime.Now );
				dbDizimo.AdicionarParametros( "@Status", pessoa.Status );

				string IdProcessamento = Convert.ToString( dbDizimo.ExecutarManipulacao( CommandType.Text,
				"   UPDATE PESSOA  " +
				"   SET Nome=@Nome,Email=@Email,Telefone=@Telefone,Status=@Status,DataCadastro=@DataCadastro " +
				"   WHERE ID=@ID "+
				"  SELECT (@ID) AS Retorno  "
				) );

				if ( !string.IsNullOrEmpty( IdProcessamento ) )
				{
					pessoa.ID = Convert.ToInt32( IdProcessamento );

				}
				return pessoa;
			}
			catch ( Exception exception )
			{
				Console.WriteLine( "Erro" + exception );
			}

			return pessoa;
		}

		public string Delete( int Id )
		{
			try
			{
				dbDizimo.LimparParametros();

				dbDizimo.AdicionarParametros( "@ID", Id );
				string IdProcessamento = Convert.ToString( dbDizimo.ExecutarManipulacao( CommandType.Text,
				"   DELETE PESSOA WHERE ID=@ID" +
				"    SELECT (@ID) AS Retorno  "
				) ); 

				return IdProcessamento;
			}
			catch ( Exception exception )
			{

				return exception.Message;
			}
		}

		public Pessoa.PessoaCollection ListarPessoas()
		{
			try
			{
				dbDizimo.LimparParametros();
				Pessoa.PessoaCollection listaPessoaColection = new Pessoa.PessoaCollection();
				DataTable dataTable = dbDizimo.ExecutaConsulta( CommandType.Text,
				" SELECT "+
				" P.ID, P.Nome, P.Telefone, P.Email, P.[Status],P.DataCadastro, " +
				" E.Rua, E.Numero, E.Bairro, E.Cep, E.Cidade " +
				" FROM Pessoa P " +
				" LEFT OUTER JOIN Endereco E ON P.ID = E.IdPessoa " +
				" ORDER BY ID ASC " );

				//Percorrer o DataTable 
				//Cada linha do datatable é um Registro
				//for = para  each cada

				foreach ( DataRow item in dataTable.Rows )
				{
					var pessoa = new Pessoa();
					//colocar dados da linha nele

					pessoa.ID = Convert.ToInt32( item[ "ID" ] );
					pessoa.Nome = Convert.ToString( item[ "Nome" ] );
					pessoa.Email = Convert.ToString( item[ "Email" ] );
					pessoa.Telefone = Convert.ToString( item[ "Telefone" ] );
					string status = Convert.ToString( item[ "Status" ] );
					pessoa.Status = Convert.ToBoolean(status);
					pessoa.E_Rua = Convert.ToString( item[ "Rua" ] );
					pessoa.E_Numero = Convert.ToString( item[ "Numero" ] );
					pessoa.E_Bairro = Convert.ToString( item[ "Bairro" ] );
					pessoa.E_Cep = Convert.ToString( item[ "Cep" ] );
					pessoa.E_Cidade = Convert.ToString( item[ "Cidade" ] );
					pessoa.DataCadastro = Convert.ToDateTime( item[ "DataCadastro" ] );

					listaPessoaColection.Add( pessoa );
				}
				return listaPessoaColection;
			}
			catch ( Exception exception )
			{
				Console.WriteLine( "Erro " + exception.Message );
			}

			return null;
		}

		public Pessoa.PessoaCollection ListarPessoaPorID(int ID)
		{
			try
			{
				Pessoa.PessoaCollection listaPessoaColection = new Pessoa.PessoaCollection();
				dbDizimo.LimparParametros();
				dbDizimo.AdicionarParametros( "@ID", ID );
				DataTable dataTable = dbDizimo.ExecutaConsulta( CommandType.Text,
				" SELECT " +
				" P.ID, P.Nome, P.Telefone, P.Email, P.[Status],P.DataCadastro, " +
				" E.Rua, E.Numero, E.Bairro, E.Cep, E.Cidade " +
				" FROM Pessoa P " +
				" LEFT OUTER JOIN Endereco E ON P.ID = E.IdPessoa " +
				" WHERE P.ID = @ID" +
				" ORDER BY ID ASC " );

				//Percorrer o DataTable 
				//Cada linha do datatable é um Registro
				//for = para  each cada
				
				foreach ( DataRow item in dataTable.Rows )
				{
					//colocar dados da linha nele
					var pessoa = new Pessoa();

					pessoa.ID = Convert.ToInt32( item[ "ID" ] );
					pessoa.Nome = Convert.ToString( item[ "Nome" ] );
					pessoa.Email = Convert.ToString( item[ "Email" ] );
					pessoa.Telefone = Convert.ToString( item[ "Telefone" ] );
					string status = Convert.ToString( item[ "Status" ] );
					pessoa.Status = Convert.ToBoolean( status );
					pessoa.E_Rua = Convert.ToString( item[ "Rua" ] );
					pessoa.E_Numero = Convert.ToString( item[ "Numero" ] );
					pessoa.E_Bairro = Convert.ToString( item[ "Bairro" ] );
					pessoa.E_Cep = Convert.ToString( item[ "Cep" ] );
					pessoa.E_Cidade = Convert.ToString( item[ "Cidade" ] );
					pessoa.DataCadastro = Convert.ToDateTime( item[ "DataCadastro" ] );

					listaPessoaColection.Add( pessoa );
				}
				return listaPessoaColection;
			}
			catch ( Exception exception )
			{
				Console.WriteLine( "Erro " + exception.Message );
			}

			return null;
		}


		public Pessoa.PessoaCollection ListarPessoasPesquisa(string pesquisa)
		{
			try
			{
				dbDizimo.LimparParametros();
				dbDizimo.AdicionarParametros( "@pesquisa", pesquisa );
				Pessoa.PessoaCollection listaPessoaColection = new Pessoa.PessoaCollection();
				DataTable dataTable = dbDizimo.ExecutaConsulta( CommandType.Text,
				" SELECT " +
				" P.ID, P.Nome, P.Telefone, P.Email, P.[Status],P.DataCadastro, " +
				" E.Rua, E.Numero, E.Bairro, E.Cep, E.Cidade " +
				" FROM Pessoa P " +
				" LEFT OUTER JOIN Endereco E ON P.ID = E.IdPessoa " +
				" WHERE P.Nome LIKE'%'+@pesquisa+'%' OR P.Email LIKE'%'+@pesquisa+'%' OR E.Cidade LIKE'%'+@pesquisa+'%'" +
				" ORDER BY ID ASC " );

				//Percorrer o DataTable 
				//Cada linha do datatable é um Registro
				//for = para  each cada

				foreach ( DataRow item in dataTable.Rows )
				{
					var pessoa = new Pessoa();
					//colocar dados da linha nele

					pessoa.ID = Convert.ToInt32( item[ "ID" ] );
					pessoa.Nome = Convert.ToString( item[ "Nome" ] );
					pessoa.Email = Convert.ToString( item[ "Email" ] );
					pessoa.Telefone = Convert.ToString( item[ "Telefone" ] );
					string status = Convert.ToString( item[ "Status" ] );
					pessoa.Status = Convert.ToBoolean( status );
					pessoa.E_Rua = Convert.ToString( item[ "Rua" ] );
					pessoa.E_Numero = Convert.ToString( item[ "Numero" ] );
					pessoa.E_Bairro = Convert.ToString( item[ "Bairro" ] );
					pessoa.E_Cep = Convert.ToString( item[ "Cep" ] );
					pessoa.E_Cidade = Convert.ToString( item[ "Cidade" ] );
					pessoa.DataCadastro = Convert.ToDateTime( item[ "DataCadastro" ] );

					listaPessoaColection.Add( pessoa );
				}
				return listaPessoaColection;
			}
			catch ( Exception exception )
			{
				Console.WriteLine( "Erro " + exception.Message );
			}

			return null;
		}

	}
}

