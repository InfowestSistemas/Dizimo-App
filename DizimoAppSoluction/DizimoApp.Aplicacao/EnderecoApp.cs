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
    class EnderecoApp
    {
        DizimoDB dbDizimo = new DizimoDB();
        public string Create( Endereco endereco)
        {
			try
			{
				
				dbDizimo.AdicionarParametros("@Id", 1);
				dbDizimo.AdicionarParametros("@Rua", endereco.Rua);
				dbDizimo.AdicionarParametros("@Numero", endereco.Numero);
				dbDizimo.AdicionarParametros("@Bairro", endereco.Bairro);
				dbDizimo.AdicionarParametros("@Cep", endereco.Cep);
				dbDizimo.AdicionarParametros("@Cidade", endereco.Cidade);
				dbDizimo.AdicionarParametros("@DataCadastro", DateTime.Now);
				

				string IdProcessamento = Convert.ToString(dbDizimo.ExecutarManipulacao(CommandType.Text,
				"   INSERT INTO ENDERECO  " +
				"   (Id,Rua,Numero,Bairro,Cep,Cidade,DataCadastro) " +
				"   VALUES (@Id,@Rua,@Numero,@Bairro,@Cep,@Cidade,@DataCadastro) "));


				return IdProcessamento;
			}
			catch (Exception exception)
			{

				return exception.Message;
			}
		}

		public string Update( Endereco endereco)
        {
			try
			{
				dbDizimo.AdicionarParametros("@Id", endereco.ID);
				dbDizimo.AdicionarParametros("@Rua", endereco.Rua);
				dbDizimo.AdicionarParametros("@Numero", endereco.Numero);
				dbDizimo.AdicionarParametros("@Bairro", endereco.Bairro); 
				dbDizimo.AdicionarParametros("@Cep", endereco.Cep); 
				dbDizimo.AdicionarParametros("@Cidade", endereco.Cidade); 
				dbDizimo.AdicionarParametros("@DataCadastro", DateTime.Now);
				

				string IdProcessamento = Convert.ToString(dbDizimo.ExecutarManipulacao(CommandType.Text,
				"   UPDATE ENDERECO  " +
				"   SET Rua=@Rua,Numero=@Numero,Bairro=@Bairro,Cep=@Cep,Cidade=@Cidade,DataCadastro=GETDATE(),Status=@Status " +
				"   WHERE ID=@ID "));


				return IdProcessamento;
			}
			catch (Exception exception)
			{

				return exception.Message;
			}
		}

		public string Delete( Endereco endereco)
        {
			try
			{
				dbDizimo.LimparParametros();

				dbDizimo.AdicionarParametros("@ID", endereco.ID);
				string IdProcessamento = Convert.ToString(dbDizimo.ExecutarManipulacao(CommandType.Text,
				"   DELETE Usuario WHERE ID=@ID"));


				return IdProcessamento;
			}
			catch (Exception exception)
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
				DataTable dataTable = dbDizimo.ExecutaConsulta(CommandType.Text,
				" SELECT * FROM  ENDERECO ORDER BY Endereco ASC ");

				//Percorrer o DataTable 
				//Cada linha do datatable é um Registro
				//for = para  each cada

				foreach (DataRow item in dataTable.Rows)
				{
					var endereco = new Endereco();
					//colocar dados da linha nele
					endereco.ID = Convert.ToInt32(item["ID"]);
					endereco.Rua = Convert.ToString(item["Rua"]);
					endereco.Numero = Convert.ToInt32(item["Numero"]);
					endereco.Bairro = Convert.ToString(item["Bairro"]);
					endereco.Cep = Convert.ToInt32(item["Numero"]);
					endereco.Cidade = Convert.ToString(item["Cidade"]);
					endereco.DataCadastro = Convert.ToInt32(item["DataCadastro"]);
				

					listaEnderecoColection.Add(endereco);
				}
				return listaEnderecoColection;
			}
			catch (Exception exception)
			{
				Console.WriteLine("Erro " + exception.Message);
			}

			return null;
		}
	}
    
}
