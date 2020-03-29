using NOSQL_Project_groep8.Model;
using NOSQL_Project_groep8.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace NOSQL_Project_groep8.Service
{
    class IncidentService
    {
        private ConfigDB ConfigDB;
        public IncidentService()
        {
            ConfigDB = new ConfigDB();
        }

        /// <summary>
        /// Creates new incident
        /// </summary>
        /// <param name="incident"></param>
        /// <returns></returns>
        public Boolean SetNewIncident(IncidentModel incident)
        {
            //Select collection
            var collection = ConfigDB.GetDatabase().GetCollection<IncidentModel>("Incidents");
            collection.InsertOne(incident);
            return true;
        }

        public void InsertIncidentModelList(List<IncidentModel> list)
        {
            //Select collection
            var collection = ConfigDB.GetDatabase().GetCollection<IncidentModel>("Incidents");
            collection.InsertMany(list);
        }

        public void DeleteIncident(IncidentModel incident)
        {
            var collection = ConfigDB.GetDatabase().GetCollection<IncidentModel>("Incidents");
            collection.DeleteOne(x => x.IncidentId == incident.IncidentId);

        }

        public Boolean ArchiveIncident(IncidentModel incident)
        {
            //Select collection
            var collection = ConfigDB.GetDatabase().GetCollection<IncidentModel>("Archive");
            collection.InsertOne(incident);
            return true;
        }
    }
}
