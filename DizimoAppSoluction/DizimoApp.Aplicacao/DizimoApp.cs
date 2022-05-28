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
    class DizimoApp
    {
        DizimoDB dbDizimo = new DizimoDB();
		public string Create(Dizimo dizimo)
		{
			try
			{
				dbDizimo.AdicionarParametros("@Id", dizimo.Id);
				dbDizimo.AdicionarParametros("@IdPessoa", 1);
				dbDizimo.AdicionarParametros("@DizimoCategoria", dizimo.DizimoCategoria);
				dbDizimo.AdicionarParametros("@Valor", dizimo.Valor);
				dbDizimo.AdicionarParametros("@DataCadastro", DateTime.Now);
			
				string IdProcessamento = Convert.ToString(dbDizimo.ExecutarManipulacao(CommandType.Text,
				"   INSERT INTO DIZIMO  " +
				"   (Id,IdPessoa,DizimoCategoria,Valor,DataCadastro) " +
				"   VALUES (Id,@IdPessoa,@DizimoCategoria,@Valor,@DataCadastro) "));


				return IdProcessamento;
			}
			catch (Exception exception)
			{

				return exception.Message;
			}
		}

		public string Update(Dizimo dizimo)
		{
			try
			{
				dbDizimo.LimparParametros();

				dbDizimo.AdicionarParametros("@Id", dizimo.ID);
				dbDizimo.AdicionarParametros("@IdPessoa", dizimo.IdPessoa);
				dbDizimo.AdicionarParametros("@DizimoCategoria", dizimo.DizimoCategoria);
				dbDizimo.AdicionarParametros("@Valor", dizimo.Valor);
				dbDizimo.AdicionarParametros("@DataCadastro", DateTime.Now);
				

				string IdProcessamento = Convert.ToString(dbDizimo.ExecutarManipulacao(CommandType.Text,
				"   UPDATE DIZIMO  " +
				"   SET Id=@Id,IdPessoa=@IdPessoa,DizimoCategoria=@DizimoCategoria,Valor=@Valor,DataCadastro=GETDATE() " +
				"   WHERE ID=@ID "));


				return IdProcessamento;
			}
			catch (Exception exception)
			{

				return exception.Message;
			}
		}

		public string Delete(Dizimo dizimo)
		{
			try
			{
				
				dbDizimo.AdicionarParametros("@ID", dizimo.ID);
				string IdProcessamento = Convert.ToString(dbDizimo.ExecutarManipulacao(CommandType.Text,
				"   DELETE Dizimo WHERE ID=@ID"));


				return IdProcessamento;
			}
			catch (Exception exception)
			{

				return exception.Message;
			}
		}

		public Dizimo.DizimoCollection ListaDizimos()
		{
			try
			{
				dbDizimo.LimparParametros();
				Dizimo.DizimoCollection listaDizimoColection = new Dizimo.DizimoCollection();
				DataTable dataTable = dbDizimo.ExecutaConsulta(CommandType.Text,
				" SELECT * FROM  DIZIMO ORDER BY Dizimo ASC ");

				//Percorrer o DataTable 
				//Cada linha do datatable é um Registro
				//for = para  each cada

				foreach (DataRow item in dataTable.Rows)
				{
					var dizimo = new Dizimo();
					//colocar dados da linha nele
					dizimo.ID = Convert.ToInt32(item["ID"]);
					dizimo.IdPessoa = Convert.ToString(item["IdPessoa"]);
					dizimo.DizimoCategoria = Convert.ToInt32(item["DizimoCategoria"]);
					dizimo.Valor = Convert.ToDouble(item["Valor"]);
					dizimo.DataCadastro = Convert.ToInt32(item["DataCadastro"]);


					listaDizimoColection.Add(dizimo);
				}
				return listaDizimoColection;
			}
			catch (Exception exception)
			{
				Console.WriteLine("Erro " + exception.Message);
			}

			return null;
		}


	}
}
