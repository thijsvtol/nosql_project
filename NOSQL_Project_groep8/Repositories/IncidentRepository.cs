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
        
        /// <summary>
        /// Count the open incidents
        /// </summary>
        /// <returns></returns>
        public int CountOpenIncidents()
        {
            //Select collection
            var collection = ConfigDB.GetDatabase().GetCollection<IncidentModel>("Incidents");
            //Count documents (select)
            var filter = Builders<IncidentModel>.Filter.Eq(x => x.Status, "open");
            double count = collection.CountDocuments(filter);
            return Convert.ToInt32(count);
        }

        /// <summary>
        /// Count the closed incidents
        /// </summary>
        /// <returns></returns>
        public int CountClosedIncidentsBeforeDealine()
        {
            //Select collection
            var collection = ConfigDB.GetDatabase().GetCollection<IncidentModel>("Incidents");
            //Count documents (select)
            var builder = Builders<IncidentModel>.Filter;
            DateTime dateTime = DateTime.Now;
            var filter = builder.Eq(x => x.Status, "closed") & builder.Gte(x => x.DateDeadline, dateTime);
            double count = collection.CountDocuments(filter);
            return Convert.ToInt32(count);
        }

        /// <summary>
        /// Count the past deadline incidents
        /// </summary>
        /// <returns></returns>
        public int CountPastDeadlineIncidents()
        {
            //Select collection
            var collection = ConfigDB.GetDatabase().GetCollection<IncidentModel>("Incidents");
            //Count documents (select)
            var builder = Builders<IncidentModel>.Filter;
            DateTime dateTime = DateTime.Now;
            var filter = builder.Lte(x => x.DateDeadline, dateTime) & builder.Eq(x => x.Status, "open");
            double count = collection.CountDocuments(filter);
            return Convert.ToInt32(count);
        }

        /// <summary>
        /// Get all incidents
        /// </summary>
        /// <returns></returns>
        public List<IncidentModel> GetAllIncidents()
        {
            //Select collection
            var collection = ConfigDB.GetDatabase().GetCollection<IncidentModel>("Incidents");
            List<IncidentModel> incidents = collection.Find(Builders<IncidentModel>.Filter.Empty).ToList();

            return incidents;
        }

        /// <summary>
        /// Gets the last incidents Id for the next Incident
        /// </summary>
        /// <returns></returns>
        public int AutoIncredement()
        {
            var collection = ConfigDB.GetDatabase().GetCollection<IncidentModel>("Incidents");
            var sort = Builders<IncidentModel>.Sort.Descending(x => x.IncidentId);
            var filter = Builders<IncidentModel>.Filter.Empty;
            IncidentModel incident = collection.Find(filter).Sort(sort).Limit(1).FirstOrDefault();
            return (incident != null)? incident.IncidentId + 1: 1;
        }
    }
}
