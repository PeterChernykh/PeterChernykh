namespace Homework11.DAL
{
    public static class Connection
    {
        public static string DetabaseConnection()
        {
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=Homework11DB;Integrated Security=True";

            return connectionString;
        }
    }
}
