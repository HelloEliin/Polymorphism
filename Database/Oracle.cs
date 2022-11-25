namespace Database;

partial class Program
{
    public class Oracle : DbConnection
    {

        public override bool isRunning { get; set; }

        public Oracle(string ConnectionString) : base(ConnectionString)
        {

        }

        public override void Open()

        {


            if (!isRunning)
            {
                Console.WriteLine("Sql open.");

            }


            if (isRunning)
            {
                throw new InvalidOperationException("Already running.");

            }

            isRunning = true;


        }

        public override void Close()
        {
            if (isRunning)
            {
                Console.WriteLine("Sql closed.");

            }


            if (!isRunning)
            {
                throw new InvalidOperationException("Already closed.");

            }

        }
    }
}

