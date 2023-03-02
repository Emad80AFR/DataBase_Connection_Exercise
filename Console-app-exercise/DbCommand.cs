namespace Console_app_exercise;

public class DbCommand
{
        
    private readonly DbConnection _dbConnection;
    public string Instruction { get; set; }
    public DbCommand(DbConnection dbConnection, string instruction)
    {
        _dbConnection = dbConnection ?? throw new NullReferenceException();
        if (string.IsNullOrWhiteSpace(instruction))
            throw new ArgumentNullException();
        Instruction = instruction;
    }

    public void Execute()
    {
        _dbConnection.OpenConnection();
        Console.WriteLine(Instruction);
        _dbConnection.CloseConnection();
    }
}