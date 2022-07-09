using DizimoApp.Dominio;
using DizimoApp.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace DizimoApp.Aplicacao
{
    public class FluxoCaixaApp
    {
        DizimoDB dbDizimo = new DizimoDB();
	

        public Fluxocaixa Create( Fluxocaixa fluxocaixa )
		{
			try
			{
				dbDizimo.LimparParametros();
				dbDizimo.AdicionarParametros("@ID ", "");
				dbDizimo.AdicionarParametros("@IdPessoa", fluxocaixa.IdPessoa);
				dbDizimo.AdicionarParametros("@DizimoCategoria", fluxocaixa.DizimoCategoria);
				dbDizimo.AdicionarParametros("@Valor", fluxocaixa.Valor);
				dbDizimo.AdicionarParametros("@DataCadastro", DateTime.Now);

				string IdProcessamento = Convert.ToString(dbDizimo.ExecutarManipulacao(CommandType.Text,
				"   INSERT INTO FluxoCaixa  " +
				"   (ID,IdPessoa,DizimoCategoria,Valor,DataCadastro) " +
				"   VALUES (@ID,@IdPessoa,@DizimoCategoria,@Valor,@DataCadastro) " +
				"    SET @ID = @@IDENTITY; " +
				"    SELECT (@ID) AS Retorno  "
				));
				if (!string.IsNullOrEmpty(IdProcessamento))
				{
					fluxocaixa.ID = Convert.ToInt32(IdProcessamento);

				}
				return fluxocaixa;
			}
			catch (Exception exception)
			{

				Console.WriteLine("Erro" + exception);

			}

			return fluxocaixa;
		}
		public FluxoCaixa Update( FluxoCaixa fluxocaixa )
		{
			try
			{
				dbDizimo.LimparParametros();


				dbDizimo.AdicionarParametros("@ID", fluxocaixa.ID);
				dbDizimo.AdicionarParametros("@IdPessoa", fluxocaixa.IdPessoa);
				dbDizimo.AdicionarParametros("@DizimoCategoria", fluxocaixa.DizimoCategoria);
				dbDizimo.AdicionarParametros("@Valor", fluxocaixa.Valor);
				dbDizimo.AdicionarParametros("@DataCadastro", DateTime.Now);
			
				string IdProcessamento = Convert.ToString(dbDizimo.ExecutarManipulacao(CommandType.Text,
				"   UPDATE Fluxocaixa  " +
				"   SET ID=@ID,IdPessoa=@IdPessoa,DizimoCategoria=@DizimoCategoria,Valor=@Valor,DataCadastro=@DataCadastro " +
				"   WHERE ID=@ID " +
				"  SELECT (@ID) AS Retorno  "
				));

				if (!string.IsNullOrEmpty(IdProcessamento))
				{
					pessoa.ID = Convert.ToInt32(IdProcessamento);

				}
				return fluxocaixa;
			}
			catch (Exception exception)
			{
				Console.WriteLine("Erro" + exception);
			}

			return fluxocaixa;
		}
		public string Delete(int Id)
		{
			try
			{
				dbDizimo.LimparParametros();

				dbDizimo.AdicionarParametros("@ID", Id);
				string IdProcessamento = Convert.ToString(dbDizimo.ExecutarManipulacao(CommandType.Text,
				"   DELETE PESSOA WHERE ID=@ID" +
				"    SELECT (@ID) AS Retorno  "
				));

				return IdProcessamento;
			}
			catch (Exception exception)
			{

				return exception.Message;
			}
		}
		public FluxoCaixaApp.FluxoCaixaCollection ListarFluxoCaixa()
		{
			try
			{
				dbDizimo.LimparParametros();
				Pessoa.PessoaCollection listaPessoaColection = new Pessoa.PessoaCollection();
				DataTable dataTable = dbDizimo.ExecutaConsulta(CommandType.Text,
				" SELECT " +
				" P.ID, P.Nome, P.Telefone, P.Email, P.[Status],P.DataCadastro, " +
				" E.Rua, E.Numero, E.Bairro, E.Cep, E.Cidade " +
				" FROM Pessoa P " +
				" LEFT OUTER JOIN Endereco E ON P.ID = E.IdPessoa " +
				" ORDER BY ID ASC ");

				//Percorrer o DataTable 
				//Cada linha do datatable é um Registro
				//for = para  each cada

				foreach (DataRow item in dataTable.Rows)
				{
					var pessoa = new Pessoa();
					//colocar dados da linha nele

					pessoa.ID = Convert.ToInt32(item["ID"]);
					pessoa.Nome = Convert.ToString(item["Nome"]);
					pessoa.Email = Convert.ToString(item["Email"]);
					pessoa.Telefone = Convert.ToString(item["Telefone"]);
					string status = Convert.ToString(item["Status"]);
					pessoa.Status = Convert.ToBoolean(status);
					pessoa.E_Rua = Convert.ToString(item["Rua"]);
					pessoa.E_Numero = Convert.ToString(item["Numero"]);
					pessoa.E_Bairro = Convert.ToString(item["Bairro"]);
					pessoa.E_Cep = Convert.ToString(item["Cep"]);
					pessoa.E_Cidade = Convert.ToString(item["Cidade"]);
					pessoa.DataCadastro = Convert.ToDateTime(item["DataCadastro"]);

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

        public class FluxoCaixaCollection
        {
        }
    }
}
