using MySql.Data.MySqlClient;
using System.Text;

namespace TeraPMS
{
    public class Environment
    {
        private static readonly object m_lock = new object();
        private static Environment m_instance = null;
        public static Environment Get
        {
            get
            {
                lock (m_lock)
                {
                    if (m_instance == null)
                    {
                        m_instance = new Environment();
                    }
                    return m_instance;
                }
            }
        }

        public string server;
        public string port;
        public string username;
        public string password;
        public string database;

        public MySqlConnection conn;
        
        public Environment() {}

        public void ConnectDB()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append( $"server={server};" );
            sb?.Append( $"port={port};" );
            sb.Append( $"uid={username};" );
            sb.Append( $"pwd={password};" );
            sb.Append( $"database={database};" );
            // Handle MySqlException that may be thrown here
            conn = new MySqlConnection(sb.ToString());
            conn.Open();
        }

        public void CloseDB()
        {
            conn?.Close();
        }

        public MySqlCommand GetCommand()
        {
            return conn.CreateCommand();
        }
    }
}

