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
        private FilterDefinitionBuilder<IncidentModel> Builder = Builders<IncidentModel>.Filter;

        public IncidentRepository()
        {
            ConfigDB = new ConfigDB();
        }
        
        /// <summary>
        /// Count the open incidents
        /// </summary>
        /// <returns></returns>
        public int CountOpenIncidents(int userId, bool adminRights)
        {
            //Select collection
            var collection = ConfigDB.GetDatabase().GetCollection<IncidentModel>("Incidents");
            //Count documents (select)
            var filter1 = Builder.Eq(x => x.Status, "open");
            var filter2 = Builder.Eq(x => x.Status, "open") & Builder.Eq(x => x.UserId, userId);
            double count;
            if (adminRights)
                count = collection.CountDocuments(filter1);
            else
                count = collection.CountDocuments(filter2);
            return Convert.ToInt32(count);
        }

        /// <summary>
        /// Count the closed incidents
        /// </summary>
        /// <returns></returns>
        public int CountClosedIncidentsBeforeDealine(int userId, bool adminRights)
        {
            //Select collection
            var collection = ConfigDB.GetDatabase().GetCollection<IncidentModel>("Incidents");
            //Count documents (select)
            DateTime dateTime = DateTime.Now;
            var filter1 = Builder.Eq(x => x.Status, "closed") & Builder.Gte(x => x.DateDeadline, dateTime);
            var filter2 = Builder.Eq(x => x.Status, "closed") & Builder.Gte(x => x.DateDeadline, dateTime) & Builder.Eq(x => x.UserId, userId);
            double count;
            if (adminRights)
                count = collection.CountDocuments(filter1);
            else
                count = collection.CountDocuments(filter2);
            return Convert.ToInt32(count);
        }

        /// <summary>
        /// Count the past deadline incidents
        /// </summary>
        /// <returns></returns>
        public int CountPastDeadlineIncidents(int userId, bool adminRights)
        {
            //Select collection
            var collection = ConfigDB.GetDatabase().GetCollection<IncidentModel>("Incidents");
            //Count documents (select)
            DateTime dateTime = DateTime.Now;
            var filter1 = Builder.Lte(x => x.DateDeadline, dateTime) & Builder.Eq(x => x.Status, "open");
            var filter2 = Builder.Lte(x => x.DateDeadline, dateTime) & Builder.Eq(x => x.Status, "open") & Builder.Eq(x => x.UserId, userId);
            double count;
            if (adminRights)
                count = collection.CountDocuments(filter1);
            else
                count = collection.CountDocuments(filter2);
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

        public IncidentModel GetIncidentByID(int UserId)
        {
            //Select collection
            var collection = ConfigDB.GetDatabase().GetCollection<IncidentModel>("Incidents");
            //Count documents (select)
            var filter = Builders<IncidentModel>.Filter.Eq(x => x.IncidentId, UserId);
            IncidentModel incident = collection.Find(filter).FirstOrDefault();

            return incident;
        }
    }
}
