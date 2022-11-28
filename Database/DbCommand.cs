namespace Database;

partial class Program
{
    public class DbCommand
    {

        public DbConnection DbConnection {get; set; }
        public string Intstruction { get; set; }

        public DbCommand(DbConnection dbConnection, string instruction)
        {

            if(dbConnection == null)
            {
                throw new ArgumentNullException("dbConnection cannot be null.");
            }

            if (String.IsNullOrWhiteSpace(instruction))
            {
                throw new ArgumentNullException("Instruction cannot be null.");
            }


            this.DbConnection = dbConnection;
            this.Intstruction = instruction;

            

        }


        public void Execute()
        {
            DbConnection.Open();
            Console.WriteLine("Added to database: " + Instruction);
            DbConnection.Close();
        }






    }
}

