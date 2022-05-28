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
	class PessoaApp
	{
		DizimoDB dbDizimo = new DizimoDB();

		public string Create(Pessoa pessoa)
		{
			try
			{
				dbDizimo.LimparParametros();

				dbDizimo.AdicionarParametros("@IdPessoa", 1);
				dbDizimo.AdicionarParametros("@Nome", pessoa.Nome);
				dbDizimo.AdicionarParametros("@Telefone", pessoa.Telefone);
				dbDizimo.AdicionarParametros("@Email", pessoa.Email);
				dbDizimo.AdicionarParametros("@DataCadastro", DateTime.Now);
				dbDizimo.AdicionarParametros("@Status", true);

				string IdProcessamento = Convert.ToString(dbDizimo.ExecutarManipulacao(CommandType.Text,
				"   INSERT INTO PESSOA  " +
				"   (IdPessoa,Nome,Telefone,Email,DataCadastro,Status) " +
				"   VALUES (@IdPessoa,@Nome,@Telefone,@Email@,DataCadastro,@Status) "));


				return IdProcessamento;
			}
			catch (Exception exception)
			{

				return exception.Message;

			}
		}

		public string Update( Pessoa pessoa)
        {
			try
			{
				dbDizimo.LimparParametros();

				
				dbDizimo.AdicionarParametros("@IdPessoa", pessoa.IdPessoa);
				dbDizimo.AdicionarParametros("@Nome", pessoa.Nome);
				dbDizimo.AdicionarParametros("@Telefone", pessoa.Telefone);
				dbDizimo.AdicionarParametros("@Email", pessoa.Email);
				dbDizimo.AdicionarParametros("@DataCadastro", DateTime.Now);
				dbDizimo.AdicionarParametros("@Status", pessoa.Status);

				string IdProcessamento = Convert.ToString(dbDizimo.ExecutarManipulacao(CommandType.Text,
				"   UPDATE PESSOA  " +
				"   SET IdPessoa=@IdPessoa,Nome=@Nome,Telefone=@Telefone,Email=@Email,DataCadastro=GETDATE(),Status=@Status " +
				"   WHERE ID=@ID "));


				return IdProcessamento;
			}
			catch (Exception exception)
			{

				return exception.Message;

			}
		}

		public string Delete( Pessoa pessoa)
        {
			try
			{
				dbDizimo.LimparParametros ( );

				dbDizimo.AdicionarParametros ( "@ID", pessoa.ID );
				string IdProcessamento = Convert.ToString ( dbDizimo.ExecutarManipulacao ( CommandType.Text,
				"   DELETE Usuario WHERE ID=@ID" ) );


				return IdProcessamento;
			}
			catch ( Exception exception )
			{

				return exception.Message;
			}
        }

		public Pessoa.PessoaCollection ListaPessoas()
        {
			try
			{
				dbDizimo.LimparParametros();
				Pessoa.PessoaCollection listaPessoaColection = new Pessoa.PessoaCollection();
				DataTable dataTable = dbDizimo.ExecutaConsulta(CommandType.Text,
				" SELECT * FROM  PESSOA ORDER BY Pessoa ASC ");

				//Percorrer o DataTable 
				//Cada linha do datatable é um Registro
				//for = para  each cada

				foreach (DataRow item in dataTable.Rows)
				{
					var pessoa = new Pessoa();
					//colocar dados da linha nele
					
					pessoa.IdPessoa = Convert.ToInt32(item["IdPessoa"]);
					pessoa.Nome = Convert.ToString(item["Nome"]);
					pessoa.Telefone = Convert.ToInt32(item["Telefone"]); 
					pessoa.Email = Convert.ToString(item["Email"]); 
					pessoa.DataDeCadastro = Convert.ToInt32(item["DataCadastro"]);
					pessoa.Status = Convert.ToString(item["Status"]);
		

					listaPessoaColection.Add(pessoa);
				}
				return listaPessoaColection;
			}
			catch (Exception exception)
			{
				Console.WriteLine("Erro " + exception.Message);
			}

			return null;
		}
}   }

