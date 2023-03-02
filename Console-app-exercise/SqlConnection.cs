namespace Console_app_exercise;

public class SqlConnection:DbConnection
{
    public SqlConnection(string connectionString) : base(connectionString)
    {
    }

    public override void OpenConnection()
    {
        Console.WriteLine("SqlConnection opened successfully!");
    }

    public override void CloseConnection()
    {
        Console.WriteLine("SqlConnection closed successfully !");
    }
}