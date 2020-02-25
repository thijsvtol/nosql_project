using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using System.Configuration;
using NOSQL_Project_groep8.Model;

namespace NOSQL_Project_groep8.Controller
{
    class IndexController
    {
        private static string _connectionString = ConfigurationManager.ConnectionStrings["MongoDB"].ToString();

        public string GetSampleData()
        {
            string s = null;
            //Make Client
            MongoClient dbClient = new MongoClient(_connectionString);
            //Select database
            var database = dbClient.GetDatabase("GardenGroup");
            //Select collection
            var collection = database.GetCollection<IncidentsModel>("Incidents");
            //Get results (select)
            var all = collection.Find(new BsonDocument());

            foreach (var i in all.ToEnumerable())
            {
                s += i.IncidentId.ToString() + "\r\n";
            }
            return s;
        }
    }
}
