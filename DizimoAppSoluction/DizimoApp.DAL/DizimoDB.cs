using System;
using System.Data;
using System.Data.SqlClient;
using DizimoApp.Repository.Properties;

namespace DizimoApp.Repository
{
	public class DizimoDB
	{
        //Criar Conexão com o Banco 
        SqlConnection sqlConnection = CriaConexaoSQLServer ( );

        //Método Cria Conexão DB
        private static SqlConnection CriaConexaoSQLServer()
        {

            return new SqlConnection ( Settings.Default.SQLConexaoDB );

        }
        // 2º Parâmetros que vão para o Banco 
        private SqlParameterCollection _sqlParameterCollection = new SqlCommand ( ).Parameters;

        private void AbrirConexao()
        {
            if ( sqlConnection.State == ConnectionState.Closed )
                sqlConnection.Open ( );
        }

        private void FecharConexao()
        {
            if ( sqlConnection.State == ConnectionState.Open )
                sqlConnection.Close ( );
        }

        public void LimparParametros()
        {
            _sqlParameterCollection.Clear ( );
        }

        public void AdicionarParametros( string nomeParametro, object valorParametro )
        {
            _sqlParameterCollection.Add ( new SqlParameter ( nomeParametro, valorParametro ) );
        }

        // 3º Persistencia de dados - CREATE /UPDATE /DELETE
        public object ExecutarManipulacao( CommandType commandType, string nomeStoredProcedureouSintaxeSQL )
        {
            try
            {

                //Abrir Conexão
                AbrirConexao ( );
                //Criar o comando que vai levar a informação/Ação para o banco 
                SqlCommand sqlCommand = sqlConnection.CreateCommand ( );
                //Inserindo dados dentro do comando que irá ao banco 
                sqlCommand.CommandType = commandType;
                sqlCommand.CommandText = nomeStoredProcedureouSintaxeSQL;
                sqlCommand.CommandTimeout = 7200;
                //Adicionar Parametros ao sqlComando usando foreach
                foreach ( SqlParameter sqlParameter in _sqlParameterCollection )
                {

                    sqlCommand.Parameters.Add ( new SqlParameter ( sqlParameter.ParameterName, sqlParameter.Value ) );

                }


                //Executa o comando , manda o comando ir até o banco e efetivar a transação
                return sqlCommand.ExecuteScalar ( );
            }
            catch ( Exception exception )
            {

                throw new Exception ( exception.Message );
            }
            finally
            {
                FecharConexao ( );
            }

        }

        //4º Consultar Registros do Banco de Dados : R - Read - 
        public DataTable ExecutaConsulta( CommandType commandType, string nomeStoredProcedureouSintaxeSQLSQL )
        {
            try
            {

                //Abrir Conexão
                FecharConexao ( );
                //Criar o comando que vai levar a informação/Ação para o banco 
                SqlCommand sqlCommand = sqlConnection.CreateCommand ( );
                //Inserindo dados dentro do comando que irá ao banco 
                sqlCommand.CommandType = commandType;
                sqlCommand.CommandText = nomeStoredProcedureouSintaxeSQLSQL;
                sqlCommand.CommandTimeout = 7200;

                //Adicionar Parametros ao sqlComando usando foreach
                foreach ( SqlParameter sqlParameter in _sqlParameterCollection )
                {

                    sqlCommand.Parameters.Add ( new SqlParameter ( sqlParameter.ParameterName, sqlParameter.Value ) );

                }
                //Cria um Adaptador para traduzir a linguagem do banco com a linguagem da aplicação
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter ( sqlCommand );

                //DataTable = Tabela de dados vazia onde será preenchido com os dados que retornarem do banco
                DataTable dataTable = new DataTable ( );

                //Mandar o comando ir ate o banco e buscar os dados e o adaptador preencher o datatable
                sqlDataAdapter.Fill ( dataTable );

                //Fecha Conexão
                sqlConnection.Close ( );

                return dataTable;

            }
            catch ( Exception exception )
            {

                throw new Exception ( exception.Message );
            }
            finally
            {
                FecharConexao ( );
            }
        }
    }
}
