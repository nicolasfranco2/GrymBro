using Npgsql;

public class DbConnection
{
    private readonly string _connectionString;

    public DbConnection(string host, string database, string username, string password)
    {
        _connectionString = $"Host={host};Database={database};Username={username};Password={password}";
    }

    public NpgsqlConnection GetConnection()
    {
        return new NpgsqlConnection(_connectionString);
    }

    public void OpenConnection(NpgsqlConnection conn)
    {
        if (conn.State != System.Data.ConnectionState.Open)
        {
            conn.Open();
        }
    }

    public void CloseConnection(NpgsqlConnection conn)
    {
        if (conn.State != System.Data.ConnectionState.Closed)
        {
            conn.Close();
        }
    }
}
