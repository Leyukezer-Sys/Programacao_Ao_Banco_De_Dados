using MySql.Data.MySqlClient;

namespace ApiTarefas_Aula01.DataBase
{
    public class ConnectionMysql
    {
        private static readonly string host = "localhost";
        private static readonly string port = "3308";
        private static readonly string user = "root";
        private static readonly string password = "root";
        private static readonly string dbname = "tarefas_db";
        private static MySqlConnection? _connection;
        private static MySqlCommand _command;

        public ConnectionMysql()
        {
            try
            {
                _connection = new MySqlConnection($"server={host};database={dbname};port={port};user={user};password={password}");
                _connection.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                throw;
            }
        }

        public MySqlCommand Query()
        {
            try
            {
                _command = _connection.CreateCommand();
                _command.CommandType = System.Data.CommandType.Text;

                return _command;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public void Close()
        {
            _connection.Close();
        }
    }
}
