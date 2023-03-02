namespace Console_app_exercise;

public class OracleConnection : DbConnection
{
    public OracleConnection(string connectionString) : base(connectionString)
    {
    }

    public override void OpenConnection()
    {
        Console.WriteLine("OracleConnection opened successfully!");
    }

    public override void CloseConnection()
    {
        Console.WriteLine("OracleConnection closed successfully !");
    }
}