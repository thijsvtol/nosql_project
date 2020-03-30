using MongoDB.Driver;
using System.Configuration;

namespace NOSQL_Project_groep8.Repositories
{
    public class ConfigDB
    {
        private static readonly string _connectionString = ConfigurationManager.ConnectionStrings["MongoDB"].ToString();
        private MongoClient dbClient = new MongoClient(_connectionString);
        public IMongoDatabase GetDatabase() { return dbClient.GetDatabase("GardenGroup");}
    }
}
