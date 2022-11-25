namespace Database;

partial class Program
{
    static void Main(string[] args)
    {


        

        var sql = new Sql("KISSE");
        var oracle = new Oracle("KATT");

        var commandOne = new DbCommand(new Sql("KISSE"), "Katten");
        var commandTwo = new DbCommand(new Oracle("SMULAN"), "Kissen");

        commandOne.Execute();
        commandTwo.Execute();



    }
}

