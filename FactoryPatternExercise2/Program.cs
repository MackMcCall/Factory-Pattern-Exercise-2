namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What type of database do you want to use? List, SQL, or Mongo?");
            string userDBType = Console.ReadLine();
            IDataAccess dataAccess =  DataAccessFactory.GetDataAccessType(userDBType);
            dataAccess.LoadData();
            dataAccess.SaveData();
        }
    }
}
