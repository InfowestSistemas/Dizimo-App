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
	public class EnderecoApp
	{
		DizimoDB dbDizimo = new DizimoDB();
		public Endereco Create( Endereco endereco )
		{
			try
			{

				dbDizimo.LimparParametros();
				dbDizimo.AdicionarParametros( "@ID ", "" );
				dbDizimo.AdicionarParametros( "@IdPessoa", endereco.IdPessoa );
				dbDizimo.AdicionarParametros( "@Rua", endereco.Rua );
				dbDizimo.AdicionarParametros( "@Numero", endereco.Numero );
				dbDizimo.AdicionarParametros( "@Bairro", endereco.Bairro );
				dbDizimo.AdicionarParametros( "@Cep", endereco.Cep );
     			dbDizimo.AdicionarParametros( "@Cidade", endereco.Cidade );
				dbDizimo.AdicionarParametros( "@DataCadastro", DateTime.Now );

				string IdProcessamento = Convert.ToString( dbDizimo.ExecutarManipulacao( CommandType.Text,
				"   INSERT INTO ENDERECO  " +
				"   (IdPessoa,Rua,Numero,Bairro,Cep,Cidade,DataCadastro) " +
				"   VALUES (@IdPessoa,@Rua,@Numero,@Bairro,@Cep,@Cidade,@DataCadastro) "+
				"    SET @ID = @@IDENTITY; " +
				"    SELECT (@ID) AS Retorno  "
				) );

				if ( !string.IsNullOrEmpty( IdProcessamento ) )
				{
					endereco.ID = Convert.ToInt32( IdProcessamento );

				}
				return endereco;
			}
			catch ( Exception exception )
			{

				Console.WriteLine( "Erro" + exception );

			}

			return endereco;
		}

		public Endereco Update( Endereco endereco )
		{
			try
			{
				dbDizimo.AdicionarParametros( "@Id", endereco.ID );
				dbDizimo.AdicionarParametros( "@Rua", endereco.Rua );
				dbDizimo.AdicionarParametros( "@Numero", endereco.Numero );
				dbDizimo.AdicionarParametros( "@Bairro", endereco.Bairro );
				dbDizimo.AdicionarParametros( "@Cep", endereco.Cep );
				dbDizimo.AdicionarParametros( "@Cidade", endereco.Cidade );
				dbDizimo.AdicionarParametros( "@DataCadastro", DateTime.Now );


				string IdProcessamento = Convert.ToString( dbDizimo.ExecutarManipulacao( CommandType.Text,
				"   UPDATE ENDERECO  " +
				"   SET Rua=@Rua,Numero=@Numero,Bairro=@Bairro,Cep=@Cep,Cidade=@Cidade,DataCadastro=@DataCadastro " +
				"   WHERE ID=@ID " +
				"  SELECT (@ID) AS Retorno  "
				) );

				if ( !string.IsNullOrEmpty( IdProcessamento ) )
				{
					endereco.ID = Convert.ToInt32( IdProcessamento );

				}
				return endereco;
			}
			catch ( Exception exception )
			{

				Console.WriteLine( "Erro" + exception );

			}

			return endereco;
		}

		public string Delete( Endereco endereco )
		{
			try
			{
				dbDizimo.LimparParametros();

				dbDizimo.AdicionarParametros( "@ID", endereco.ID );
				string IdProcessamento = Convert.ToString( dbDizimo.ExecutarManipulacao( CommandType.Text,
				" DELETE ENDERECO WHERE ID=@ID" ) );


				return IdProcessamento;
			}
			catch ( Exception exception )
			{

				return exception.Message;
			}
		}

		public Endereco.EnderecoCollection ListaEnderecos()
		{
			try
			{
				dbDizimo.LimparParametros();
				Endereco.EnderecoCollection listaEnderecoColection = new Endereco.EnderecoCollection();
				DataTable dataTable = dbDizimo.ExecutaConsulta( CommandType.Text,
				" SELECT * FROM ENDERECO ORDER BY Endereco ASC " );

				//Percorrer o DataTable 
				//Cada linha do datatable é um Registro
				//for = para  each cada

				foreach ( DataRow item in dataTable.Rows )
				{
					var endereco = new Endereco();
					//colocar dados da linha nele
					endereco.ID = Convert.ToInt32( item[ "ID" ] );
					endereco.IdPessoa = Convert.ToInt32( item[ "IdPessoa" ] );
					endereco.Rua = Convert.ToString( item[ "Rua" ] );
					endereco.Numero = Convert.ToString( item[ "Numero" ] );
					endereco.Bairro = Convert.ToString( item[ "Bairro" ] );
					endereco.Cep = Convert.ToString( item[ "Cep" ] );
					endereco.Cidade = Convert.ToString( item[ "Cidade" ] );
					endereco.DataCadastro = Convert.ToDateTime( item[ "DataCadastro" ] );


					listaEnderecoColection.Add( endereco );
				}
				return listaEnderecoColection;
			}
			catch ( Exception exception )
			{
				Console.WriteLine( "Erro " + exception.Message );
			}

			return null;
		}

		public Endereco ListaEnderecoPorIDPessoa(int IdPessoa)
		{
			var endereco = new Endereco();
			try
			{
				dbDizimo.LimparParametros();
				dbDizimo.AdicionarParametros( "@IdPessoa", IdPessoa );
				DataTable dataTable = dbDizimo.ExecutaConsulta( CommandType.Text,
				" SELECT * FROM Endereco " +
				" WHERE IdPessoa=@IdPessoa " +
				" ORDER BY ID ASC "
				);

				//Percorrer o DataTable 
				//Cada linha do datatable é um Registro
				//for = para  each cada

				foreach ( DataRow item in dataTable.Rows )
				{
					
					//colocar dados da linha nele
					endereco.ID = Convert.ToInt32( item[ "ID" ] );
					endereco.IdPessoa = Convert.ToInt32( item[ "IdPessoa" ] );
					endereco.Rua = Convert.ToString( item[ "Rua" ] );
					endereco.Numero = Convert.ToString( item[ "Numero" ] );
					endereco.Bairro = Convert.ToString( item[ "Bairro" ] );
					endereco.Cep = Convert.ToString( item[ "Cep" ] );
					endereco.Cidade = Convert.ToString( item[ "Cidade" ] );
					endereco.DataCadastro = Convert.ToDateTime( item[ "DataCadastro" ] );
 
				}

				return endereco;
			}
			catch ( Exception exception )
			{
				Console.WriteLine( "Erro " + exception.Message );
			}

			return endereco;
		}


	}

}
