namespace Database;

partial class Program
{
    public abstract class DbConnection
    {
        public string ConnectionString { get; set; }
        public abstract bool isRunning { get; set; }

        public DbConnection(string ConnectionString)
       {
            this.ConnectionString = ConnectionString;
           

            if (String.IsNullOrWhiteSpace(ConnectionString))
            {
                throw new ArgumentNullException("ConnetionString cannot be empty");
            }


       }


        public abstract void Open();

        public abstract void Close();




    }

}

