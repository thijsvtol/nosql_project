using MongoDB.Bson;
using MongoDB.Driver;
using NOSQL_Project_groep8.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOSQL_Project_groep8.Repositories
{
    class IncidentRepository
    {
        private ConfigDB ConfigDB;
        public IncidentRepository()
        {
            ConfigDB = new ConfigDB();
        }

        public Boolean SetNewIncident(IncidentsModel incident)
        {
            //Select collection
            var collection = ConfigDB.GetDatabase().GetCollection<IncidentsModel>("Incidents");

            collection.InsertOne(incident);

            return true;
        }

        public List<UsersModel> GetAllUsers()
        {
            //Select collection
            var collection = ConfigDB.GetDatabase().GetCollection<UsersModel>("Users");
            List<UsersModel> users = collection.Find(Builders<UsersModel>.Filter.Empty).ToList();

            return users;
        }

        public int CountOpenIncidents()
        {
            //Select collection
            var collection = ConfigDB.GetDatabase().GetCollection<IncidentsModel>("Incidents");
            //Count documents (select)
            var filter = Builders<IncidentsModel>.Filter.Eq(x => x.Status, "open");
            double count = collection.CountDocuments(filter);
            return Convert.ToInt32(count);
        }

        public int CountClosedIncidentsBeforeDealine()
        {
            //Select collection
            var collection = ConfigDB.GetDatabase().GetCollection<IncidentsModel>("Incidents");
            //Count documents (select)
            var builder = Builders<IncidentsModel>.Filter;
            DateTime dateTime = DateTime.Now;
            var filter = builder.Eq(x => x.Status, "closed") & builder.Gte(x => x.DateDeadline, dateTime);
            double count = collection.CountDocuments(filter);
            return Convert.ToInt32(count);
        }

        public int CountPastDeadlineIncidents()
        {
            //Select collection
            var collection = ConfigDB.GetDatabase().GetCollection<IncidentsModel>("Incidents");
            //Count documents (select)
            var builder = Builders<IncidentsModel>.Filter;
            DateTime dateTime = DateTime.Now;
            var filter = builder.Lte(x => x.DateDeadline, dateTime) & builder.Eq(x => x.Status, "open");
            double count = collection.CountDocuments(filter);
            return Convert.ToInt32(count);
        }
    }
}
