namespace Console_app_exercise;

public abstract class DbConnection
{
    public string ConnectionString { get; set; }
    public TimeSpan TimeOut { get; set; }

    protected DbConnection(string connectionString)
    {
        var timeOut = DateTime.Now;
        if(string.IsNullOrWhiteSpace(connectionString))
            throw new ArgumentNullException(nameof(connectionString));
        ConnectionString = connectionString;
        if ((timeOut - DateTime.Now).Seconds > 1)
            throw new TimeoutException();
        TimeOut = timeOut - DateTime.Now;
    }

    public abstract void OpenConnection();
    public abstract void CloseConnection();
}