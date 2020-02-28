using MongoDB.Bson;
using MongoDB.Driver;
using NOSQL_Project_groep8.Model;
using System;

namespace NOSQL_Project_groep8.Repositories
{
    class DashboardIncidentsRepository
    {
        private ConfigDB ConfigDB;
        public DashboardIncidentsRepository()
        {
             ConfigDB = new ConfigDB();
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
