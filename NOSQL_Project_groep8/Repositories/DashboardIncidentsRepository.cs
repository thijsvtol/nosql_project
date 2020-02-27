using MongoDB.Bson;
using MongoDB.Driver;
using NOSQL_Project_groep8.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOSQL_Project_groep8.Repositories
{
    class DashboardIncidentsRepository
    {
        private static readonly string _connectionString = ConfigurationManager.ConnectionStrings["MongoDB"].ToString();
        private MongoClient dbClient = new MongoClient(_connectionString);

        public int CountOpenIncidents()
        {
            //Select database
            var database = dbClient.GetDatabase("GardenGroup");
            //Select collection
            var collection = database.GetCollection<IncidentsModel>("Incidents");
            //Count documents (select)
            var all = collection.Find(new BsonDocument());
            var filter = Builders<IncidentsModel>.Filter.Eq(x => x.Status, "Open");
            double count = collection.CountDocuments(filter);
            return Convert.ToInt32(count);
        }

        public int CountClosedIncidentsBeforeDealine()
        {
            //Select database
            var database = dbClient.GetDatabase("GardenGroup");
            //Select collection
            var collection = database.GetCollection<IncidentsModel>("Incidents");
            //Count documents (select)
            var all = collection.Find(new BsonDocument());
            var filter = Builders<IncidentsModel>.Filter.Eq(x => x.Status, "closed") & Builders<IncidentsModel>.Filter.Gt(x => x.DateDeadline, new DateTime());
            double count = collection.CountDocuments(filter);
            return Convert.ToInt32(count);
        }

        public int CountPastDeadlineIncidents()
        {
            //Select database
            var database = dbClient.GetDatabase("GardenGroup");
            //Select collection
            var collection = database.GetCollection<IncidentsModel>("Incidents");
            //Count documents (select)
            var all = collection.Find(new BsonDocument());
            var filter = Builders<IncidentsModel>.Filter.Eq(x => x.DateDeadline, new DateTime());
            double count = collection.CountDocuments(filter);
            return Convert.ToInt32(count);
        }
    }
}
