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
	

        public FluxoCaixa Create( FluxoCaixa fluxocaixa )
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
		public string Delete(int Id)
		{
			try
			{
				dbDizimo.LimparParametros();

				dbDizimo.AdicionarParametros("@ID", Id);
				string IdProcessamento = Convert.ToString(dbDizimo.ExecutarManipulacao(CommandType.Text,
				"   DELETE FluxoCaixa WHERE ID=@ID" +
				"    SELECT (@ID) AS Retorno  "
				));

				return IdProcessamento;
			}
			catch (Exception exception)
			{

				return exception.Message;
			}
		}
		public FluxoCaixa.FluxocaixaCollection Listarfluxocaixa()
		{
			try
			{
				dbDizimo.LimparParametros();
				FluxoCaixa.FluxocaixaCollection listaFluxoCaixaColection = new FluxoCaixa.FluxocaixaCollection();
				DataTable dataTable = dbDizimo.ExecutaConsulta(CommandType.Text,
				" SELECT " +
				" P.ID, P.IdPessoa, P.DizimoCategoria, P.Valor,P.DataCadastro, " +
				" E.ID, E.Descricao " +
				" FROM FluxoCaixa P " +
				" LEFT OUTER JOIN FluxoTipo E ON P.ID = E.Descricao " +
				" ORDER BY ID ASC ");

				//Percorrer o DataTable 
				//Cada linha do datatable é um Registro
				//for = para  each cada

				foreach (DataRow item in dataTable.Rows)
				{
					var FluxoCaixa = new FluxoCaixa();
					//colocar dados da linha nele

					FluxoCaixa.ID = Convert.ToInt32(item["ID"]);
					FluxoCaixa.IdPessoa = Convert.ToInt32(item["IdPessoa"]);
					FluxoCaixa.DizimoCategoria = Convert.ToString(item["DizimoCategoria"]);
					FluxoCaixa.Valor = Convert.ToDecimal(item["Valor"]);							
					FluxoCaixa.DataCadastro = Convert.ToDateTime(item["DataCadastro"]);

                    listaFluxoCaixaColection.Add(FluxoCaixa);
				}
				return listaFluxoCaixaColection;
			}
			catch (Exception exception)
			{
				Console.WriteLine("Erro " + exception.Message);
			}

			return null;
		}

     
    }
}
