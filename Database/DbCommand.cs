namespace Database;

partial class Program
{
    public class DbCommand
    {

        public DbConnetion DbConnection {get; set; }
        public string Intstruction { get; set; }

        public DbCommand(DbConnetion dbConnection, string instruction)
        {

            if(dbConnection == null)
            {
                throw new ArgumentNullException("dbConnection cannot be null.");
            }


            this.DbConnection = dbConnection;
            this.Intstruction = instruction;

            

        }


        public void Execute()
        {
            DbConnection.Open();
            Console.WriteLine("Added to database: " + Intstruction);
            DbConnection.Close();
        }






    }
}

