namespace Console_app_exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var oracle = new OracleConnection("Oracle.connection");
            var dbCommand = new DbCommand(oracle,"select * from table");
            dbCommand.Execute();
            Console.WriteLine();
            var sql = new SqlConnection("Sql.connection");
            var dbCommand2 = new DbCommand(sql, "delete from table");
            dbCommand2.Execute();
            Console.ReadLine();
        }
    }
}